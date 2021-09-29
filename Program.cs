using DisposableObjectsForSummerSchool.Models;
using System;

// public interface IDisposable
// {
//     void Dispose();
// }
namespace DisposableObjectsForSummerSchool
{
    class Program
    {
        static void Main()
        {
            // Create a disposable object and call Dispose()
            // to free any internal resources.
            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose();

            // It is a good idea to call Dispose() on any object you directly create
            // if the object supports IDisposable. The assumption you should make is that
            // if the class designer chose to support the Dispose() method,
            // the type has some cleanup to perform.
            // If you forget, memory will eventually be cleaned up(so don’t panic),
            // but it could take longer than necessary.
            MyResourceWrapper rw2 = new MyResourceWrapper();
            if (rw2 is IDisposable)
            {
                rw2.Dispose();
            }

            // Reusing the C# using Keyword !
            // Dispose() is called automatically when the using scope exits.
            using (MyResourceWrapper rw3 = new MyResourceWrapper())
            {
                // Use rw3 object.
            }

            // If you attempt to “use” an object that does not implement IDisposable,
            // you will receive a compiler error.
            //using (MyResourceWrapper2 rw4 = new MyResourceWrapper2())
            //{
            //    // Use rw4 object.
            //}

            // Use a comma-delimited list to declare multiple objects to dispose.
            using (MyResourceWrapper rw5 = new MyResourceWrapper(), 
                rw6 = new MyResourceWrapper())
            {
                // Use rw5 and rw6 objects.
            }

            Console.WriteLine("Demonstrate using declarations");
            UsingDeclaration();

            Console.ReadLine();
        }

        // Using Declarations (New 8.0)
        // New in C# 8.0 is the addition of using declarations.
        // A using declaration is a variable declaration preceded by the using keyword.
        private static void UsingDeclaration()
        {
            //This variable will be in scope until the end of the method
            using var rw = new MyResourceWrapper();
            //Do something here
            Console.WriteLine("About to dispose.");
            //Variable is disposed at this point.
        }
    }
}