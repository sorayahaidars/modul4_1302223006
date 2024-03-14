public class KodeBuah 
{ 
    public string GetKodeBuah(string namaBuah)
    {
        string[] namabuahArray = new string[]
        {
            "Apel",
            "Aprikot",
            "Alpukat",
            "Pisang",
            "Paprika",
            "Blackberry",
            "Ceri",
            "Kelapa",
            "Jagung",
            "Kurma",
            "Durian",
            "Anggur",
            "Melon",
            "Semangka"
        };

        string[] kodebuahArray = new string[]
        {
            "A00",
            "B00",
            "COO",
            "D00",
            "E00",
            "F00",
            "H00",
            "I00",
            "J00",
            "KOO",
            "L00",
            "M00",
            "N00",
            "O00"
        };

        for (int i = 0; i < namabuahArray.Length; i++)
        {
            if (namaBuah.Equals(namabuahArray[i]))
            {
                return kodebuahArray[i];
            }
        }
        return "Kode buah tidak ditemukan";
    }
}

public enum Tombol
{
    TombolW,
    TombolS
}

public class PosisiKarakterGame
{
    private Tombol tekan;
    private string posisiawal;
    private string posisiselanjutnya;

    public void PosisiBerdiri()
    {
       if (posisiawal == "Berdiri")
        {
            tekan = Tombol.TombolW;
            posisiselanjutnya = PosisiTerbang();
        }
    }

    public void PosisiJongkok()
    {
        if (posisiawal == "Jongkok")
        {
            tekan = Tombol.TombolS;
            posisiselanjutnya = PosisiTengkurap();
            Console.WriteLine("posisi istirahat");
        }
    }

    public void PosisiTengkurap()
    {
        if (posisiawal == "Tengkurap")
        {
            tekan = Tombol.TombolW;
            posisiselanjutnya = PosisiJongkok();
        }
    }

    public void PosisiTerbang()
    {

    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Masukkan nama buah: ");
        string namabuah = Console.ReadLine();
        string kodebuah = kodeBuah.GetKodeBuah(namabuah);
        Console.WriteLine($"Kode buah untuk buah {namabuah} adalah {kodebuah}");


    }
}

