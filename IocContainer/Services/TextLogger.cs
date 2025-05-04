using IocContainer.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Text;

namespace IocContainer.Services
{
    public class TextLogger : ILog
    {
        public TextLogger(IHostEnvironment env)
        {
            try
            {
                string date = DateTime.Now.ToString("d-M-yyyy");
                path = $"{env.ContentRootPath}/Logs/{date}.txt";//env.ContentRootPath projenin ana dizinini verir.
                if (!File.Exists(path))
                {
                    using (File.Create(path))
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        string path;
        public void Info(string message)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true, Encoding.UTF8))
                {
                    string time = DateTime.Now.ToString("HH:mm");
                    stream.WriteLine($"##INFO## &&{time}&& || message: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
