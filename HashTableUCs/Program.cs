namespace HashTableUCs
{
    class program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome To HashTable Program");
            Console.WriteLine("Choose a Number From Below\n" +
                "1: Checking a Frequency For Single Line Statement (UC1)\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string paragraph = "To be or not to be";//UC1 (Counting frequency of occurrence of words in a sentence .
                    CountNumbOfOccurence(paragraph);
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