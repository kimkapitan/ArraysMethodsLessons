using ArraysMethods.Classes;

namespace ArraysMethods.Tests
{
    public class ArrayMethodsTests1
    {
        [Fact]
        public void GetSum_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods1.GetSum(arr);
            //Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetSum_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20, 0 };
            //Act
            var result = ArrayMethods1.GetSum(arr);
            //Assert
            Assert.Equal(309, result);
        }

        [Fact]
        public void GetAvg_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods1.GetAvg(arr);
            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetAvg_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20, 0 };
            //Act
            var result = ArrayMethods1.GetAvg(arr);
            //Assert
            Assert.Equal(14.05, result);
        }

        [Fact]
        public void GetMedian_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods1.GetMedian(arr);
            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetMedian_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20, 0 };
            //Act
            var result = ArrayMethods1.GetMedian(arr);
            //Assert
            Assert.Equal(10.5, result);
        }
    }
}
