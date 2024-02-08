using System.Xml.Serialization;
using System.IO;

namespace Serializer{
    public class Person{
        //fields
        public string? name { get; set; }
        public double? height { get; set; }
        public int? age{ get; set; } 
        private XmlSerializer serializer = new XmlSerializer(typeof(Person));
        static string path = @"./NewTextFile.txt";
        //construtor
        //Zero parameter Constructor
        public Person(){}
        //Null Parameter Constructor
        public Person(string? name, double? height, int? age){

            this.name = name;
            this.height = height;
            this.age = age;
        }
        //Default value parameter constructor
        public Person(string name="", double height=50, int age=10){

            this.name = name;
            this.height = height;
            this.age = age;
        }
        //Methods
        public string SerializeXML(){
            var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();
        }

        public void WriteSerializeXmlToFile(){
            string[] serializeText = {this.SerializeXML()};
            if(File.Exists(path)){
                Console.WriteLine("Serialize Successfull");
                File.WriteAllLines(path, serializeText);
            }
        }
        public string ToString(){
            var result = new System.Text.StringBuilder();
            result.AppendLine($"Name: {this.name} \t Heigt:{this.height} in. \t{this.age}");
           return result.ToString();
        }

        public void WriteToFile(){
            Console.WriteLine("Please Enter the text input to Write to a file");
            string[] inputText = {Console.ReadLine()};
            if(File.Exists(path)){
                Console.WriteLine("File Exists !! Although you text will be added to same file");
                File.AppendAllLines(path, inputText);
                
            }else{
                Console.WriteLine("New Files Created ");
                File.WriteAllLines(path, inputText);
            }
        }   

        public void ReadFromFile(){
            if(File.Exists(path)){
                string[] readText = File.ReadAllLines(path);
                foreach(string s in readText){
                    Console.WriteLine(s);
                }
            }else{
                Console.WriteLine("No file Found");
            }
        }


        public void Deserialization(){
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            if(!File.Exists(path)){
                Console.WriteLine("File not Found");
            }else{
                using StreamReader reader = new StreamReader(path);
                var record = serializer.Deserialize(reader);
                if(record is null){
                    throw new InvalidDataException();
                }
                Console.WriteLine(record);
            }
        } 


    }
}