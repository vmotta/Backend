using System;
using System.IO;
using System.Xml.Serialization;
using Biblioteca;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Biblioteca));
            using (var reader = new StreamReader("biblioteca.xml"))
            {
                var biblioteca = (Biblioteca)serializer.Deserialize(reader);

                foreach (var livro in biblioteca.Livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo}\nAutor: {livro.Autor}\nAno: {livro.Ano}\n");
                }
            }
        }
    }
}
