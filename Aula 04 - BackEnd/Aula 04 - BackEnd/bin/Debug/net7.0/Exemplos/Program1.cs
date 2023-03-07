using System;
using System.Xml;
using Newtonsoft.Json;

/*
Para ler um arquivo XML e salvá-lo em formato JSON usando C# no Visual Studio Code, você pode seguir estes passos:

Crie um novo projeto do tipo "Console Application" no Visual Studio Code com o comando dotnet new console.
Certifique-se de ter o SDK do .NET Core instalado no seu computador.

Adicione as bibliotecas necessárias para trabalhar com XML e JSON.
Para isso, você pode utilizar o gerenciador de pacotes do NuGet.
No terminal do Visual Studio Code, execute o seguinte comando:

dotnet add package System.Xml
dotnet add package Newtonsoft.Json
*/

class Program
{
    static void Main(string[] args)
    {
        // Lê o arquivo XML
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("Biblioteca.xml");

        // Converte para JSON
        string json = JsonConvert.SerializeXmlNode(xmlDoc);

        // Salva em um arquivo JSON
        System.IO.File.WriteAllText(@"Biblioteca.json", json);

        Console.WriteLine("Arquivo convertido com sucesso!");
    }
}

/*
No código acima, substitua "exemplo.xml" pelo caminho do seu arquivo XML e "exemplo.json" 
pelo nome que você deseja dar ao arquivo JSON de saída.

Execute o comando dotnet run no terminal para executar o programa. Ele lerá o arquivo XML,
converterá para JSON e salvará em um arquivo com o nome especificado.

Com esses passos, você terá um programa C# que lê um arquivo XML e salva em formato JSON.
*/