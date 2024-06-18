namespace AccessModifierLibrary
{
    public class InheritanceWithinAccessDemoClass : AccessDemo
    {
        public void CallingMethodWithinAccessLibrary()
        {
            //AccessDemo accessDemo = new();
            //accessDemo.InternalDemo();

            PublicDemo();
            InternalDemo();
            ProtectedDemo();
            ProtectedInternalDemo();
            PrivateProtectedDemo();
        }
    }
}
