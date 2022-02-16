Console.Write("Maaşın ne kadar? : ");
int cevap1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kaç sene sonraki maaşını öğrenmek istiyorsun? : ");
int cevap2 = Convert.ToInt32(Console.ReadLine());

if (cevap2 == 0)
{
    Console.WriteLine(cevap1);
}

else
{
    int maas = ((cevap1 * 15 / 100) + cevap1) * cevap2;

    Console.WriteLine(maas);
}



//Her sene yapılan zamma göre kaç sene sonra ne kadar maaş alınacağının hesabı