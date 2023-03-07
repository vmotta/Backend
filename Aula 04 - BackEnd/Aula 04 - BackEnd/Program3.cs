using System;
using System.Net.Http;
using System.Threading.Tasks;

/* O JavaScript XMLHttpRequest (XHR) não pode ser usado diretamente em um projeto C# no Visual Studio Code,
 pois é uma tecnologia usada no lado do cliente (frontend) para fazer requisições HTTP assíncronas.
 Em vez disso, é possível usar a classe HttpClient da biblioteca System.Net.Http para realizar requisições HTTP
  no lado do servidor (backend) em C#.

Segue um exemplo de como usar a classe HttpClient para fazer uma requisição HTTP GET em uma API
e exibir a resposta no console:
*/

namespace ExemploHttpRequest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Erro ao fazer a requisição HTTP: {ex.Message}");
                }
            }
        }
    }
}

/*
Nesse exemplo, estamos fazendo uma requisição HTTP GET para a API "https://jsonplaceholder.typicode.com/todos/1"
e exibindo a resposta no console. Para isso, estamos criando uma instância da classe HttpClient,
usando o método GetAsync para fazer a requisição, e o método ReadAsStringAsync para obter o conteúdo da resposta
como uma string. Estamos também usando o método EnsureSuccessStatusCode para verificar se a resposta tem um código
de status de sucesso (200-299).
*/