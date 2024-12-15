using FluentAssertions;

namespace MutationTestingStrykerCSharp.UnitTests;

public class ElfCalculatorTests
{
    private readonly ElfCalculator _calculator = new(); 
        
    [Fact]
    public void AddElves_Adds_Correctly()
    {
        var result = _calculator.AddElves(1, 0);
        result.Should().Be(1);
    }
    
    [Fact]
    public void LastElfIsEven_Returns_True_When_Last_Elf_Is_Even()
    {
        var result = _calculator.LastElfIsEven(new List<int> { 2 });
        result.Should().BeTrue();
    }
    
    [Fact]
    public void When_Strings_Are_Numbers_Then_AddStringyElves_Adds_Correctly()
    {
        var result = _calculator.AddStringyElves("1", "1");
        result.Should().Be(2);
    }
    
    [Fact]
    public void When_Either_String_Is_Empty_Then_AddStringyElves_Throws_ArgumentException()
    {
        var action = () => _calculator.AddStringyElves("", "");
        action.Should().Throw<ArgumentException>().WithMessage("Elves cannot be null or empty");
    }
}