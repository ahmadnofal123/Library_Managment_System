﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal interface IsBorrowable
    {
        public void BorrowBook(Book book);
        public void ReturnBook(Book book);
    }
}
