namespace CheckPangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = Console.ReadLine().ToLower();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int letterCount = 0;
            char[] missingLetter = new char[26];
            int missingLetterCount = 0;

            foreach (char i in alphabet)
            {


                if (pangram.Contains(i))
                {
                    letterCount++;
                }
                else
                {
                    missingLetter[missingLetterCount] = i;
                    missingLetterCount++;
                }
            }

            if (letterCount == 26)
            {
                Console.WriteLine("This is a pangram");
            }
            else
            {
                Console.Write("The sentence is missing: ");
                foreach (char i in missingLetter)
                {
                    Console.Write(i + " ");
                    if(i == " ") break;
                }
            }
        }
    }
}
