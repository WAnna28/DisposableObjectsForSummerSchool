using System;

namespace DisposableObjectsForSummerSchool.Models
{
    class MyResourceWrapper2
    {
        // The object user should call this method
        // when they finish with the object.
        public void Dispose()
        {
            // Clean up unmanaged resources...
            // Dispose other contained disposable objects...
            // Just for a test.
            Console.WriteLine("***** In Dispose! *****");
        }
    }
}
