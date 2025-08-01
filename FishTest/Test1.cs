using IndexICE;

namespace FishTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Fish fish = new Fish(20, 3, "Summer", "Shad");
            Assert.AreEqual(fish[3], "Shad");
        }

        [TestMethod]
        public void updateWeightTest()
        {
            Fish fish = new Fish(20, 3, "Summer", "Shad");
            fish[1] = 12; //int index
            Assert.AreEqual(fish[1], 12);
        }

        [TestMethod]
        public void testSpecies()
        {
            Fish fish = new Fish(20, 3, "Summer", "Shad");
            Assert.AreEqual(fish["fishSpecies"], "Shad");//string index
        }

        [TestMethod]
        public void updateSeason()
        {
            Fish fish = new Fish(6, 10, "Summer", "Shad");
            fish["Season"] = 7; //int index
            Assert.AreEqual(fish["Season"], 7);
        }
    }
}
