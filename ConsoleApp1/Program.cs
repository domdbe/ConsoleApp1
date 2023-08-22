var myName = "Dominik";
var myGender = "Male";
var myAge = 26;

if (myGender == "Female" && myAge > 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (myGender == "Female" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (myGender == "Male" && myAge < 18)
{
    Console.WriteLine("NIepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Jestem Dominik, mam 26 lat");
}