namespace ExamenUnidad3RLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Lista lis = new Lista();

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Inserte un nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Inserte la edad:");
                int edad = int.Parse(Console.ReadLine());
                lis.InsertarFinal(nombre, edad);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre que busca:");
            string nombreBuscado = Console.ReadLine();
            lis.BuscarNombrePosicion(nombreBuscado);

            Console.WriteLine("Elementos ordenados de forma ascendente:");
            lis.ImprimirElementosAscendente();

        }
    }
}