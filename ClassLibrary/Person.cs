namespace ClassLibrary;

public class Person(string FirstName, string LastName)
{
    public string GetLegalName()
    {
        return $"{FirstName} {LastName}";
    }
}
