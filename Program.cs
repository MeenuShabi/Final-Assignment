using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new StudentMS
            {
                Name = "John Doe",
                Age = 20
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }

        Console.ReadLine();
    }
}
