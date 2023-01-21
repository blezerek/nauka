// Deklaracje zmiennych
    string name = "Ewa";
    int age = 33;
    bool female = true;

//Kod Programu

    if (female == true && age < 30)
    {
    Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if ( female == true && age == 33 )
    {
    Console.WriteLine(name + ", lat " + age);
    }
    else if ( female == false && age < 18)
    {
    Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
    Console.WriteLine("Podano zmienne spoza zakresu");
    };
    
 