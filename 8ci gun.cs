/*
    
   
    
 Yeni tapşırıqlar:

  - Verilmiş ədədin rəqəmləri cəmini tapan proqram
 - Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram
 - Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.
  - Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram. Misalçün consoledan 5,10 və + daxil edilsə 5 və 10-u toplayıb nəticəsini göstərsin.Console-dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

*/
/*- Verilmiş dəyər "salam"-dırsa "aleykum salam", "sag ol"-dursa "sen de sag ol" əks halda "Ya niznayuu poruski :( " yazdıran proqram*/
string a= Console.ReadLine();
if (a == "salam")
{
    Console.WriteLine("eleykime salam");
}
else if (a == "sagol")
{
    Console.WriteLine("xos getdin");
}
else
{
    Console.WriteLine("ya neznayu po ruskiy");
}

Console.WriteLine("===========================================================");
/*Verilmiş dəyərin həftənin hansı günü olduğunu tapan proqram*/
int b;
 

string x=Console.ReadLine();
b= Convert.ToInt32(x);

if (b == 1)
{
    Console.WriteLine("bazar ertesi");
}
else if( b == 2)
{
    Console.WriteLine("cersenbe axsami ");

}
else if(b == 3)
{
    Console.WriteLine("cersenbe");
}
else if (b == 4)
{
    Console.WriteLine("cume axsami");
}
else if (b == 5)
{
    Console.WriteLine("cume");
}
else if (b == 6)
{
    Console.WriteLine("senbe");
}
else if (b == 7)
{
    Console.WriteLine("bazar");
}

Console.WriteLine("====================================================");
/*Verilmiş dəyərin daxilində a hərfinin olub olmadığını tapan proqram*/

string name = "A";
bool varsa = false;


for(int i = 0; i < name.Length; i++)
{
    if (name[i] == 'a' || name[i]=='A')
    {
        Console.WriteLine("a herfi var");
        varsa = true;
        break;
    }
   
}

if (!varsa)
{
    Console.WriteLine("a yoxdur ");
}
Console.WriteLine("====================================================");
/* -Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan proqram*/
int m = 1;
int n = 43;
int j = 0;


while(m < n)
{
    j++;
}
Console.WriteLine(j);
