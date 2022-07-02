using System;
using BakeryStore.Models;

namespace BakeryStore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("                  Welcome to Pierre's Bakery!!");
      Console.WriteLine("");
      Console.WriteLine(@"                             \\\\            
                           _( *v* )->        
	                 _(         )_     
                        (             )  
                       mmmmmmmmmmmmmmmmm ");
      Console.WriteLine("");
      Console.WriteLine("                              MENU");
      Console.WriteLine("                            ________");
      Console.WriteLine("");    
      Console.WriteLine("                     Bread:  $5 (single loaf) ");  
      Console.WriteLine("                    Pastry:  $2 (single pastry) ");   
      Console.WriteLine("");
      Console.WriteLine("                            SPECIALS"); 
      Console.WriteLine("                           __________"); 
      Console.WriteLine("");
      Console.WriteLine("               Buy two loaves of bread, get one free!!");     
      Console.WriteLine("       Buy three pastries, receive third pastry at half price!!"); 

      int breadCost = BreadOrder();
      int pastryCost = PastryOrder();

      if (breadCost == 0 && pastryCost == 0)
      {
        Console.WriteLine("           Thanks for checking us out! Please come again!!");
      } 
      else
      {
        Console.WriteLine($"                      Your order total is ${breadCost + pastryCost}");
      }
    }

    private static int BreadOrder()
    {
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("           How many loaves of bread would you like today?");
      int loafCount = GetOrder();
      Bread breadOrder = new Bread(loafCount);
      int breadCost = breadOrder.Cost();
      return breadCost;
    }

    private static int PastryOrder()
    {
      Console.WriteLine("              How many pastries would you like today?");
      int pastryCount = GetOrder();
      Pastries pastryOrder = new Pastries(pastryCount);
      int pastryCost = pastryOrder.Cost();
      return pastryCost;
    }

    private static int GetOrder()
    {
      string userInput = Console.ReadLine();
      int order;
      bool canBeParsed = int.TryParse(userInput, out order);

      if (canBeParsed)
      {
        if(order < 0)
        {
          Console.WriteLine("               Please submit a number 0 or greater:");
          order = GetOrder();
          return order;
        }
        else 
        {
          return order;
        }
      }
      else
      {
        Console.WriteLine("      Non-number characters are not permitted. Please resubmit:");
        order = GetOrder();
        return order;
      }
    }
  }
}