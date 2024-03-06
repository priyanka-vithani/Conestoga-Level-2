using System;

namespace TriangleSolver
{
    public class TriangleSolver
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            string returnedString = myObject.GetString();
        }

        public static string data()
        {
            MyClass myObject = new MyClass();
            string returnedString = myObject.GetString();
            return returnedString;
        }
    }
}

class MyClass
{
    public string GetString()
    {
        // You can generate the string however you want.
        string myString = "Hello, World!";

        return myString;
    }
}
