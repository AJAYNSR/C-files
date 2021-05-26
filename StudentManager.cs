using System;

namespace Csharp
{
    class StudentDetail
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of Students:");
            var StudentCount = int.Parse(Console.ReadLine());
            var StudentNames = new string[StudentCount];
            var StudentGrades = new int[StudentCount];
            for(int i=0;i<StudentCount;i++)
            {
                Console.WriteLine("Enter the Student Name:");
                StudentNames[i] = Console.ReadLine();
                Console.WriteLine("Enter The Grade of Student:");
                StudentGrades[i] = int.Parse(Console.ReadLine());

            }
            for(int i = 0;i<StudentCount;i++)
            {
                Console.WriteLine("Name:{0} | Grade:{1}",StudentNames[i],StudentGrades[i]);
            }
        }
    }
}