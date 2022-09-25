using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!|?/.,';:@#~][{}=+()*&^%$£";
      
      Console.WriteLine("Please enter a password: ");
      string password = Console.ReadLine();
      int score = 0;

      if (password.Length >= minLength) 
      {
        score++;
      } 
      if (Tools.Contains(password, uppercase)) 
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
    
    switch (score) {
      case 5:
      case 4:
        Console.WriteLine("the password is very strong");
        break;
      
      case 3:
        Console.WriteLine("the password is strong");
        break;

      case 2:
        Console.WriteLine("the password is of medium strength");
        break;
      
      case 1:
        Console.WriteLine("the password is weak");
        break;

      default:
        Console.WriteLine("Password does not meet standards");
        break;
    }

    
    }
  }
}