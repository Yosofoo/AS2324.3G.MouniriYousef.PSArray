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

            Console.WriteLine("Adesso verranno stampati i voti in posizione dispari e maggiori di 4");
            Console.WriteLine("Voti  " + "  Pesi");
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);

            double max;//variabile per la funzione sotto
            double min;//variabile per la funzione sotto
            min = voti[0];
            max = voti[0];
            int posMax = 0;//variabile per la funzione sotto
            int posMin = 0;//variabile per la funzione sotto

            Console.WriteLine("Adesso verra calcolata la media ponderata, il voto massimo e la sua posizione e il voto minimo e la sua posizione");
            double mediaPonderata = MediaPonderata(voti, pesi, nVoti,ref max,ref posMax , ref min, ref posMin);
            Console.WriteLine($"Il voto più alto è {max}, in posizione {posMax}, il voto più basso è {min} in posizione {posMin}, la media ponderata di tutti i voti è {mediaPonderata}");
            StampaVotiPesi(voti, pesi, nVoti);

            Console.WriteLine("Inserire un voto per elencare tutti i voti simili(+-0,5)");
            double votoUtente = Convert.ToDouble(Console.ReadLine());

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
            int pos;
            for (int i = 0; i < nVoti; i += 2)//0 viene considerato 1, perché è come contiamo noi
            {
                if (voti[i] > 4)
                {
                    Console.WriteLine(voti[i] + "       " + pesi[i]);//stampa i voti e pesi alla distanza di 7 spazi
                }
            }
        }
        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax,ref double min, ref int posmin)
        {
            double sommatoria = 0;
            double numeratore = 0;
            
            for (int i = 0; i < nVoti; i++)
            {
                if (voti[i] > max)
                {
                    max = voti[i];
                    posmax = i;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i;
                }
                sommatoria += pesi[i]; //sommo tutti i pesi per il denominatore
                numeratore += voti[i] * pesi[i]; //qui sommo la moltiplicazione dei voti e pesi per ottenere il numeratore
            }
            return numeratore/ sommatoria;
        }
        static double ElencoVotiNellIntorno(double[] voti, int[] pesi, double votoUtente, int nVoti, int voto)
        {
            for(int i = 0;i < nVoti;i++)
            {
                if (voti[i] - 0.5 < votoUtente && voti[i] + 0.5 > votoUtente)
                {
                    Console.WriteLine(voti[i] + "       " + pesi[i]);//stampa i voti e pesi alla distanza di 7 spazi
                }
            }
        }

        static void OrdinaPerVoto(ref double[] voti, ref int[] pesi, int nVoti)
        {
            double temp;
            for(int i = 0; i < nVoti - 1; i++)
            {
                for (int j = 0; j < nVoti - i - 1; j++)
                {
                    if (voti[j] < voti[j + 1])
                    {
                        temp = voti[i];
                        voti[i] = voti[j + 1];
                        voti[j + 1] = temp;
                    }
                }
            }
        }


    }
}
