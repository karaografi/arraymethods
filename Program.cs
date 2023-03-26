internal class Program
{
    private static void Main(string[] args)
    {
        //Sort
        int[] sayidizisi = {23,12,4,86,72,3,11,17};

        Console.WriteLine("********  Sırasız Dizi  *******");
        foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);


        Console.WriteLine("********  Sıralı Dizi  *******");
        
        Array.Sort(sayidizisi);
        foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);

        
        //Clear
        Console.WriteLine("********  Array Clear  *******");

        Array.Clear(sayidizisi,2,2);

        foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);


        //Reverse
        Console.WriteLine("********  Array Reverse  *******");

        Array.Reverse(sayidizisi);

        foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);


        
        //IndexOf
        Console.WriteLine("********  Array IndexOf  *******");

        Console.WriteLine(Array.IndexOf(sayidizisi,23));



        //Resize
         Console.WriteLine("********  Array Resizee  *******");

        Array.Resize<int>(ref sayidizisi,9);
        sayidizisi[8] = 99;

        foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);

    }
}