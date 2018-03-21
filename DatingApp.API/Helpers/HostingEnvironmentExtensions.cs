using Microsoft.AspNetCore.Hosting;

namespace DatingApp.API.Helpers
{
    public static class HostingEnvironmentExtensions
    {
        public const string QAEnvironment = "QA";
        public const string UATEnvironment = "UAT";
        public const string TestEnvironment = "Test";

        public static bool IsQA(this IHostingEnvironment hostingEnvironment)
        {
            return hostingEnvironment.IsEnvironment(QAEnvironment);
        }

        public static bool IsUAT(this IHostingEnvironment hostingEnvironment)
        {
            return hostingEnvironment.IsEnvironment(UATEnvironment);
        }

        public static bool IsTest(this IHostingEnvironment hostingEnvironment)
        {
            return hostingEnvironment.IsEnvironment(TestEnvironment);
        }
    }
}