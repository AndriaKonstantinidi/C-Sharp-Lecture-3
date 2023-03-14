// See https://aka.ms/new-console-template for more information
//int i = 0;

//while(i < 10)
//{
//    i++;
//    if ((i%2)!=0)
//    {
//        Console.WriteLine(i);
//    }
//}




//for(int i = 1; i <= 10; i++)
//{
//    if((i%2) == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
var i = new int[50];

for(int j = 1; j < 50; j++)
{
    i[j] = j;
}
var count = 0;
foreach (var item in i)
{
    if ((item%2)!=0)
    {
        count++;
    }
    
}
Console.WriteLine(count);