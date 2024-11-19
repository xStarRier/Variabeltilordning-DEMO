// See https://aka.ms/new-console-template for more information
int num = 7;

float decimalNum = 1.28f;
double decimalNum2 = 1.28;
decimal decimalNum3 = 1.28M;

char letter = 's';
string text = "hello :)";

bool trueFalse = true;
int[] numArray = { 1, 2, 3 };
string[] textArray = { "Hel", "lo", "!:)" };

List<int> numList = new List<int>(); //lager ny liste med tall

public string ReturnString()
{
    return text;

}

public int ReturnWholeNumber()
{
    return num;

}

public double ReturnDouble()
{
    return 1.288;

}

public bool TrueOrFalse()
{
    return trueFalse;

}

}
public void Run()
{
    Console.WriteLine($"Dette er en tekst: {ReturnString()}");
    Console.WriteLine($"Dette er int: {ReturnWholeNumber()}");
    Console.WriteLine($"Dette er en double: {ReturnDouble()}");
    Console.WriteLine($"Dette er en boolean: {TrueOrFalse()}");
}