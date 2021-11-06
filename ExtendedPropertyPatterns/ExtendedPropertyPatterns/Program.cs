




using System.Diagnostics;

PersonModel p = new();
/// <summary>
/// Old way of doing it
/// </summary>
if (p is { FirstName: "David" , HomeAddress:{ City:"Lubbock"} })
{
    Console.WriteLine("Hello David");
}

/// <summary>
/// New way of doing it 
/// </summary>
if(p is { FirstName: "David", HomeAddress.City: "Lubbock" })
{
    
    Console.WriteLine("Hello David");
}




public class PersonModel
{
    
    public string FirstName { get; set; } = "David";

    public string LastName { get; set; } = "Hoefs";

    public AddressModel HomeAddress { get; set; } = new AddressModel();


}


public class AddressModel
{

    public string City { get; set; } = "Lubbock";
    public string State { get; set; } = "Texas";

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

