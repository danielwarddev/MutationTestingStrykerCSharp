/*
 * This class is the original test class, but with implemented fixes discussed in the blog post after running Stryker.
 * This file is commented out so that you can clone this repo and run dotnet stryker to see the failing mutation results if you like.
 */

/*using FluentAssertions;

namespace MutationTestingStrykerCSharp.UnitTests;

public class ElfCalculatorTests_AfterStryker
{
    private readonly ElfCalculator _calculator = new(); 
        
    [Fact]
    public void AddElves_Adds_Correctly()
    {
        var result = _calculator.AddElves(3, 4);
        result.Should().Be(7);
    }
    
    [Fact]
    public void LastElfIsEven_Returns_True_When_Last_Elf_Is_Even()
    {
        var result = _calculator.LastElfIsEven(new List<int> { 1, 2 });
        result.Should().BeTrue();
    }
    
    [Fact]
    public void When_Strings_Are_Numbers_Then_AddStringyElves_Adds_Correctly()
    {
        var result = _calculator.AddStringyElves("3", "4");
        result.Should().Be(7);
    }
    
    [Theory]
    [InlineData("1", "")]
    [InlineData("", "1")]
    [InlineData("", "")]
    // Something to note here is that Stryker didn't catch that we're not testing the null cases
    public void When_Either_String_Is_Empty_Then_AddStringyElves_Throws_ArgumentException(string elf1, string elf2)
    {
        var action = () => _calculator.AddStringyElves(elf1, elf2);
        action.Should().Throw<ArgumentException>().WithMessage("Elves cannot be null or empty");
    }
}*/