var myName1 = "Ewa";
var myAge1 = 33;
bool female = true;
if (myName1 == "Ewa" && myAge1 == 33)
{
    Console.WriteLine("Ewa,lat 33");
}
else if (myAge1 < 30 && female)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}