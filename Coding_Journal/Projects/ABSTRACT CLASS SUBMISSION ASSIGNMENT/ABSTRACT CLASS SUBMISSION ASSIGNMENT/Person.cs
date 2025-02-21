
namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{   // This class defines a person. First and Last names
    public abstract class Person
    {
        // Two properties
        public string firstName {  get; set; }
        public string lastName { get; set; }

        // abstract method
        public abstract void SayName();
    }
}
