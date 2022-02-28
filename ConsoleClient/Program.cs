using System;
using Newtonsoft.Json;

namespace MyMassenger
{
    [Serializable]
    class Programm
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //Console.WriteLine("Начало проекта!");
            //Console.WriteLine(msg.ToString());
        }
    }
}
