using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student()
            {
                Id = 1,
                Name = "Mr A",
                Age = 9
            };

            if (s.Age < 10)
            {
                throw new StudentAgeException("Student age is not valid");
            }

            Console.WriteLine(s.Name);
        }
    }
}
