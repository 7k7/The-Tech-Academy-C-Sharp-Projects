
namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT
{
    // This UserAccount class represents a generic account for a person
    // Properties are generic
    public class UserAccount
    {
        // Class constructor methods
        // This demonstrates chaining methods
        // Their purpose of each is to provide default parameter values
        // for any arguments a user does not provide
        // This ensures that all properties are initialized and assigned
        public UserAccount() : this("User1")
        {
            
        }
       
        public UserAccount(string userName) : this(userName, "none", "none")
        {

        }

        public UserAccount(string userName, string firstName, string lastName) : this(userName, firstName, lastName, 0)
        {

        }
        // This constructor is where each property is
        // initialized and assigned either a default property
        // or arguments when this class is instantiated
        public UserAccount(string userName, string firstName, string lastName, int age)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // properties set to private as this data is sensitive
        // and don't want to expose the fields anywhere else
        private string userName;
        private string firstName;
        private string lastName;
        private int age;

        // getters for to retrieve property values only
        // while protecting the fields
        public string UserName { get { return userName; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }
    }
}
