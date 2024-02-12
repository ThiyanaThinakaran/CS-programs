using System;
using System.Data;

namespace Question
{
    internal class StringProgramOne
 {
 public static void ConCatenate()
 {
 String firstString = "Hello";
 char[] data = { 'H', 'E', 'L', 'L', 'O' };
 String secondString = new string(data);
 Console.WriteLine(firstString + " " + secondString);
 String thirdString = String.Empty;
 int x = 0;
 }

 public static void Length()
 {
 String s1 = "Tom And Jerry Are friends";

 Console.WriteLine("Length " + s1.Length);
 Char[] data = s1.ToCharArray();
 foreach (char c in data)
 {
 Console.WriteLine(c);
 }
 }

 public static void Wordcount()
 {
 String s1 = "Tom And Jerry Are friends";
 String[] words = s1.Split(' ');
 Console.WriteLine("Wordcount " + words.Count());

 foreach (var i in words)
 {
 Console.WriteLine(i);
 }
 }

 public static void UpperLower()
 {
 String firstString = "Tom and Jerry are Friends";
 String stringInUPPER = firstString.ToUpper();
 Console.WriteLine( "firstString:" + firstString);
 Console.WriteLine("stringInUPPER:"+ stringInUPPER);
 String stringInLower = firstString.ToLower();
 Console.WriteLine("firstString:" + firstString);
 Console.WriteLine("stringInLower:" + stringInLower);
 }
 
}
}





