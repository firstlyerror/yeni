

// - Verilmiş sıra ilə düzülmüşlər siyahısındakı verilmiş n ədədinin yerləşdiyi indeksi tapan alqoritm bizə -1 gostər lazımdır.
// Misalçün [1, 4, 7, 23, 45, 67, 90] kimi bir siyahı verilmişsə və n=4 olarsa alqoritm bizə 1 cavabını verməlidir cüçki
// 4 ədədi 1 nömrəli indeksdə yerləşir. n=35 olarsa alqoritm bizə - 1 dəyəri göstərilməlidir lazımi səviyyədə 35 yoxdur.

int n = 1;
int[] salam = { 1, 2, 3, 4, 5, 6, 7, 210 };
bool tapildi = false;

for (int i = 0; i < salam.Length; i++)
{
    if (n == salam[i])
    {
        Console.WriteLine(i);
        tapildi = true;
        break; 
    }
}

if (!tapildi)
{
    Console.WriteLine(-1);
}









