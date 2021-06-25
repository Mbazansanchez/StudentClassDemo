using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student molly = new Student();
            molly.Name = "Molly the Cat";
            Console.WriteLine(molly.Name);
            molly.idNumber = 42;
            Console.WriteLine(molly.idNumber);*/
            Student.DoStuff();

            Student joe = new Student();
            joe.SetName("Joe Shmoe");
            string joesName = joe.GetName();
            Console.WriteLine("joe's name is {0}", joesName);

            Student jane = new Student();
            jane.SetName("Jane");
            Console.WriteLine("Jane's name is {0}", jane.GetName());


            jane.SetScore1(100);
            jane.SetScore2(50);
            Console.WriteLine("Jane's average score is {0}", jane.GetAverageScore());

            jane.SetScore2(90);
            Console.WriteLine("Jane's new average score is {0}", jane.GetAverageScore());

            Console.WriteLine("Jane's High score is {0}", jane.GetHighScore());
            jane.SetScore2(110);
            Console.WriteLine("Jane's new high score is {0}", jane.GetHighScore());




        }
    }
}
