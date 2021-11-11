using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string token = "1866937452:AAFGY576vVGjXA_e3lAjsvzueLeaN09EVJw";

            var client = new TelegramBotClient(token);

            var bot = client.GetMe();

            Assert.IsNotNull(bot);

            Assert.AreEqual(bot, bot);
        }
    }
}
