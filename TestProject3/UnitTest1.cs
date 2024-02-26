using jenkinstwo;
namespace TestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Jtest1()
        {
            jenkinsbuild test = new jenkinsbuild();
            string result = test.Stayin(2);
            Assert.AreEqual("jenkinsbuildjenkinsbuild", result);
        }

        [Test]
        public void Jtest2()
        {
            jenkinsbuild test = new jenkinsbuild();
            string result = test.Stayin(1);
            Assert.AreEqual("jenkinsbuild", result);
        }
    }
}