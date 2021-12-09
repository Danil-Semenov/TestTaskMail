using NLog;
using NUnit.Framework;
using TestTaskMail.Forms;
using TestTaskMail.Utils;

namespace TestTaskMail
{
    public class Tests
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        [SetUp]
        public void Setup()
        {
            Logger.Info("Run setup for the test");
            DriverUtil.OpenUrl(Config.Host);
        }

        [Test]
        [TestCaseSource(typeof(TestData), nameof(TestData.GetTestCaseData))]
        public void Test1(string login,string password,string recipient)
        {
            var a = new LoginPage();
            a.Login(login, password);
            var b = 
            Assert.Pass();
        }
    }
}