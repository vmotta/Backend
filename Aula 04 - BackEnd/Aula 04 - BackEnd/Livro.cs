using System;
using System.Xml.Serialization;

/*  Instalação da Bilioteca System.Xml.XmlSerializer: dotnet add package System.Xml.XmlSerializer  */

namespace Biblioteca
{
    [Serializable]
    [XmlRoot("biblioteca")]
    public class Biblioteca
    {
        [XmlElement("livro")]
        public Livro[]? Livros { get; set; }
    }

    public class Livro
    {
        [XmlElement("titulo")]
        public string? Titulo { get; set; }

        [XmlElement("autor")]
        public string? Autor { get; set; }

        [XmlElement("ano")]
        public int Ano { get; set; }
    }
}
