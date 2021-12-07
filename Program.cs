using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("Enter a secret message.");
      string message = Console.ReadLine();
      string messageLower = message.ToLower();
      
      char[] secretMessage = messageLower.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet, letter);
        int secretIndex = (index + 3) % 26;
        char secretChar = alphabet[secretIndex];
        encryptedMessage[i] = secretChar;
      }

      string decodedMessage = String.Join("", encryptedMessage);
      Console.WriteLine(decodedMessage);
    }
  }
}
