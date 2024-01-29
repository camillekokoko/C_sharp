using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "I"; 
      string middle = "am";
      string end = "a cat";


      // Concatenate the string and the variables
      string story = beginning + " not " + middle + " " + end + " ?" ;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
