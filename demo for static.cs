using System;

namespace Question
{
internal class DemoA
 {
 int x = 12;
 static int y = 13;
 public static void FirstMethod()
 {
 //local variables
 //Console.WriteLine(x);non static memeber cannot be accessed
 int y = 5000;
 Console.WriteLine(y);//local variable
 Console.WriteLine( DemoA.y);//global static variable
 }
 public void SecondMethod()//non static method
 {
 //local variables
 Console.WriteLine(x);//non static memeber can be accessed
 int y = 5000;
 Console.WriteLine(y);//local variable
 Console.WriteLine(DemoA.y);//global static variable
 }
 }


}
