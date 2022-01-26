using System;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           List<String> items = new List<String>();
           bool isStillInUse = true;
           System.Console.WriteLine("Welcome to the Todo list");
           
           while(isStillInUse){
               Console.WriteLine("\n Add : to add new items to list \n Mark : to mark item from list \n Show : to display items in list \n quite: to stop program \n" );
               Console.Write("\n please enter command: ");
               string command = Console.ReadLine();
           switch(command.ToLower())
           {
               case "add":
                 System.Console.Write("enter text to be added to the list: ");
                 string input = Console.ReadLine();
                 items.Add(input);
                 Console.WriteLine("\n item add to todo list");
                 for(int i = 0; i < items.Count; i++)
                    {
                        int sn = i + 1;
                        System.Console.WriteLine("{0}. "+items[i], sn);
                    }
               break;
               case "show":
                if(items.Count == 0){
                   System.Console.WriteLine("\n PLEASE ADD ITEM TO THE TODO LIST");
                }else{
                   for(int i = 0; i < items.Count; i++)
                    {
                        int sn = i + 1;
                        System.Console.WriteLine("{0}. "+items[i], sn);
                    }
               }
               break;
               case "mark":
                System.Console.Write("\nEnter number of item to be marked: ");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                if(items.Count == 0){
                    System.Console.WriteLine("\n ADD ITEMS TO THE TODO LIST FIRST\n");
                }
                else if(index > items.Count - 1){
                    System.Console.WriteLine("\n ENTER ITEM IN LIST");
                }
                else if(items[index].Contains("[MARKED]")){
                    System.Console.WriteLine("LIST ITEM ALREADY MARKED");
                }
                else
                {
                    items[index] = items[index].Insert(0, "[MARKED] ");
                    System.Console.WriteLine("\n ITEM HAS BEEN MARKED");
                }
               break;
               case "quite":
                isStillInUse = false;
               break;
               default:
                System.Console.WriteLine("\nNOT A COMMAND");
               break;
           }
           
           }
        }
    }
}
