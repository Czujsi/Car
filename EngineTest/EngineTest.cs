namespace EngineTest
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void Car_must_have_engine()
        {
            var engine = new Engine("Diesel");

            Assert.AreEqual("Diesel", engine.Type);
        }
    }
}