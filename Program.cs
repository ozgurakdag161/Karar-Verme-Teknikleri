using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class MatrisProb
{
    public static int k, m, n, BiggestColumn;
    public static decimal alfa, DogalSayi;
    public static int[,] a;
    public static int[,] multip;
    public static decimal[,] result;
    public static decimal[] dogal = new decimal[1000];
    public static int[] biggestsInRow = new int[1000];
    public static decimal[] BiggestInSavage = new decimal[1000];
    public static decimal[] savega = new decimal[1000];
    public static int[] savega1 = new int[1000];
    public static decimal[] alfamaxrow = new decimal[1000];
    public static decimal[] alfaminrow = new decimal[1000];
    public static decimal[] alfaend = new decimal[1000];
    public static int[] smallestInRow = new int[1000];

    public MatrisProb(int x, int y)
    {
        m = x;
        n = y;
        a = new int[m, n];
        multip = new int[m, n];
        result = new decimal[m, n];
    }
    public void readmatrix()
    {
        Console.WriteLine("Veri gir : ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("a[{0},{1}]=", i + 1, j + 1);
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    public void printmax()
    {
        Console.WriteLine("Matris : ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}\t", a[i, j]);
            }
            Console.WriteLine();
        }
    }
    int minirow()
    {
        int smallest = 0;
        for (int r = 0; r < m; r++)
        {
            smallest = a[r, 0];
            for (int c = 0; c < n; c++)
            {
                if (a[r, c] < smallest)
                {
                    smallest = a[r, c];
                }
            }
            smallestInRow[r] = smallest;
        }
        int biggest = smallestInRow[0];
        int enbuyukSatir = 1;
        for (int i = 0; i < m; i++)
        {
            if (smallestInRow[i] > biggest)
            {
                biggest = smallestInRow[i];
                enbuyukSatir = i + 1;
            }
        }
        return enbuyukSatir;
    }
    int maxinrow()
    {
        int biggest = 0;
        for (int r = 0; r < m; r++)
        {
            biggest = 0;
            for (int c = 0; c < n; c++)
            {
                if (a[r, c] > biggest)
                {
                    biggest = a[r, c];
                }
            }
            biggestsInRow[r] = biggest;
        }
        int smallest = biggestsInRow[0];
        int enkucukSatir = 1;
        for (int i = 0; i < m; i++)
        {
            if (biggestsInRow[i] < smallest)
            {
                smallest = biggestsInRow[i];
                enkucukSatir = i + 1;
            }
        }
        return enkucukSatir;
    }
    int max()
    {
        int satır = 1;
        int big = a[0, 0];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (big < a[i, j])
                {
                    big = a[i, j];
                    satır = i + 1;
                }
            }
        }
        return satır;
    }
    int min()
    {
        int satır = 1;
        int min = a[0, 0];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (min > a[i, j])
                {
                    min = a[i, j];
                    satır = i + 1;
                }
            }
        }
        return satır;
    }
    decimal multpyMax(decimal DogalSayi)
    {

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                DogalSayi = n;
                result[i, j] = a[i, j] / DogalSayi;
            }
        }
        decimal top = 0;
        for (int i = 0; i < m; i++)
        {
            top = 0;
            for (int j = 0; j < n; j++)
            {
                top = top + result[i, j];

            }
            dogal[i] = top;
        }
        decimal biggest = dogal[0];
        int satır = 1;
        for (int r = 0; r < m; r++)
        {

            if (dogal[r] > biggest)
            {
                biggest = dogal[r];
                satır = r + 1;
            }
        }

        return satır;
    }
    decimal multpyMin(decimal DogalSayi)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                DogalSayi = n;
                result[i, j] = a[i, j] / DogalSayi;
            }
        }
        decimal top = 0;
        for (int i = 0; i < m; i++)
        {
            top = 0;
            for (int j = 0; j < n; j++)
            {
                top = top + result[i, j];

            }
            dogal[i] = top;
        }
        decimal smal = dogal[0];
        int satır = 1;
        for (int k = 0; k < m; k++)
        {
            if (dogal[k] < smal)
            {
                smal = dogal[k];
                satır = k + 1;
            }
        }
        return satır;
    }
    int minalfa()
    {
        decimal small = alfaend[0];
        int satır = 0;
        for (int i = 0; i < m; i++)
        {
            if (small > alfaend[i])
            {
                small = alfaend[i];
                satır = i + 1;
            }
        }
        return satır;
    }
    int maxalfa()
    {
        decimal big = 0;
        int satır = 0;
        for (int i = 0; i < m; i++)
        {
            if (big < alfaend[i])
            {
                big = alfaend[i];
                satır = i + 1;
            }
        }
        return satır;
    }
    void alfamin()
    {
        for (int t = 0; t < m; t++)
        {
            int small = a[t, 0];
            for (int j = 0; j < n; j++)
            {
                if (small > a[t, j])
                {
                    small = a[t, j];

                }
                alfaminrow[t] = small;
            }
        }
    }
    void alfamax()
    {
        int big;
        for (int t = 0; t < m; t++)
        {
            big = 0;
            for (int j = 0; j < n; j++)
            {
                if (a[t, j] > big)
                {
                    big = a[t, j];
                }
                alfamaxrow[t] = big;
            }
        }
    }
    static void alfaendMin(decimal alfa)
    {
        for (int i = 0; i < m; i++)
        {
            alfaend[i] = (alfamaxrow[i] * (1 - alfa)) + (alfaminrow[i] * alfa);
        }
        return;
    }
    static void alfaendMax(decimal alfa)
    {
        for (int i = 0; i < m; i++)
        {

            alfaend[i] = (alfamaxrow[i] * alfa) + (alfaminrow[i] * (1 - alfa));
        }
        return;
    }
    decimal SavegaMaxRow()
    {
        decimal big = 0;
        for (int i = 0; i < m; i++)
        {
            big = 0;
            for (int j = 0; j < n; j++)
            {
                if ((result[i, j] > big) && (result[i, j] != 0))
                {
                    big = result[i, j];
                }
            }
            BiggestInSavage[i] = big;
        }
        decimal small = BiggestInSavage[0];
        decimal enkucuksayı = 1;
        for (int j = 0; j < m; j++)
        {
            if (BiggestInSavage[j] < small)
            {
                small = BiggestInSavage[j];
                enkucuksayı = j + 1;
            }
        }
        return enkucuksayı;
    }
    void savegaMin()
    {
        decimal small;
        for (int r = 0; r < n; r++)
        {
            small = a[0, r];
            for (int c = 0; c < m; c++)
            {
                if (small > a[c, r])
                {
                    small = a[c, r];
                }
                savega[r] = small;
            }
        }
    }
    void savegaMAx()
    {
        int bg;
        for (int r = 0; r < n; r++)
        {
            bg = a[0, r];
            for (int c = 0; c < m; c++)
            {
                if (a[c, r] > bg)
                {
                    bg = a[c, r];
                }
                savega[r] = bg;
            }
        }
    }
    static void savegaMinMatris()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = a[i, j] - savega[j];
            }
        }
    }
    static void savegaMaxMatris()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = savega[j] - a[i, j];
            }
        }
    }
    public static void Main()
    {
        int x, y;
        MatrisProb obj;
        Console.Write("Alternatif sayısınızı giriniz :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Doğal durum sayısınızı giriniz :");
        y = Convert.ToInt32(Console.ReadLine());
        obj = new MatrisProb(x, y);
        obj.readmatrix();
        obj.printmax();
        int z;
        Console.WriteLine("Hangi ölçütü kullanmak istiyorsunuz seçiniz :");
        Console.WriteLine("1) İyimserlik ölçütü");
        Console.WriteLine("2) Kötümserlik ölçütü");
        Console.WriteLine("3) Eş Olasılık(Laplaca) ölçütü");
        Console.WriteLine("4) Hurwics (Uzlaştırma) ölçütü");
        Console.WriteLine("5) Pişmanlık (Savega) ölçütü");
        z = Convert.ToInt32(Console.ReadLine());
        while (z != 0)
        {
            if (z == 1)
            {
                int b;
                Console.WriteLine("Tablonuz kâr yapılı ise '1'i seçiniz. Maliyet yapılı ise '2'yi seçiniz. ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    int gelensatir = obj.max();
                    Console.Write("Alternatifler arasından " + gelensatir + ". alternatifini seçiniz.");
                    break;
                }
                else if (b == 2)
                {
                    int gelensatir = obj.min();
                    Console.Write("Alternatifler arasından " + gelensatir + ". alternatifini seçiniz.");
                    break;
                }
                else
                {
                    Console.Write("Yanlış tuşlama yaptınız.");
                    break;
                }
            }
            else if (z == 2)
            {
                int b;
                Console.WriteLine("Tablonuz kâr yapılı ise '1'i seçiniz. Maliyet yapılı ise '2'yi seçiniz. ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    int gelenEnKucukMin = obj.minirow();
                    Console.Write("Alternatifler arasından " + gelenEnKucukMin + ". alternatifini seçiniz.");
                    break;
                }
                else if (b == 2)
                {
                    int gelenEnKucukMax = obj.maxinrow();
                    Console.Write("Alternatifler arasından " + gelenEnKucukMax + ". alternatifini seçiniz.");
                    break;
                }
                else
                {
                    Console.Write("Yanlış tuşlama yaptınız.");
                    break;
                }
            }
            else if (z == 3)
            {
                int b;
                Console.WriteLine("Tablonuz kâr yapılı ise '1'i seçiniz. Maliyet yapılı ise '2'yi seçiniz. ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine("Doğal durumlarınızın adetini giriniz :");
                    DogalSayi = Convert.ToDecimal(Console.ReadLine());
                    obj.multpyMax(DogalSayi);
                    decimal gelensatir = obj.multpyMax(DogalSayi);
                    Console.Write("Alternatifler arasından " + gelensatir + ". alternatifini seçiniz. ");
                    break;
                }
                else if (b == 2)
                {
                    Console.WriteLine("Doğal durumlarınızın adetini giriniz :");
                    DogalSayi = Convert.ToDecimal(Console.ReadLine());
                    obj.multpyMin(DogalSayi);
                    decimal gelensatir = obj.multpyMin(DogalSayi);
                    Console.Write("Alternatifler arasından " + gelensatir + ". alternatifini seçiniz.");
                    break;
                }
                else
                {
                    Console.Write("Yanlış tuşlama yaptınız.");
                    break;
                }
            }
            else if (z == 4)
            {
                int b;
                Console.WriteLine("Tablonuz kâr yapılı ise '1'i seçiniz. Maliyet yapılı ise '2'yi seçiniz. ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    obj.alfamax();
                    obj.alfamin();
                    Console.WriteLine("Alfa Katsayınızı belirleyiniz.(Alfa Katsayınızda ',' kullanınız.) : ");
                    alfa = Convert.ToDecimal(Console.ReadLine());
                    alfaendMax(alfa);
                    int gelensatir = obj.maxalfa();
                    Console.WriteLine("Alternatifleriniz arasından " + gelensatir + ". alternatifini seçiniz. ");
                    break;
                }
                else if (b == 2)
                {
                    obj.alfamax();
                    obj.alfamin();
                    Console.WriteLine("Alfa Katsayınızı belirleyiniz.(Alfa Katsayınızda ',' kullanınız.) : ");
                    alfa = Convert.ToDecimal(Console.ReadLine());
                    alfaendMin(alfa);
                    int gelensatir = obj.minalfa();
                    Console.WriteLine("Alternatifleriniz arasından " + gelensatir + ". alternatifini seçiniz. ");
                    break;
                }
                else
                {
                    Console.Write("Yanlış tuşlama yaptınız.");
                    break;
                }

            }
            else if (z == 5)
            {
                int b;
                Console.WriteLine("Tablonuz kâr yapılı ise '1'i seçiniz. Maliyet yapılı ise '2'yi seçiniz. ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    obj.savegaMAx();
                    savegaMaxMatris();
                    Console.WriteLine("Yeni Oluşan Tablonuz. ");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0}\t", result[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    decimal gelensatır = obj.SavegaMaxRow();
                    Console.WriteLine("Alternatifler arasından " + gelensatır + ". alternatifini seçiniz.");
                    break;
                }
                else if (b == 2)
                {
                    obj.savegaMin();
                    savegaMinMatris();
                    Console.WriteLine("Yeni Oluşan Tablonuz. ");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0}\t", result[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    decimal gelensatır = obj.SavegaMaxRow();
                    Console.WriteLine("Alternatifler arasından " + gelensatır + ". alternatifini seçiniz.");
                    break;
                }
                else
                {
                    Console.Write("Yanlış tuşlama yaptınız.");
                    break;
                }
            }
            else
            {
                Console.Write("Yanlış tuşlama yaptınız.");
                break;
            }
        }
        Console.ReadLine();
    }
}