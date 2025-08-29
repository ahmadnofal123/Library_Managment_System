using Library_Managment_System;

Book b1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");  
Book b2 = new Book("To Kill a Mockingbird", "Harper Lee");
StudentMember s1 = new StudentMember("Ahmad ", 101);
TeacherMember t1 = new TeacherMember("Dr. Ali ", 201);

s1.BorrowBook(b1);
t1.BorrowBook(b2);
Console.WriteLine();

int StudentLateDays = 3;
int TeacherLateDays = 5;

s1.ReturnBook(b1);  
Console.WriteLine($"Late fee for {StudentLateDays} days: {s1.CalculateFee(StudentLateDays)}");
t1.ReturnBook(b2);
Console.WriteLine($"Late fee for {TeacherLateDays} days: {t1.CalculateFee(TeacherLateDays)}");  
