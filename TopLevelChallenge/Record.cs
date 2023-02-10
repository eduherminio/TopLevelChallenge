namespace TopLevelChallenge;

public record struct Message(string Part1, string Part2)
{
    public override string ToString() => $"{Part1} {Part2}";
}