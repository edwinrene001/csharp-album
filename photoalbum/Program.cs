using System;
using System.Net.Http;
using System.Threading.Tasks;

HttpClient client = new HttpClient();

try
{
    string albumId = "2"; // Change this to the albumId you want to fetch.

    HttpResponseMessage response = await client.GetAsync($"https://jsonplaceholder.typicode.com/photos?albumId={albumId}");

    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();

    Console.WriteLine(responseBody);
}

catch (HttpRequestException e)
{
    Console.WriteLine($"\nException Caught!");
    Console.WriteLine($"Message: {e.Message}");
}