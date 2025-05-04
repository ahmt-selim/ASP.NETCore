using IocContainer.Services.Interfaces;
using System;

namespace IocContainer.Services
{
    public class TextLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("Dosyaya yazılan mesaj: " + message);
        }
    }
}
