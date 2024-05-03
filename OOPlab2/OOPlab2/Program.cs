using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var urls = new List<string>
        {
            "https://api.hh.ru/openapi/redoc# ion/Obshaya-informaciya/Vybor-s",
             "https://en.wikipedia.org/wiki/Maqqqin_Page",
            "https://go.dev/tour/basics/16",qq
        };

        var Client = new HttpClient();
        var tasks = new List<Task<string>>();

        var start = DateTime.Now;

        foreach (var url in urls)
        {
            tasks.Add(GetResponse(Client, url));
        }

        var responses = await Task.WhenAll(tasks);

        foreach (var response in responses)
        {
            var jsonContent = JsonSerializer.Serialize(response);
            Console.WriteLine(response);
        }

        var finish = DateTime.Now;
        var totalTime = finish - start;
        Console.WriteLine($"Время выполнения: {totalTime}");
    }

    static async Task<string> GetResponse(HttpClient Client, string url)
    {
        try
        {
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"Ошибка получения данных {url}: {ex.Message}");
        }
    }
}