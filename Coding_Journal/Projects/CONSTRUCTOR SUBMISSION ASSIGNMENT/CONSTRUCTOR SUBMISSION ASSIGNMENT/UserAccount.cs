using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT
{
    public class UserAccount
    {
        public UserAccount() : this("User1")
        {
            
        }

        public UserAccount(string userName) : this(userName, "none", "none")
        {

        }

        public UserAccount(string userName, string firstName, string lastName) : this(userName, firstName, lastName, 0)
        {

        }

        public UserAccount(string userName, string firstName, string lastName, int age)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }



        // properties
        private string userName;
        private string firstName;
        private string lastName;
        private int age;

        // getters
        public string UserName { get { return userName; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }
    }
}
