int number = GetNumber("Введите пятизначное число");

int GetNumber(string msg)
{
    int result;

    while (true)
    {
        Console.WriteLine(msg);

        if (int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 99999)
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число! Повторите ввод. \n");
        }
    }

    return result;
}
int a1 = number % 10;
int a2 = (number/10) % 10;
int a4 = (number/1000) % 10;
int a5 = (number/10000) % 10;
if (a1 == a5 && a2 == a4)
{
    Console.WriteLine ("Число является палиндромом"); 
}
else
{
    Console.WriteLine ("Число не является палиндромом"); 
}
