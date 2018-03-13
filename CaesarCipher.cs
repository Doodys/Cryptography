﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Information;
            Console.Title = "Caesar Cipher";
            Console.Write("[1] Decode\n[2] Encode\n\nChoice: ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (x)
            {
                case 1:
                    Console.WriteLine("Decode: ");
                    Information = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Information decoded from Caesar Cipher:\n");
                    Console.WriteLine(Decode(Information));                    
                    break;
                case 2:
                    Console.WriteLine("Encode: ");
                    Information = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Information encoded in Caesar Cipher:\n");
                    Console.WriteLine(Encode(Information));
                    break;
                default: Console.WriteLine("Wrong choice"); break;
            }

        }
        public static char[] Decode(string Cipher)
        {
               char[] Decoded = new char[Cipher.Length];
            for (int i = 0; i < Cipher.Length; i++)
            {
                int Value = (int)Cipher[i];
                if ((Value >= 68 && Value <= 90) || (Value >= 100 && Value <= 122)) { Value -= 3; Decoded[i] = (char)Value; }
                else if ((Value >= 65 && Value <= 67) || (Value >= 97 && Value <= 99)) { Value += 23; Decoded[i] = (char)Value; }
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
                if ((Value >= 65 && Value <= 87) || (Value >= 97 && Value <= 119)) { Value += 3; Encoded[i] = (char)Value;}
                else if((Value >= 88 && Value <= 90) || (Value >= 120 && Value <= 122)) { Value -= 23; Encoded[i] = (char)Value;}
                else { Encoded[i] = (char)Value; }
            }
            return Encoded;
        }
    }
}
