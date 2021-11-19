using System.Linq;

namespace Met_1311
{
    class ACipher : ICipher
    {
        protected static string alphabet_eng = "abcdefghijklmnopqrstuvwxuzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        protected static string alphabet_ru = "абвгдеёжзийклмнопрстуфхцчшщъьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЭЮЯ";

        public string Encode(string text)
        {
            string output = "";
            foreach (char letter in text)
            {
                if (alphabet_eng.Contains(letter))
                {
                    if (letter == 'z')
                    {
                        output += 'a';
                    }
                    else if (letter == 'Z')
                    {
                        output += 'A';
                    }
                    else
                    {
                        output += alphabet_eng[alphabet_eng.IndexOf(letter) + 1];
                    }
                }
                else if (alphabet_ru.Contains(letter))
                {
                    if (letter == 'я')
                    {
                        output += 'А';
                    }
                    else if (letter == 'Я')
                    {
                        output += 'А';
                    }
                    else
                    {
                        output += alphabet_ru[alphabet_ru.IndexOf(letter) + 1];
                    }
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
                if (alphabet_eng.Contains(letter))
                {
                    if (letter == 'a')
                    {
                        output += 'z';
                    }
                    else if (letter == 'A')
                    {
                        output += 'Z';
                    }                    
                    else
                    {
                        output += alphabet_eng[alphabet_eng.IndexOf(letter) - 1];
                    }
                }
                else if (alphabet_ru.Contains(letter))
                {
                    if (letter == 'а')
                    {
                        output += 'я';
                    }
                    else if (letter == 'А')
                    {
                        output += 'Я';
                    }
                    else
                    {
                        output += alphabet_ru[alphabet_ru.IndexOf(letter) - 1];
                    }
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
