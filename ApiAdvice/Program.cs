using ApiAdvice.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    HashSet<string> adviceList = new HashSet<string>();
    
    for(int i = 0; i < 50; i++)
    {
        try
        {
            string json = await client.GetStringAsync("https://api.adviceslip.com/advice");
            var slip = JsonSerializer.Deserialize<ApiResponse>(json)!;

            if (slip != null && !adviceList.Contains(slip.Slip.Info))
            {
                Console.WriteLine($"♦ {slip.Slip.Info} ♦\n");
                adviceList.Add(slip.Slip.Info);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    Console.WriteLine($"Total of advices: {adviceList.Count}");   
}