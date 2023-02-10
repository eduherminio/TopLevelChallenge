public record struct Person(string FirstName, string LastName)
{
    public override string ToString() => $"{FirstName} {LastName}";
}