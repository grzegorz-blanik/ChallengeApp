string name = "Ewa";
bool female = true;
int age = 17;

if (female && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}