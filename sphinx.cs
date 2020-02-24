using System;
using System.Collections.Generic;

class Riddles
{
  static void Main()
  {
    Dictionary<string, string> riddles = new Dictionary<string, string>(){
      {"footsteps", "The more you take, the more you leave behind. What am I?"},
      {"fence", "What runs around the whole yard without moving?"},
      {"telephone", "You answer me, although I never ask you questions."}
      };
   foreach(KeyValuePair<string, string> entry in riddles)
    {
        Console.WriteLine(entry.Value);
        string answer = Console.ReadLine();
        if(answer.ToLower()==entry.Key)
        {
          Console.WriteLine("Correct! Next Riddle:");
        }
        else
        {
          Console.WriteLine("Wrong! you got ate.....");
          break;
        }
    }
  }
}