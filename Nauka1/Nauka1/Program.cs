// Deklaracje zmiennych
    string Name = "Ewa";
    int Wiek = 33;
    bool Kobieta = true;

    if (Kobieta == true && Wiek < 30)
    {
    Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if ( Kobieta == true && Wiek == 33 )
    {
    Console.WriteLine(Name + ", lat " + Wiek);
    }
    else if ( Kobieta == false && Wiek < 18)
    {
    Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
    Console.WriteLine("Podano zmienne spoza zakresu");
    };
    
 