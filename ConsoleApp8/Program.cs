namespace ConsoleApp8
{
    internal class Program
    {
        static int[] Octave;
        static void Main()
        {
            Octavi();

        }
        static void Octavi ()
        { 

            int[] pervaiOctava = new int[] {261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493};
            int[] vtoraiOctava =new int [] {523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987};

            Octave = pervaiOctava;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F1)
                {
                    Octave = pervaiOctava;
                    Console.WriteLine("Первая октава");
                    Playpiano(Octave);

                }
                else if (key.Key == ConsoleKey.F2)
                {
                    Octave = vtoraiOctava;
                    Console.WriteLine("Вторая октава");
                    Playpiano(Octave);
                }
               
            }
        }

        static void Playpiano(int[] Octave)
        {
           
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave[0], 200);
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave[1], 200);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(Octave[2], 200);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(Octave[3], 200);
                }
                else if(key.Key == ConsoleKey.G)
                {
                    Console.Beep(Octave[4], 200);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(Octave[5], 200);
                }
                else if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(Octave[6], 200);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave[7],200);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave[8], 200);
                }
                else if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(Octave[9], 200);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave[10], 200);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave[11], 200);
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    return;
                    break;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    return;
                    break;
                }
                else if (key.Key == ConsoleKey.Enter) 
                {
                    Environment.Exit(0);
                }
               
            }
        }

    }
}

