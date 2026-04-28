internal class Program
{
    private static void Main(string[] args)
    {
        const int Total_Sellos = 8;
        Console.WriteLine("---------Bienvenidos a la barberia de Crup-------");
        for (int i = 0; i <=Total_Sellos ; i++)

        {
            Console.WriteLine("\n Sello actual {0} de {1}",i,Total_Sellos);
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();

            Console.WriteLine(">>Sellos #{0} registrado correctamente");
        
        }
        Console.WriteLine("\n**********************");
        Console.WriteLine("Coponera Completa");
        Console.WriteLine("0, has ganado tu corte de cabello gratis");
        Console.WriteLine("\n**********************");
        Console.WriteLine("Presione una tecla para cerrar");
        Console.ReadKey();

    }
}
