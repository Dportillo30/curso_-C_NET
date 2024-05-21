using System.Collections;

List<int> list = new List<int>();
for(int i = 1; i <= 1000; i++)
{
    list.Add(i);
}

int suma  = 0;

for(int i = 0; i < list.Count; i++)
{
    suma+= list[i];
    Console.WriteLine(suma);
}