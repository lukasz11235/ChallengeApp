var myName1 = "Ewa";
var myAge1 = 17;
bool female = false;
if (myName1 == "Ewa" && myAge1 == 33)
{
    Console.WriteLine("Ewa,lat 33");
}
else if (myAge1 < 30 && female)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (!female && myAge1<18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}