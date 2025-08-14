namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jobTitle = "Associate Software Engineer";
            int age = 42;
            char officeFloor = '5';
            bool isAgoodCoder = true;
            double trueCodersGradeAverage = 86.7;
            decimal newSalary = 123.456M;
            
            Console.WriteLine($"Bob graduated from the TrueCoders Bootcamp on his birthday and is now {age} years old.\nWhen he graduated his grade average was {trueCodersGradeAverage}.\nHis instructor was asked if Bob was a good coder as a job reference and he said {isAgoodCoder}.\nHe got a new job and his new job title is {jobTitle}.\nHe works at NASA on the {officeFloor} floor and his new salary is ${newSalary} thousand dollars a year. ");
        }
    }
}
