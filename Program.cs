using static System.Net.Mime.MediaTypeNames;
using System;

Tablice tablica = new Tablice();
tablica.odwroc();
tablica.sortuj();
tablica.wypelnia();
//Console.WriteLine(tablica.minztab(0));
Console.WriteLine(tablica.ile('=',85));
tablica.wypisz();

Console.Read();
//
// ^Main^
//
public class Tablice
{
    int[] tabl = { 2, 123, 15, 85, 5, 36 };
    int[] tab1 = new int[20];
    int i;
    public void odwroc()
    {
        int zmien;
        for (i = 0; i < tabl.Length / 2; i++)
        {
            zmien = tabl[i];
            tabl[i] = tabl[tabl.Length - i - 1];
            tabl[tabl.Length - i - 1] = zmien;
        }
    }
    public int ile(char znak ,int liczbaCal)
    {
        int aa = 0;
        for(i = 0; i < tabl.Length; i++)
        {
            if(znak == '>')
            {
                if (tabl[i] > liczbaCal)
                {
                    aa++;
                }
            }
            else if (znak == '<')
            {
                if (tabl[i] < liczbaCal)
                {
                    aa++;
                }
            }
            else if (znak == '=')
            {
                if (tabl[i] == liczbaCal)
                {
                    aa++;
                }
            }

        }
        return aa;
    }
    public void wypelnia()
    {
        int min = 0;
        int max = 100;
        Random ran = new Random();
            for (i = 0; i < tab1.Length; i++)
            {
                tab1[i] = ran.Next(min, max);
            }
            
    }
    public void sortuj()
    {
        int j = 1;
        int min = 0;
        for(i = 1; i < tabl.Length; i++)
        {
            for (j = tabl.Length - 1; j >= i; j--)
            {
                if (tabl[j - 1] > tabl[j])
                {
                    min = tabl[j];
                    tabl[j] = tabl[j - 1];
                    tabl[j - 1] = min;
                }
            }
        }
    }
    /*public void sortuj()
    {
        int j = minztab(i);
        int min;
        for(i = 0; i < tabl.Length; i++)
        {
            min = tabl[i];
            tabl[i] = tabl[j];
            tabl[j] = min;
        }
    }
    public int minztab(int o)
    {
        int minim = o;
        for(i = o + 1; i < tabl.Length; i++)
        {
            if (tabl[i] < tabl[minim])
            {
                minim = i;
            }
        }
        return minim;
    }*/
    public void wypisz()
    {
        foreach (int w in tab1)
        {
            Console.Write(w + " ");
        }
        Console.WriteLine();
        Random ranIndex = new Random();
        for (i = 0; i < 20; i++)
        {
            Console.Write(tab1[ranIndex.Next(20)] + " ");
        }
    }
}
