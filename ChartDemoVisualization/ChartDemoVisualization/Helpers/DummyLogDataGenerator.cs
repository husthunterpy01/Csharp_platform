using ChartDemoVisualization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartDemoVisualization.Helpers
{
    public class DummyLogDataGenerator
    {
        private static readonly string[] Events = { "UserLogin", "DataFetch", "DataSave", "UserLogout", "CacheUpdate" };
        private static readonly string[] Categories = { "Authentication", "DataService", "CacheService" };
        private static readonly string[] LogLevels = { "INFO", "WARN", "ERROR" };
        private static Random random = new Random();

        private List<DummyLogData> GenerateSampleLogs(int noOfLogs)
        {
            var listLogData = new List<DummyLogData>();
            for (int i = 0; i <= noOfLogs; i++)
            {
                listLogData.Add(
                    new DummyLogData()
                    {
                        TimeStamp = DateTime.Now.AddDays(i),
                        Event = Events[random.Next(Events.Length)],
                        Category = Categories[random.Next(Categories.Length)],
                        LogLevel = LogLevels[random.Next(LogLevels.Length)],
                        Value = random.NextDouble() * 100,
                        UserId = $"U{random.Next(10000, 99999)}"
                    }
                    );
            }
            return listLogData;
        }

        private void WriteLogToDirectory(List<DummyLogData> listLogs, string dataDirectory)
        {
            // Ensure the directory exists
            Directory.CreateDirectory(dataDirectory);

            // Define file path
            string filePath = Path.Combine(dataDirectory, "chart_logs.csv");

            // Check if the file already exists
            if (File.Exists(filePath))
            {
                // Show a message box to notify the user
                MessageBoxResult result = MessageBox.Show(
                    "The file 'chart_logs.csv' already exists. Do you want to overwrite it?",
                    "File Exists",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning
                );

                if (result == MessageBoxResult.No)
                {
                    // If user chooses not to overwrite, exit the method
                    Console.WriteLine("Operation cancelled by user.");
                    return;
                }

            }
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Timestamp,Event,Category,LogLevel,Value,UserID");
                foreach (var log in listLogs)
                {
                    writer.WriteLine($"{log.TimeStamp:yyyy-MM-dd HH:mm:ss},{log.Event},{log.Category},{log.LogLevel},{log.Value:F2},{log.UserId}");
                }
            }

            if (File.Exists(filePath))
            {
                MessageBox.Show("File generated successfully");
            }
        }


    }
}
