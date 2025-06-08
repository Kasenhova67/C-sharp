using System.Text.Json;
public class Program
{
    public static async Task Main(string[] args)
    {
        List<Passenger> loadedPassengers = new List<Passenger>();
        try
        {
            string jsonData = await File.ReadAllTextAsync("Passenger.json");
            loadedPassengers = JsonSerializer.Deserialize<List<Passenger>>(jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении или десериализации файла: {ex.Message}");
            return;
        }

        IProgress<string> progress = new Progress<string>(message => Console.WriteLine(message));

        MemoryStream stream = new MemoryStream();
        StreamService<Passenger> service = new StreamService<Passenger>();

        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Начало работы");

        Task writeTask = Task.Run(()=>service.WriteToStreamAsync(stream, loadedPassengers, progress));
        await Task.Delay(100); // Задержка для гарантии последовательного запуска
        Task copyTask = service.CopyFromStreamAsync(stream, "output.txt", progress);

        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Методы WriteToStreamAsync и CopyFromStreamAsync запущены");

        await Task.WhenAll(writeTask, copyTask);

        int statistics = await service.GetStatisticsAsync("output.txt", p => {
            Console.WriteLine($"Проверка объекта: {JsonSerializer.Serialize(p)}");
            return p.HasLuggage;
        });
        Console.WriteLine($"Количество пассажиров с багажом: {statistics}");
    }
}
