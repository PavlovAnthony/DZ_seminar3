int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void  PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

 string LineNum(int n, int P)
{
    string outline = "1";
    for (int i=2; i<=n; i++ )
{
    outline = outline+ " | " + Math.Pow(i,P);

}
    return outline;
}

int n = ReadData("Введите целое число ");

string linetop = LineNum(n,1);
string linedown = LineNum(n,3);

PrintData(" ", linetop);
PrintData(" ", linedown);
