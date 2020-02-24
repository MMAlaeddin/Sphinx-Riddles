using System;
using System.Collections.Generic;
using System.Linq;

class Riddles
{
  static void Main()
  {
    Random rand = new Random();
    Dictionary<string, string> riddles = new Dictionary<string, string>(){
      {"footsteps", "The more you take, the more you leave behind. What am I?"},
      {"fence", "What runs around the whole yard without moving?"},
      {"telephone", "You answer me, although I never ask you questions."}
      };
    Dictionary<string, string> randRiddle = riddles.OrderBy(x=>rand.Next()).ToDictionary(item => item.Key, item => item.Value);
   foreach(KeyValuePair<string, string> entry in randRiddle)
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