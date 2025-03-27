using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // The connection string to the DB table in quesiton
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=Newsletter;Integrated Security=True;
                                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;
                                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] // Best practice: always tag your controller methods that use the POST method
        // Model Binding is how MVC intelligently maps your Controller's parameters to incoming data from the View
        // Here, each parameter corresponds to the name atttribute of each input element on a html form in the view
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                return View("Success");
            }
        }

        public ActionResult Admin()

        {   
            // The actual query to the DB table as a string var
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber From SignUps";

            // Initialize a List of type NewsletterSignUp to contain all entities/records returned from query
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            // SQL connection wrapped in a using statement to manage resources
            // when connecting to the external db table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Initialize SQL command with query and SQLConnection
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open connection to external resouce
                connection.Open();

                // Execute the SQL command and assign result returned of the query
                // into a variable of type SqlDataReader 
                SqlDataReader reader = command.ExecuteReader();

                // Use the Read() of SqlDataReader to iterate through each record 
                // queried from the db table
                while (reader.Read())
                {
                    // initliaze the object we will populating with the queried data
                    var signup = new NewsletterSignUp();

                    // Add each column value to the object
                    // Remember to convert from SqlDataType to Csharp data type
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

                    // Add the object to the list
                    signups.Add(signup);
                }
                // Close the connection
                connection.Close();
            }
            // Map DB Entities to a View Model object
            var signupVms = new List<SignUpVm>();
            foreach (var signup in signups)
            {
                var signupvm = new SignUpVm();

                signupvm.FirstName = signup.FirstName;
                signupvm.LastName = signup.LastName;
                signupvm.EmailAddress = signup.EmailAddress;

                signupVms.Add(signupvm);
            }
            return View(signupVms);
        }
    }
}