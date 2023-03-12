using ClassLibrary2;
using System.Reflection;
using System.Runtime.Versioning;

namespace ClassLibrary1
{
    public class Class1
    {
        private readonly Random rand = new Random();

        public string TestMethod()
        {
            var testString = String.Empty;

            for (int i = 0; i < 10; i++)
            {
                testString += rand.Next().ToString();
            }

            var class2 = new Class2();
            testString += class2.TestMethod();

            return GetPlatformTarget();
        }

        private string GetPlatformTarget()
        {
            var tar = (TargetFrameworkAttribute)Assembly
                .LoadFrom(nameof(ClassLibrary1) + ".dll")
                .GetCustomAttributes(typeof(TargetFrameworkAttribute)).First();
            return $"{nameof(ClassLibrary1)}: {tar.FrameworkDisplayName}";
        }
    }
}