﻿Console.WriteLine("Введите количество слов");
int n = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[n];
for (int i = 0; i < n; i++)
{   
    string S = Console.ReadLine();
    Array[i] = S;
}
Console.WriteLine( "[" + string.Join(",",Array)+"]" );
