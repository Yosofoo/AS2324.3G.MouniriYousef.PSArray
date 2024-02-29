namespace AS2324._3G.MouniriYousef.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di voti");
            int dim = Convert.ToInt32(Console.ReadLine());

            int[] voti = new int[dim];//array per i voti del primo for

            int[] pesi = new int[dim];

            for (int i = 0; i < dim; i++)
            {
                Console.WriteLine($"Inserire il {i + 1} voto");
                voti[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Inserire il peso del {i+1} voto");
                pesi[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for (int i = 0;i < voti.Length;i++)
            {

            }
        }
    }
}
