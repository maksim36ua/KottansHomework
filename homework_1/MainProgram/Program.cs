using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public class CeasarCipher
    {
        private int[] alphabet = Enumerable.Range(33, 94).ToArray();
        private int[] modifiedAlphabet = new int[94];

        public CeasarCipher(int offset)
        {

            CheckOffsetForExceptions(offset);

            int modifiedAlphabetIndex = 0;
            for (int letterNumber = offset; letterNumber < alphabet.Length; letterNumber++)
            {
                modifiedAlphabet[modifiedAlphabetIndex] = alphabet[letterNumber];
                modifiedAlphabetIndex++;
            }

            for (int letterNumber = 0; letterNumber < offset; letterNumber++)
            {
                modifiedAlphabet[modifiedAlphabetIndex] = alphabet[letterNumber];
                modifiedAlphabetIndex++;
            }
        }

        public string Encrypt(string word)
        {
            if (word == "") return word;

            CheckDataForExceptions(word);

            int[] asciiCodes = new int[word.Length];
            string answer = "";

            int index = 0;
            foreach (var letter in word)   // Creating massive of ASCII codes from chars in word
            {
                asciiCodes[index] = (int) letter;
                index++;
            }
            
            foreach (var code in asciiCodes) // Comparing codes of letters in word with codes in alphabet 
            {
                if (code == 32)
                {
                    answer += " ";
                    continue;
                }
                for (int letterIndex = 0; letterIndex < alphabet.Length; letterIndex++)
                {
                    if (code == alphabet[letterIndex])
                    {
                        answer += (char) modifiedAlphabet[letterIndex];
                        break;
                    }
                }
            }

            return answer;
        }

        public string Decrypt(string word)
        {
            if (word == "") return word;

            CheckDataForExceptions(word);

            int[] asciiCodes = new int[word.Length];
            string answer = "";

            int index = 0;
            foreach (var letter in word)   // Creating massive of ASCII codes from chars in word
            {
                asciiCodes[index] = (int)letter;
                index++;
            }

            foreach (var code in asciiCodes) // Comparing codes of letters in word with codes in modified alphabet 
            {
                if (code == 32)
                {
                    answer += " ";
                    continue;
                }

                for (int letterIndex = 0; letterIndex < alphabet.Length; letterIndex++)
                {
                    if (code == modifiedAlphabet[letterIndex])
                    {
                        answer += (char)alphabet[letterIndex];
                        break;
                    }
                }
            }

            return answer;
        }

        public void CheckDataForExceptions(string word)
        {
                if (String.IsNullOrEmpty(word))
                    throw new ArgumentNullException("word", "Entered word is null");

                bool isPresent = false;             // Checking for presence in the alphabet
                foreach (var letter in word)
                    foreach (var letterCode in alphabet)
                    {
                        if (letter == (char)letterCode)
                            isPresent = true;
                    }

                if (!isPresent)
                    throw new ArgumentOutOfRangeException("word", "Element of word is not in alphabet");

        }

        private void CheckOffsetForExceptions(int offset)
        {
            if (offset >= alphabet.Length || offset < 0)
                throw new ArgumentOutOfRangeException("offset", "Inappropriate value of offset");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            CeasarCipher ceasarObj = new CeasarCipher(2);
            Console.WriteLine("Offset: 2");
            Console.WriteLine("Entered string:  \t{0}","THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG");
            Console.WriteLine("Encrypted string:\t{0}", ceasarObj.Encrypt("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
            Console.WriteLine("Decrypted string:\t{0}", ceasarObj.Decrypt(ceasarObj.Encrypt("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG")));
            Console.Read();
        }
    }
}
