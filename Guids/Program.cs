using System;

namespace UsandoGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //forma correta de gerar um guid
            Console.WriteLine($"ID = {id}");
            id.ToString(); //transforma em uma string
            Console.WriteLine($"ID = {id}");

            //pode-se definir um guid especifico desde de que esteja no padrão
            id = new Guid("53c058f8-aa5f-4780-b9f5-9d5abf5305ff");
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"ID = {id.ToString().Substring(0, 8)}");

            id = new Guid(); //desta forma gera zerado
            Console.WriteLine($"ID = {id.ToString().Substring(0, 8)}");
        }
    }
}