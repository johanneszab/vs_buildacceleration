using System.Reflection;
using System.Runtime.Versioning;

namespace ClassLibrary3
{
    public class Class3
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
                .LoadFrom(nameof(ClassLibrary3) + ".dll")
                .GetCustomAttributes(typeof(TargetFrameworkAttribute)).First();
            return $"{nameof(ClassLibrary3)}: {tar.FrameworkDisplayName}";
        }

    }
}