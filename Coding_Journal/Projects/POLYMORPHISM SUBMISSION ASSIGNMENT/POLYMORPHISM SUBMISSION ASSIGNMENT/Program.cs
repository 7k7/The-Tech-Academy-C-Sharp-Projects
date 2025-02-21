
namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of type IQuittable
            // IQuittable is type because employee implements it
            IQuittable quitObject = new Employee();

            // call Quit() on the object
            quitObject.Quit();
        }
    }
}
