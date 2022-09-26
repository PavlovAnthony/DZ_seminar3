string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    CheckString(a);
    return a;
}

void CheckString(string x)
{

    if (string.IsNullOrWhiteSpace(x))
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }

}
void CheckNumber(string x)
{
    double num = 0;

    bool isNum = double.TryParse(x, out num);
    if (isNum == false)
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }

}
double[] ParseData(string s)
{
    char[] separators = { '/', '\\', ' ', '|' };
    string[] split = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i <= split.Length - 1; i++)
        CheckNumber(split[i]);

    double[] array1 = new double[] { Convert.ToDouble(split[0]), Convert.ToDouble(split[1]), Convert.ToDouble(split[2]) };
    return array1;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

double FindLen(double[] a, double[] b)
{

    return Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + +Math.Pow(a[2] - b[2], 2)), 3);
}

string coord1 = ReadData("Введите через пробел координаты первой точки: ");
double[] a = ParseData(coord1);
string coord2 = ReadData("Введите через пробел координаты второй точки: ");
double[] b = ParseData(coord2);
double result = FindLen(a, b);
PrintData("Расcтояние между точками: ", result.ToString());

