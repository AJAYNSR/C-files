using System;

namespace Survey
{
    class Data
    {
        public int Name;
        public int Age;
        public int Gender;
        public void Display()
        {
            Console.WriteLine("Name :{0} | Age : {1} | Gender : {2}", Name, Age, Gender);
        }
    }
    class StudentDetail
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your name : ");
            data.Name = Input();
            Console.WriteLine("What is your age : ");
            data.Age = int.Parse(Input());
            Console.WriteLine("Mention your gender : ");
            data.Gender = Input();
            data.Display();
        }
        static string Input()
        {
            var question = Console.ReadLine();
            if(question == "")
            {
                Console.WriteLine("Incorrect Format, Please Enter Something");
                return Console.ReadLine();
            }
            return question;
        }
    }

}