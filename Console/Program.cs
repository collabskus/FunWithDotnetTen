using ClassLibrary;
Console.WriteLine("Please enter the first name");
string? firstName = Console.ReadLine();
while (string.IsNullOrWhiteSpace(firstName))
{
    // ask again 
    Console.WriteLine("Please enter the first name");
    firstName = Console.ReadLine();
}
Console.WriteLine("Please enter the last name");
string? lastName = Console.ReadLine();
while (string.IsNullOrWhiteSpace(lastName))
{
    // ask again 
    Console.WriteLine("Please enter the last name");
    lastName = Console.ReadLine();
}
Person person = new(firstName, lastName);
Console.WriteLine($"Hello, {person.GetLegalName()}!");
