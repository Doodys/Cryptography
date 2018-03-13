using System;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            string Information; int x = 0;
            Console.Title = "ROT13";
            do
            {
                Console.Clear();
                Console.Write("[1] Decode\n[2] Encode\n\nChoice: ");
                bool Result = uint.TryParse(Console.ReadLine(), out uint Num);
                Console.Clear();
                if (Result)
                {
                    switch (Num)
                    {
                        case 1:
                            Console.WriteLine("Decode: ");
                            Information = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Information decoded from ROT13:\n");
                            Console.WriteLine(Decode(Information));
                            x = 1;
                            break;
                        case 2:
                            Console.WriteLine("Encode: ");
                            Information = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Information encoded in ROT13:\n");
                            Console.WriteLine(Encode(Information));
                            x = 1;
                            break;
                        default: Console.WriteLine("Wrong choice"); break;
                    }
                }
                else { Console.WriteLine("Wrong choice\n\nPress any key to start again..."); Console.ReadKey(); }
            } while (x == 0);
        }
        public static char[] Decode(string Cipher)
        {
            char[] Decoded = new char[Cipher.Length];
            for (int i = 0; i < Cipher.Length; i++)
            {
                int Value = (int)Cipher[i];
                if ((Value >= 78 && Value <= 90) || (Value >= 110 && Value <= 122)) { Value -= 13; Decoded[i] = (char)Value; }
                else if ((Value >= 65 && Value <= 77) || (Value >= 97 && Value <= 109)) { Value += 13; Decoded[i] = (char)Value; }
                else { Decoded[i] = (char)Value; }
            }
            return Decoded;
        }
        public static char[] Encode(string Cipher)
        {
            char[] Encoded = new char[Cipher.Length];
            for (int i = 0; i < Cipher.Length; i++)
            {
                int Value = (int)Cipher[i];
                if ((Value >= 65 && Value <= 77) || (Value >= 97 && Value <= 109)) { Value += 13; Encoded[i] = (char)Value; }
                else if ((Value >= 78 && Value <= 90) || (Value >= 110 && Value <= 122)) { Value -= 13; Encoded[i] = (char)Value; }
                else { Encoded[i] = (char)Value; }
            }
            return Encoded;
        }
    }
}
