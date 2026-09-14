namespace SuperChocolateMilk.UnitTests;

using Xunit;
using SuperChocolateMilk.Core;

public class MilkRecipeCalculatorTests
{
    [Fact]
    public void CalculateChocolateSyrup_RegularRichness_ReturnsTenPercentRatio()
    {
        // Arrange: Set up the inputs and expected conditions
        int milkVolume = 1000;
        string richness = "REGULAR";
        
        // Act: Call the method we are testing
        decimal result = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        
        // Assert: Check if the actual result matches our expected output
        Assert.Equal(100m, result);
    }

    [Theory]
    [InlineData(1000, "LIGHT", 75)]
    [InlineData(1000, "EXTRA", 150)]
    [InlineData(1000, "ULTRA_CHOCO", 200)]
    [InlineData(0, "REGULAR", 0)]
    public void calculateChocolateSyrup_VariousScenarios_ReturnsExpectedAmount(
        int milkVolume, string richness, decimal expectedSyrup)
    {
        // Act: Execute using the parameters passed from [InlineData]
        decimal actualResult = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        
        // Assert: Verify actual matches expected for each row
        Assert.Equal(expectedSyrup, actualResult);
    }
}