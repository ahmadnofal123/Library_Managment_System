using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class TeacherMember: Member, IsBorrowable
    {
        public TeacherMember(string name, int memberId) : base(name, memberId)
        {
        }

        public void BorrowBook(Book book)
        {
            Console.WriteLine($"{name} Borrowed the book: {book.GetTitle}");
        }

        public void ReturnBook(Book book)
        {
            Console.WriteLine($"{name} Borrowed the book: {book.GetTitle}");
        }
        public override double CalculateFee(int dayLate)
        {
            return dayLate *0.2;
        }
    }
    
   
}
