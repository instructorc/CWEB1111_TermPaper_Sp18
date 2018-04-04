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
            string name, subject, letterGrade;

            TermPaper aPaper = new TermPaper();
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            aPaper.setAuthorsName(name);


        }
    }

    class TermPaper
    {
        private string authorsName;
        private string subject;
        private string letterGrade;


        //public TermPaper(string authorsName, string subject, string letterGrade)
        //{
        //    this.authorsName = authorsName;
        //    this.subject = subject;
        //    this.letterGrade = letterGrade;

        //}

        /**Setter methods**/
        public void setAuthorsName(string name)
        {
            authorsName = name;
        }
       
        public void setSubject(string sub)
        {
            subject = sub;
        }
        public void setLetterGrade(string grade)
        {
            letterGrade = grade;
        }

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
    }
}
