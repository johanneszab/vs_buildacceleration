using System.Reflection;
using System.Runtime.Versioning;

namespace ClassLibrary2
{
    public class Class2
    {
        private readonly Random rand = new Random();

        public string TestMethod()
        {
            var testString = String.Empty;

            for (int i = 0; i < 10; i++)
            {
                testString += rand.Next().ToString();
            }

            return GetPlatformTarget();
        }

        private string GetPlatformTarget()
        {
            var tar = (TargetFrameworkAttribute)Assembly
                .LoadFrom(nameof(ClassLibrary2) + ".dll")
                .GetCustomAttributes(typeof(TargetFrameworkAttribute)).First();
            return $"{nameof(ClassLibrary2)}: {tar.FrameworkDisplayName}";
        }
    }
}
