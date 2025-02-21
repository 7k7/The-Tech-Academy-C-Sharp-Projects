
namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instance of Employee with first and names
            // as Sample and Student
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Calling the SayName() on this employee object
            employee.SayName();
        }
    }
}
