Console.WriteLine("Введите количество слов");
int n = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[n];
for (int i = 0; i < n; i++)
{   
    string str = Console.ReadLine();
    Array[i] = str;
}
Console.WriteLine( "[" + string.Join(",",Array)+"]" );