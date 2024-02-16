using System;
using System.IO;

namespace Serializer{
    public class Program  {
       public static void Main(string[] args){
         // confirm the app is running
        Console.WriteLine("Serializer running.");
        
       Menu();
       }

       public static void Menu(){
        Person p = new Person("Nabin", 5, 33);
        
        int counter = 1;
        bool flag = false;
        bool loop = true;
        while(loop){
            Console.WriteLine("Input 1 to Write Something to File");
            Console.WriteLine("Input 2 to Read Something to File");
            Console.WriteLine("Input 3 to Serialize to XML, and write to the file");
            Console.WriteLine("Input 4 to Read from XML");
            Console.WriteLine("Input Any other Number to Exit");
            string num = Console.ReadLine();
           // if(flag){
                switch(num){
                    case "1":
                        p.WriteToFile();
                        break;
                    case "2": 
                        p.ReadFromFile();
                        break;
                    case "3":
                        p.WriteSerializeXmlToFile();
                        break;
                    case "4":
                        p.Deserialization();
                        break;
                    default:
                        loop=false;
                        Console.WriteLine("You are out of Program");
                        break;   
                } 
        }

       }
    }
}