string myCompany = "David's Company";
const string companyName = "Acme";
const string productName = $"{companyName} Anvils";
const string productDescription = $"{productName} are the best way to crush unsuspecting roadrunners";

Console.WriteLine(productDescription);

[Obsolete($"This is no longer used for {productName}")]
void SayHi()
{
    
}