using ArraysMethods.Classes;

namespace ArraysMethods.Tests
{
    public class ArrayMethodsTests
    {
        [Fact]
        public void GetMax_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods.GetMax(arr);
            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void GetMax_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20 };
            //Act
            var result = ArrayMethods.GetMax(arr);
            //Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void GetMaxIndex_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods.GetMaxIndex(arr);
            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetMaxIndex_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20 };
            //Act
            var result = ArrayMethods.GetMaxIndex(arr);
            //Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void GetMin_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods.GetMin(arr);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetMin_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20 };
            //Act
            var result = ArrayMethods.GetMin(arr);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetMinIndex_ShouldReturnValidValue_ExampleArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3 };
            //Act
            var result = ArrayMethods.GetMinIndex(arr);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetMinIndex_ShouldReturnValidValue_RandomArray()
        {
            //Arrange
            var arr = new int[] { 15, 8, 6, 9, 13, 7, 14, 5, 100, 17, 12, 2, 4, 10, 11, 20, 1, 16, 18, 1, 20 };
            //Act
            var result = ArrayMethods.GetMinIndex(arr);
            //Assert
            Assert.Equal(16, result);
        }
    }
}