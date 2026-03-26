using Orange_Skins_Project.Modelos;
using System.Net.Http;
using System.Text.Json;


using (HttpClient client = new HttpClient()) 
{
    try 
    {
        string resposta = await client.GetStringAsync("https://api.cs2data.gg/#google_vignette");
        Skins skins = new Skins();

        var skins = JsonSerializer.Deserialize(<List<Skins>>)(resposta);

    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro ao consultar {ex.Message}"); 
    }



}