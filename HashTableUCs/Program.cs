namespace HashTableUCs
{
    class program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome To HashTable Program");
            Console.WriteLine("Choose a Number From Below\n" +
                "1: Checking a Frequency For Single Line Statement (UC1)\n" +
                "2: Checking a Frequency For Paragraph Statement (UC2)\n" +
                "3: Removing word \\\"avoidable\\\" and recounting the occurrences in a same paragraph.\\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string paragraph = "To be or not to be";//UC1 (Counting frequency of occurrence of words in a sentence .
                    CountNumbOfOccurence(paragraph);
                    break;
                case 2:
                    string paragraph1 = "Paranoids are not paranoid " +
                        "because they are paranoid but " +
                        "because they keep putting themselves " +
                        "deliberately into paranoid avoidable " +
                        "situations";
                    CountNumbOfOccurence(paragraph1);
                    break;
                case 3:                     //UC3 (Counting frequency of occurrence of words in a paragraph and removing 1 word and showing difference.
                    MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);
                    string paragraph2 = "Paranoids are not paranoid " +
                        "because they are paranoid but " +
                        "because they keep putting themselves " +
                        "deliberately into paranoid avoidable " +
                        "situations";
                    string[] words = paragraph2.Split(' ');
                    foreach (string word in words)
                    {
                        if (hashTabe.Exists(word.ToLower()))
                            hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                        else
                            hashTabe.Add(word.ToLower(), 1); //to,1 
                    }
                    Console.WriteLine("All words counted .");
                    hashTabe.Display();
                    string s = "avoidable";
                    hashTabe.Remove(s);
                    Console.WriteLine();
                    Console.WriteLine($"A word \"{s}\" has been removed ");
                    hashTabe.Display();
                    break;
                default:
                    Console.WriteLine("Invalid option selected ! Please try again .");
                    break;

            }
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Please find below words with its frequency of occurrence's :- ");
            hashTabe.Display();
        }
    }
}