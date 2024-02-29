namespace AS2324._3G.MouniriYousef.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di voti");
            int nVoti = Convert.ToInt32(Console.ReadLine());

            double[] voti = new double[nVoti];//array per i voti del primo for

            int[] pesi = new int[nVoti];

            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine($"Inserire il {i + 1} voto");
                voti[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Inserire il peso del {i + 1} voto");
                pesi[i] = Convert.ToInt32(Console.ReadLine());
            }
            StampaVotiPesi(voti, pesi, nVoti); //richiamo la prima funzione per stampare i voti e pesi inseriti dall'utente 

        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti  " + "  Pesi");
            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine(voti[i] + "    " + pesi[i]);//stampa i voti e pesi alla distanza di 4 spazi
            }
        }
    }
}
