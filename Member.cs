using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    abstract class Member
    {
        protected string name;
        protected int memberId;

        public Member(string name, int memberId)
        {
            this.name = name;
            this.memberId = memberId;
        }   
        public void DisplayInfo()
        {
            Console.WriteLine("Member Name: " + name);
            Console.WriteLine("Member ID: " + memberId);
        }
        public abstract double CalculateFee(int dayLate);
        

    }
}
