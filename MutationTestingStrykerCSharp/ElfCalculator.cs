namespace MutationTestingStrykerCSharp;

public class ElfCalculator
{
    public int AddElves(int elf1, int elf2)
    {
        return elf1 + elf2;
    }

    public bool LastElfIsEven(IEnumerable<int> elves)
    {
        return elves.Last() % 2 == 0;
    }

    public int AddStringyElves(string elf1, string elf2)
    {
        if (string.IsNullOrWhiteSpace(elf1) || string.IsNullOrWhiteSpace(elf2))
        {
            throw new ArgumentException("Elves cannot be null or empty");
        }
        
        return int.Parse(elf1) + int.Parse(elf2);
    }
}