using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string f = "";
            char up;
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                    f += c;
                else
                {
                    up = char.IsUpper(c) ? 'A' : 'a';
                    f += (char)((((c + shiftKey) - up) % 26) + up);
                }
            }
            return f;

        }
        public static void Main(string[] args){
            
        }
    }
}
