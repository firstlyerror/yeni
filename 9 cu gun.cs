/*Dərsdə etdiklərimizi tam şəkildə sərbəst edə bilənədək bir projjctdə yazırsınız və göndərirsiniz.

 
Daha sonra yeni tapşırıqların hamısını ayrı bir projectin içində yazıb eyni repoya yerləşdirirsiniz
Yeni tapşırıqlar:

 - 
 - 
- 
*/

/*-Verilmiş ədədin verilmiş qüvvətini tapan metod*/

using System.Collections.Concurrent;
using System.ComponentModel;

static void quvvet(int num1, int num2)
{
    int a = num1;
    int b = num2;
    Console.WriteLine(Math.Pow(a,b));

}
quvvet(2, 3);
Console.WriteLine("----------------------------------------");

/*-Verilmiş 3 ədəddən ən böyüyünü tapan metod*/

static int enboyuk(int num1, int num2,int num3)
{

    int max = 0;

    int[] ededler = { num1,num2, num3 };


    for (int i = 0; i < ededler.Length; i++)
    {
        if (ededler[i] > max)
        {
            max = ededler[i];
        }
    }
    return max;

}

Console.WriteLine(enboyuk(5,11,212));

Console.WriteLine("----------------------------------------");

/*-Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod*/

static void range(params int[] numbers)
{
    int cem = 0;
    for(int i=0; i<numbers.Length; i++)
    {
        cem += numbers[i];
    }
    Console.WriteLine(cem);
}

range(1, 2, 3, 4, 5, 7);
Console.WriteLine("----------------------------------------");

/*-Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
*/

static void Sum(params int[] salam)
{
    int max = 0;
    for(int i=0; i<salam.Length; i++)
    {
        if (salam[i] > max)
        {
            max = salam[i];
        }

    }
    Console.WriteLine(max);

}
Sum(1, 2, 3, 4, 5);

Console.WriteLine("----------------------------------------");

/*-Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod*/

static int akisi(params int[] salam)
{
    int max = salam[0];
    for(int i=0; i< salam.Length; i++)
    {
        if (salam[i] > max)
        {
            max = i;
        }
    }
    return max;

}

Console.WriteLine(akisi(112,23,4,565,32312));

Console.WriteLine("----------------------------------------");

/*Verilmiş yazılar siyahısındaki (string array)
 verilmiş yazının yerləşdiyi indexi qaytaran metod.
Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın*/

static void yazi(params string[] siyahi)
{
    bool deyisen=false;
    string a = Console.ReadLine();
    for (int i = 0; i < siyahi.Length; i++)
    {
        if (siyahi[i] == a)
        {
            Console.WriteLine(i);
            deyisen=true;
            break;
        }
        
    }

    if (!deyisen)
    {
        Console.WriteLine("-1");
    }
}
yazi("ilkin", "fuad", "asif", "elvin");

Console.WriteLine("----------------------------------------");

/*Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.Yəni metodu işə salın {4,-5,3,-2,6}
    ədədlərindən ibarət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır*/

static void musbet(params int[] musbetler)
{
    int[] sabah = {};
    for (int i = 0; i < musbetler.Length; i++)
    {
        if (musbetler[i] > 0)
        {
            Console.WriteLine(musbetler[i]);
        }
            
        }

    }
musbet(1, 2, -3, 4, -5);

Console.WriteLine("----------------------------------------");
/*-Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
*/

static bool reqemfunksiyasi(string yazi)
{
    for (int i = 0; i < yazi.Length; i++)
    {
        char simvol = yazi[i];
        if(simvol>='0' && simvol <= '9')
        {
            return false;
        }
        
    }
return true;

}

string a=Console.ReadLine();
if (reqemfunksiyasi(a))
{
    Console.WriteLine("reqem yoxdur!");
    
}
else
{
    Console.WriteLine("reqem var!");
}

/*Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
*/

static bool reqemfunksiyasii(string yazi)
{
    int count = 0;
    for (int i = 0; i < yazi.Length; i++)
    {
        char simvol = yazi[i];
        if (simvol >= '0' && simvol <= '9')
        {
            return false;
            count++;
            
        }

    }
    return true;

}


string  z= Console.ReadLine();

if (reqemfunksiyasii(z))
{
    Console.WriteLine("reqem yoxdur!");

}
else
{
    Console.WriteLine("reqem var!");
}










