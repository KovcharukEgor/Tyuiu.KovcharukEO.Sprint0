using Tyuiu.KovcharukEO.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KovcharukEO.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(number);
            Assert.AreEqual(15, res);
        }

        [TestMethod]

        public void CheckSubstractionArrayValid()
        {
            var nambers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtrationArray(nambers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]

        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

    }


}