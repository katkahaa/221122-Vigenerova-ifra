using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221122_Vigenerova_šifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Encrypt("salamander", "quark");
            Console.WriteLine(message);
            Console.WriteLine(Decrypt(message, "quark"));
            Console.ReadLine();
        }

        static string Encrypt (string message, string key)
        {
            string encryptedMessage = "";
            int iKey = 0;
            int keyIndex = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 97 || message[i] <= 122)
                {
                    keyIndex = i;
                    if (keyIndex >= key.Length)
                        keyIndex -= key.Length;
                    iKey = key[keyIndex];

                    int c = message[i] + (iKey - 'a');
                    if (c > 122)
                        c -= 26;
                    encryptedMessage += (char)c;
                }
            }

            return encryptedMessage;
        }

        static string Decrypt(string message, string key)
        {
            string decryptedMessage = "";
            int iKey = 0;
            int keyIndex = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 97 || message[i] <= 122)
                {
                    keyIndex = i;
                    if (keyIndex >= key.Length)
                        keyIndex -= key.Length;
                    iKey = key[keyIndex];

                    int c = message[i] - (iKey - 'a');
                    if (c < 97)
                        c += 26;
                    decryptedMessage += (char)c;
                }
            }

            return decryptedMessage;
        }
    }
}
