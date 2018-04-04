using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termpaper_Sp18_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global variables
            string name, subject, letterGrade;
           
            TermPaper[] aPaper = new TermPaper[2];

            for (var x = 0; x < aPaper.Length; x++)
            {
                
                Console.WriteLine("Please enter the authors name:");
                name = Console.ReadLine();
                Console.WriteLine("Please enter the authors subject:");
                subject = Console.ReadLine();
                Console.WriteLine("Please enter a letter grade:");
                letterGrade = Console.ReadLine();

                aPaper[x] = new TermPaper(name, subject, letterGrade);


            }
            Console.WriteLine("");
            for(var x=0; x < aPaper.Length; x++)
            {
                Console.WriteLine(aPaper[x]);
            }
            Console.WriteLine("Program has concluded");
        }
    }

    class TermPaper
    {
        private string authorsName;
        private string subject;
        private string letterGrade;

        //Default Constructor
        public TermPaper()
        {

        }
        //Overloaded Constructor that takes in 3 parameters
        public TermPaper(string authorsName, string subject, string letterGrade)
        {
            this.authorsName = authorsName;
            this.subject = subject;
            this.letterGrade = letterGrade;

        }

        /**Setter methods**/
        //public void setAuthorsName(string name)
        //{
        //    authorsName = name;
        //}
       
        //public void setSubject(string sub)
        //{
        //    subject = sub;
        //}
        //public void setLetterGrade(string grade)
        //{
        //    letterGrade = grade;
        //}

        public string getAuthorsName()
        {
            return authorsName;
        }
        public string getSubject()
        {
            return subject;
        }
        public string getGrade()
        {
            return letterGrade;
        }
        public override string ToString()
        {
            return "The author: " + authorsName + " The subject: " + subject + " The grade: " + letterGrade;
        }
    }
}
