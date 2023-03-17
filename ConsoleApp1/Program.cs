//poporos uzytkownika o podanie imienia
Console.WriteLine("Podaj swoje imię: ");
//deklarujemy nowa zmienna typu tekstowego o nazwie "name"
string name = "";
//odczytamy od uzytkownika i zapiszemy do zmiennej imie - zapisz nieznajomy jesli uzytkowink nie udzieli odpowiedzi
name = Console.ReadLine() ?? "Nieznajomy";
//nowa zmienna - powitanie
string greeting = "Witaj " + name +"!";
//wpisz gotowe powitanie
Console.WriteLine(greeting);
