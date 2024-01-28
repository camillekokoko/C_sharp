using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      // The command Console.WriteLine() prints text to the console
      Console.WriteLine("How old are you?");
      
      // The command Console.ReadLine() captures user input in the console
      string input = Console.ReadLine();
      
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

```
dotnet run
How old ar you?
18
You are 18 years old!
```
