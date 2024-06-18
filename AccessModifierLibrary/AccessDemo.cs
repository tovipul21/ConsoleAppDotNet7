namespace AccessModifierLibrary
{
    public class AccessDemo
    {
        private void Demo() => PrivateDemo();

        public void PublicDemo()
        {
            PrivateDemo();
            Console.WriteLine("This is Public demo method");
        }

        private void PrivateDemo() => Console.WriteLine("This is Private method");

        protected void ProtectedDemo() => Console.WriteLine("This is Protected demo");

        internal void InternalDemo() => Console.WriteLine("This is Internal method");

        private protected void PrivateProtectedDemo() => Console.WriteLine("This is Private Protected method");

        protected internal void ProtectedInternalDemo()
        {
            ProtectedDemo();
            Console.WriteLine("This is Proteted Internal demo");
        }
    }
}
