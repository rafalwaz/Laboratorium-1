
// main

//wywoałnie metody statycznej
//Zadanie1();

using System.ComponentModel.Design;

consoleWriteLine();



// =============== koniec main ========================



//def metod 
static void Zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();
    double delta, x1, x2;

    if (a == 0) Console.WriteLine("To nie jest rownanie kwadratowe");
    else
    {
        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (delta < 0) Console.WriteLine("brak rozwiazania " +
            "w zb. liczb rzeczywistych");
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("x1 = " + x1);
        }
        else
        {
            x1 = -b - Math.Sqrt(delta) / (2 * a);
            x2 = -b + Math.Sqrt(delta) / (2 * a);
            Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
        }
    }

}

//metoda do wycztywania danych z klawiatury 

static double DoubleInput()
{
    Console.WriteLine("Podaj wrtosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

static void consoleWriteLine()
{

    //I sposob z plusem
    int a = 2;
    Console.WriteLine("Wartosc a = " + a);

    //II sposob na wąsacza
    Console.WriteLine("Wartosc a = {0}", a);

    //III sposob poprzez interpolacje
    Console.WriteLine($"Wartosc a = {a}");


}

static void Zadanie2()
{
    Menu();
}

static void Menu()
{
ViewMenu:
    Console.WriteLine("========== Kalkulator =================");
    Console.WriteLine("========== 1. Suma =================");
    Console.WriteLine("========== 2. Roznica =================");
    Console.WriteLine("========== 3. Iloczyn =================");
    Console.WriteLine("========== 4. Iloraz =================");
    Console.WriteLine("========== 5. Potegowanie =================");
    Console.WriteLine("========== 6. Pierwisatek z liczby =================");
    Console.WriteLine("========== 7. Funkcje trygonometryczne zadanego kata =================");
    Console.WriteLine("========== 8. Wyjscie =================");
    Console.WriteLine("Twoj wybor: ");
    int choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1: Total(); break;
        case 2: Difference(); break;
        case 3: ProductNumber(); break;
        case 4: QuotienNumber(); break;
        case 5: PotentiationNumber(); break;
        case 6: SquareNumber(); break;
        case 7: Trigonometry(); break;
        case 8: Close(); break;
        default:
            Console.WriteLine("Bledy wybor, sprobuj ponowanie: ");
            goto ViewMenu;
            break;
    }
}



