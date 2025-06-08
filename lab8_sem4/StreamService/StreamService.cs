
using System.Text.Json;

public class StreamService<T>
{
    private readonly object _syncLock = new object();

    public async Task WriteToStreamAsync(Stream stream, IEnumerable<T> data, IProgress<string> progress)
    {
        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Вход в метод WriteToStreamAsync");

        await Task.Delay(3000); // Задержка для имитации медленной записи

        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Начало записи в поток");

        using (StreamWriter writer = new StreamWriter(stream, leaveOpen: true))
        {
            foreach (var item in data)
            {
                string serializedItem = JsonSerializer.Serialize(item);
                await writer.WriteLineAsync(serializedItem);
                progress.Report($"Записан объект: {serializedItem}");
            }
        }

        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Завершение записи в поток");
    }


    public async Task CopyFromStreamAsync(Stream stream, string fileName, IProgress<string> progress)
    {
        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Вход в метод CopyFromStreamAsync");

        await Task.Delay(3000); // Задержка для имитации медленного копирования

        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Начало копирования из потока");

        stream.Position = 0; // Устанавливаем позицию потока в начало

        using (StreamReader reader = new StreamReader(stream))
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                await writer.WriteLineAsync(line);
                progress.Report($"Скопирована строка: {line}");
            }
        }

        progress.Report($"Поток {Thread.CurrentThread.ManagedThreadId}: Завершение копирования из потока");
    }


    public async Task<int> GetStatisticsAsync(string fileName, Func<T, bool> filter)
    {
        int count = 0;

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                try
                {
                    T item = JsonSerializer.Deserialize<T>(line);
                    Console.WriteLine($"Десериализован объект: {JsonSerializer.Serialize(item)}");

                    if (filter(item))
                    {
                        count++;
                        Console.WriteLine($"Объект прошел фильтр: {JsonSerializer.Serialize(item)}");
                    }
                    else
                    {
                        Console.WriteLine($"Объект НЕ прошел фильтр: {JsonSerializer.Serialize(item)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при десериализации: {ex.Message}");
                }
            }
        }

        return count;
    }


}

