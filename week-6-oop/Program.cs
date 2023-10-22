using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using Program;
namespace Program
{
    class Grade
    {
        public string isGrade;

        public Grade(int ScoreCalculate)
        {
            if (ScoreCalculate >= 80)
            {
                isGrade = "A";
            }
            else if (ScoreCalculate >= 75)
            {
                isGrade = "B+";
            }
            else if (ScoreCalculate >= 70)
            {
                isGrade = "B";
            }
            else if (ScoreCalculate >= 65)
            {
                isGrade = "C+";
            }
            else if (ScoreCalculate >= 60)
            {
                isGrade = "C";
            }
            else if (ScoreCalculate >= 55)
            {
                isGrade = "D+";
            }
            else if (ScoreCalculate >= 50)
            {
                isGrade = "D";
            }
            else
            {
                isGrade = "E";
            }
        }
        static void Main(string[] args)
        {
            int CountRecords = 0;
            Console.WriteLine("How Many Records Input : ");
            CountRecords = Int32.Parse(Console.ReadLine());
            string[][] data = new string[CountRecords][];
            string StudentId, Prefix, FirstName, LastName, Score;
            for (int i = 0; i < CountRecords; i++)
            {
                Console.Write("Input StudentId : ");
                StudentId = Console.ReadLine();
                Console.Write("Input Prefix : ");
                Prefix = Console.ReadLine();
                Console.Write("Input FirstName : ");
                FirstName = Console.ReadLine();
                Console.Write("Input LastName : ");
                LastName = Console.ReadLine();
                Console.Write("Input Score : ");
                Score = Console.ReadLine();
                data[i] = new string[] { StudentId, Prefix, FirstName, LastName, Score };
                Console.WriteLine("================================================");
            }
            for (int x = 0; x < CountRecords; x++)
            {
                int ThisScore = Int32.Parse(data[x][4]);
                Grade getGrade = new Grade(ThisScore);
                Console.WriteLine("StudentId: {0} FullName: {1}{2} {3} Grade:{4}", data[x][0], data[x][1], data[x][2], data[x][3], getGrade.isGrade);
            }
        }
    }
}