
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

int n = 43;
int j = 0;
double sum = 0;




for (int m = 1;m < n; m++)
{
    if (m % 21 == 0)
    {
        Console.WriteLine(m);
        sum=sum+m;
        j++;
    }

}
double avg=sum/j;
Console.WriteLine(avg);
Console.WriteLine("====================================================");
// - Verilmiş ədədin rəqəmləri cəmini tapan proqram

Console.WriteLine("Bir eded daxil edin:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int cem = 0;
while (number > 0)
{
    int lastDigit = number % 10;
    cem += lastDigit;
    number /= 10;
}

Console.WriteLine("Ededin reqemleri cemi: " + cem);
Console.WriteLine("====================================================");

/*- Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram*/

string s=Console.ReadLine();
int gun=Convert.ToInt32(s);

if(gun==12 || gun==1 || gun == 2)
{
    Console.WriteLine("qisdir!");
}

if (gun == 3 || gun == 4 || gun == 5)
{
    Console.WriteLine("yazdir!");
}

if (gun == 6 || gun == 7 || gun == 8)
{
    Console.WriteLine("yaydir!");
}

if (gun == 9 || gun == 10 || gun == 11)
{
    Console.WriteLine("payizdir!");

    
}
Console.WriteLine("====================================================");
//- Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.

//Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.



    static bool reqemfunksiyasi(string yazi)
    {
        for (int i = 0; i < yazi.Length; i++)
        {
            char simvol = yazi[i];

            if (simvol >= '0' && simvol <= '9')
            {
                return false;
            }
        }
        return true;
    }

while (true)
{
    string girielnyazi = Console.ReadLine();

    if (reqemfunksiyasi(girilenyazi))
    {
        Console.WriteLine("yazida reqem yoxudr bleeeeeeee");
        break;


    }
    else
    {
        Console.WriteLine("reqem var bleeeeee");
        Console.WriteLine("yeni yazi daxil edin:");
    }

}






    


