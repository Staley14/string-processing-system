public class StringView
{
  private StringService service = new StringService();

  public void Run()
  {
    bool running = true;

    while(running)
    {
      DisplayMenu();
      string choice = Console.ReadLine();

      switch(choice)
      {
        case "1":
          Console.Write("Enter text: ");
          string text = Console.ReadLine();
          service.SetText(text);
          break;

        case "2":
          Console.WriteLine("Current Text: "+ service.GetCurrentText());
          break;

        case "3": 
          service.ToUpperCase();
          break;

        case "4":
          service.ToLowerCase();
          break;

        case "5":
          Console.WriteLine("Character count: "+ service.CountCharacters());
          break;

        case "6":
          Console.Write("Enter word to check: ");
          string word = Console.ReadLine();
          Console.WriteLine(service.ContainsWord(word));
          break;

        case "7":
          Console.Write("Word to replace: ");
          string oldWord = Console.ReadLine();
          Console.Write("New word: ");
          string newWord = Console.ReadLine();
          service.ReplaceWord(oldWord, newWord);
          break;

        case "8":
          Console.Write("Start index: ");
          int start = int.Parse(Console.ReadLine());
          Console.Write("Length: ");
          int length = int.Parse(Console.ReadLine());
          service.ExtractSubstring(start, length);
          break;

        case "9":
          service.TrimSpaces();
          break;

        case "10":
          service.ResetText();
          break;

        case "11":
          running = false;
          break;

      }
    }
  }

  private void DisplayMenu()
  {
    Console.WriteLine("\n         STRING PROCESSING SYSTEM         ");
    Console.WriteLine("1. Enter Text");
    Console.WriteLine("2. View Current Text");
    Console.WriteLine("3. Convert to Uppercase");
    Console.WriteLine("4. Convert to Lowercase");
    Console.WriteLine("5. Count characters");
    Console.WriteLine("6. Check if it contains word");
    Console.WriteLine("7. Replace word");
    Console.WriteLine("8. Extract Substring");
    Console.WriteLine("9. Trim Spaces");
    Console.WriteLine("10. Reset text");
    Console.WriteLine("11. Exit");
    Console.WriteLine("Choose option: ");
  }
}

        
          
