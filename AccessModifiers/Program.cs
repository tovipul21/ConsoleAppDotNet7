using AccessModifierLibrary;
using AccessModifiersUI;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Start instantiate from the UI console (InheritanceWithinAccessDemoClass)");
            Console.WriteLine("-----------------------------------------------------------------------");

            InheritanceWithinAccessDemoClass withinAccessDemoClass = new();
            withinAccessDemoClass.CallingMethodWithinAccessLibrary();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("End instantiate from the UI console (InheritanceWithinAccessDemoClass)");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Start instantiate from the UI console (InheritanceOutsideAccessLibrary)");
            Console.WriteLine("---------------------------------------------------------------------");

            InheritanceOutsideAccessLibrary inheritanceOutsideAccessLibrary = new();
            inheritanceOutsideAccessLibrary.CallingMethodOutsideAccessLibrary();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("End instantiate from the UI console (InheritanceOutsideAccessLibrary)");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
