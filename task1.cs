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
        Console.Write(inputText);
    }
}