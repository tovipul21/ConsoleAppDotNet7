using AccessModifierLibrary;

namespace AccessModifiersUI
{
    public class InheritanceOutsideAccessLibrary : AccessDemo
    {
        public void CallingMethodOutsideAccessLibrary()
        {
            //AccessDemo accessDemo = new AccessDemo();
            //accessDemo.PublicDemo();

            PublicDemo();
            ProtectedInternalDemo();
        }
    }
}
