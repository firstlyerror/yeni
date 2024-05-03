

/*-Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod*/

static int sum(int num1,int num2)
{
    return num1 + num2;
}

Console.WriteLine(sum(1,2));
Console.WriteLine("---------------------------------------");

/*-Verilmiş ədədin kvadratını qaytaran metod*/

static void pow(int num1)
{
    Console.WriteLine(num1*num1); 
}
pow(2);

Console.WriteLine("---------------------------------------");
/*-Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
*/
static void ad(string name)
{
    char herf = 'A';
    char herf1 = 'a';
    bool duzdur = false;
    for(int i = 0; i < name.Length; i++)
    {
        if (name[i] == herf || name[i] == herf1)
        {
             Console.WriteLine(" a herfi var!");
            duzdur = true;
            break;
        }
        
        
        }
    if (!duzdur)
    {
        Console.WriteLine("yoxdur!");
        duzdur = false;
    }
} 

ad("ilkin");




Console.WriteLine("---------------------------------------");
/*-Verilmiş ədədin rəqəmləri cəmini qaytaran metod*/

static void mum(int num1)
{
    int cem = 0;
    while (num1 !=0)
    {

        if (num1 != 0)
        {
            cem = cem + num1 % 10;
            num1 = num1 / 10;


        }
    } 
   
    Console.WriteLine(cem);

}
mum(19);
Console.WriteLine("---------------------------------------");
/*Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod*/

static void avg(int num1,int num2,int num3,int num4)
{
    int cem = num1 + num2 + num3 + num4;
    int avarage = cem / 4;
    Console.WriteLine(avarage);
}
avg(1, 2, 3, 4);




Console.WriteLine("---------------------------------------");
