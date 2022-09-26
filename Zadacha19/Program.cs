string ReadData(string line)
{

    Console.Write(line);
    string number = Console.ReadLine();
    CheckNumber(number);
    return number;
}

void CheckNumber(string x)
{
     double num = 0;
     
        bool isNum = double.TryParse(x, out num);
        if (isNum == false || num<10000 || num>99999 )
        {
            PrintData("Ошибка ввода: ", "значение Null, введено не число, либо оно не 5-ти значное");
            Environment.Exit(0);
        }
 
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

// Инициализация словаря с палиндромами
Dictionary<string, string> dict = new Dictionary<string, string>();
for (int i = 10000; i <= 99999; i++)
{
    string palindrom = i.ToString();

    if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
    {
        dict.Add(palindrom, "Палиндром");
    }

}

string number = ReadData("ВВедите 5-ти значное число: ");
//проверка на наличие числа в словаре
bool flag = false;

foreach (var num in dict)
{
if (number == num.Key)
{   PrintData("Число "  + number ,  " - Палиндром" );
flag = true;
}
     
}

if (flag==false)
   PrintData("Число "  + number , " - Не палиндром" );