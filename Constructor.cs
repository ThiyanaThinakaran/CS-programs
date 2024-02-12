using System;

namespace Question
{
    internal class Book
 {
 public Book() {
 Console.WriteLine( "Book Constructor");
 }
 public virtual void OpenBook()
 {
 Console.WriteLine("EBook Open");
 }
 }
 internal class EBook : Book
 {
 public EBook()
 {
 Console.WriteLine("EBook Constructor");
 }
 public override void OpenBook()
 {
 Console.WriteLine( "EBook Open");
 }
 }
 class BookTester
 {
 public static void TestOne()
 {
 Book book = new EBook();
 book.OpenBook();
 }
 }
}
