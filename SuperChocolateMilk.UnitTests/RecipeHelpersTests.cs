using SuperChocolateMilk.Core;

namespace SuperChocolateMilk.UnitTests;



public class RecipeHelpersTests
{
    [Fact]
    public void TestCombineVolumes()
    {
        // Arrange
        int volumeA = 5;
        int volumeB = 5;
        
        // Act
        int result = RecipeHelpers.CombineVolumes(volumeA, volumeB);
        
        // Assert
        Assert.Equal(10, result);
    }

    
    [Theory]
    [InlineData(1, 1000)]
    [InlineData(5, 5000)]
    [InlineData(0, 0)]
    public void TestLitersToMilliliters(int liters, int expectedMilli)
    {
        // Act
        int result = RecipeHelpers.LitersToMilliliteres(liters);
        
        // Assert
        Assert.Equal(expectedMilli, result);
    }

    
    [Fact]
    public void TestCalculateMilkWeightGrams()
    {
        // Arrange
        int volume = 10;

        // Act
        double result = RecipeHelpers.CalculateMilkWeightGrams(volume);

        // Assert
        Assert.Equal(10.3, result);
    }

    
    [Theory]
    [InlineData(-3, false)]
    [InlineData(0, false)]
    [InlineData(1, true)]
    [InlineData(10, true)]
    public void TestIsValidBatchSize(int batchSize, bool expectedBool)
    {
        // Act
        bool result = RecipeHelpers.IsValidBatchSize(batchSize);
        
        // Assert
        Assert.Equal(expectedBool, result);
    }


    [Theory]
    [InlineData(1, "hi", "Tank-1: hi")]
    [InlineData(2, "hello", "Tank-2: hello")]
    [InlineData(3, "greetings", "Tank-3: greetings")]
    public void TestFormatTankLabel(int tankId, string contents, string expectedResult)
    {
        // Act
        string result = RecipeHelpers.FormatTankLabel(tankId, contents);
        
        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1000, 4)]
    [InlineData(2500, 10)]
    [InlineData(5000, 20)]
    public void TestCalculateRequiredBottles(int totalVolumeMl, int expectedReqBottles)
    {
        // Act
        int result = RecipeHelpers.CalculateRequiredBottles(totalVolumeMl);

        // Assert
        Assert.Equal(expectedReqBottles, result);
    }
}