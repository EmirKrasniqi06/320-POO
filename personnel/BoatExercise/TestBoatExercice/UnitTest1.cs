using BoatExercise;
namespace TestBoatExercice
{
    [TestClass]
    public class UnitTest1
    {
        private Boat boat;

        [TestInitialize]
        public void Setup()
        {
            // Initialiser les objets nécessaires pour les tests
            boat = new Boat(2024, 30, "Switzerland");
        }
        [TestMethod]
        public void TestLoad_WhenContainerWeightIsLighterThanDifferenceBetweenTonnageAndBoatLoad_AddOnTheBoat()
        {
            // Arrange
            Container container = new Container(1324, 4); // id = 1324, poids = 4 tonnes

            // Act
            boat.Load(container);

            // Assert
            Assert.AreEqual(1, boat.containers.Count);
            Assert.AreEqual(4, boat.totalWeight);
        }
        [TestMethod]
        public void TestLoad_WhenContainerWeightIsHeavierThanTonnage_DontAddOnTheBoat()
        {
            // Arrange
            Container container = new Container(3428,15); // id = 3428, poids = 15 tonnes
            boat.totalWeight = 16;

            // Act
            boat.Load(container);

            // Assert
            Assert.AreEqual(0, boat.containers.Count);
            Assert.AreEqual(16, boat.totalWeight);
        }
        [TestMethod]
        public void TestUnload_WhenContainerIsLoadedInTheBoat_RemoveContainer()
        {
            // Arrange
            Container container = new Container(6342, 20); // id = 6342, poids = 20 tonnes
            boat.Load(container);

            // Act
            boat.Unload(6342);

            // Assert
            Assert.AreEqual(0, boat.containers.Count);
            Assert.AreEqual(0, boat.totalWeight);
        }
        [TestMethod]
        public void TestUnload_WhenContainerIsNotLoaded_NothingChanges()
        {
            // Arrange
            Container container = new Container(9302, 29); // id = 9302, poids = 29 tonnes
            boat.Load(container);

            // Act
            boat.Unload(3821);

            // Assert
            Assert.AreEqual(1, boat.containers.Count);
            Assert.AreEqual(29, boat.totalWeight);
        }
    }
}