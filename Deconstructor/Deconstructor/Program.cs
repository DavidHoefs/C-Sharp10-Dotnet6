


// Tuple
var person = (FirstName: "David", LastName: "Hoefs");
// Deconstruct Tuple
//(string firstName, string lastName) = person;



//// Another way to deconstuct
//string fn;
//string ln;
//(fn, ln) = person;


string firstName;
(firstName, string lastName) = person;
Console.WriteLine(firstName);
Console.WriteLine(lastName);