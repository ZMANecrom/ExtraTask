namespace ExtraTask1;

class task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст (порожній рядок для завершення): ");
        string inputText = "";
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            inputText += line + " ";
        }

        string[] sentences = inputText.Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            string s = sentences[i];
            sentences[i] = s.Trim();
            Console.WriteLine(sentences[i]);
        }
        Console.WriteLine(inputText);
    }
}