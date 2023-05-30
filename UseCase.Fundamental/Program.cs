using UseCase.Entity;
using UseCase.Service;

public class Program
{
    public static void Main(String[] args)
    {
        Audience audience= new Audience();

        IAudienceService audienceService= new AudienceService();
        Console.WriteLine("Info from Inteface = {0}", audienceService.GetInfo());
        var listAudience = audienceService.GetInfo();

        foreach (Audience index in listAudience)
        {
            Console.WriteLine($"ID: {index.Id}, Name: {index.Name}, Description: {index.SeatNumber}");
        }

        Console.ReadLine();
    }
}
