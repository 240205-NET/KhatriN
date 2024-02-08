using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte;
          sbyte mySbyte;
          int myInt=10;
          uint myUint;
          short myShort;
          ushort myUShort;
          float myFloat;
          double myDouble;
          char myCharacter;
          bool myBool;
          string myText="I Control text";
          string numText= "50";
          Console.WriteLine(Text2Num(numText));
      }

      public static int Text2Num(string numText)
      {
        int num = Int32.Parse(numText);
        return num;
        //throw new NotImplementedException();
      }
    }
}
