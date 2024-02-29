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
            
            Console.WriteLine("Adesso verranno caricati dei voti e pesi casuali");
            CaricaVettori(ref voti, ref pesi, nVoti); //richiamo la funzione, adesso i valori di voti[] e pesi[] sono cambiati
            StampaVotiPesi(voti, pesi, nVoti);//stampo i voti e pesi generati casualmente

            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);



        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti  " + "  Pesi");
            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine(voti[i] + "       " + pesi[i]);//stampa i voti e pesi alla distanza di 7 spazi
            }
        }

        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random rnd = new Random();
            for (int i = 0; i < nVoti; i++)
            {
                voti[i] = rnd.Next(0, 11);
                pesi[i] = rnd.Next(0, 101);

            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for(int i = 0;i < nVoti; i++)//La posizione 0 dell'array la vediamo come 1
            {
                if (voti[i] > 4)
                {
                    voti[i] = voti[i - 1];
                }
                i++;
            }
        }

    }
}
