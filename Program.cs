using System.Net.Http;


using (HttpClient client = new HttpClient()) 
{
    try 
    {
        string resposta = await client.GetStringAsync("https://api.cs2data.gg/#google_vignette");
        Console.WriteLine(resposta);

    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro ao consultar {ex.Message}"); 
    }
}