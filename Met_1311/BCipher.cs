using System.Linq;

namespace Met_1311
{
    class BCipher : ICipher
    {
        private static string[] alphabets = {
            "abcdefghijklmnopqrstuvwxuz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЫЭЮЯ"
        };

        private int i;

        public BCipher(int i)
        {
            this.i = i;
        }

        public string Encode(string text)
        {
            string output = "";
            foreach (char letter in text)
            {
                if (alphabets[0].Contains(letter))
                {
                    output += alphabets[0][(alphabets[0].IndexOf(letter) + i % 26) % 26];
                }
                else if (alphabets[1].Contains(letter))
                {
                    output += alphabets[1][(alphabets[1].IndexOf(letter) + i % 26) % 26];
                }
                else if (alphabets[2].Contains(letter))
                {
                    output += alphabets[2][(alphabets[2].IndexOf(letter) + i % 33) % 33];
                }
                else if (alphabets[3].Contains(letter))
                {
                    output += alphabets[3][(alphabets[3].IndexOf(letter) + i % 33) % 33];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }
        public string Decode(string detext)
        {
            string output = "";
            foreach (char letter in detext)
            {
                if (alphabets[0].Contains(letter))
                {
                    output += alphabets[0][(alphabets[0].IndexOf(letter) + (26 - i % 26)) % 26];
                }
                else if (alphabets[1].Contains(letter))
                {
                    output += alphabets[1][(alphabets[1].IndexOf(letter) + (26 - i % 26)) % 26];
                }
                else if (alphabets[2].Contains(letter))
                {
                    output += alphabets[2][(alphabets[2].IndexOf(letter) + (33 - i % 33)) % 33];
                }
                else if (alphabets[3].Contains(letter))
                {
                    output += alphabets[3][(alphabets[3].IndexOf(letter) + (33 - i % 33)) % 33];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }
    }
}
