using System.Net.Http;
using (HttpClient client = new HttpClient()) 
{
    string resposta = await client.GetStringAsync("https://api.cs2data.gg/skins");
}