// FILE: MemoryStreamExtensions.cs
// PROJECT: SWH.Extensions
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-17
// DATE MODIFIED: 2021-05-17

namespace SWH.Extensions.Streams
{
    using System;
    using System.IO;
    using System.Text;

    public static class MemoryStreamExtensions
    {
        private static readonly object streamLock = new object();

        public static void WriteLine(this MemoryStream memoryStream, string text, bool flush)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text + Environment.NewLine);
            lock (streamLock)
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                if (flush)
                {
                    memoryStream.Flush();
                }
            }
        }

        public static void WriteLine(this MemoryStream memoryStream, string formatString, bool flush, params object[] strings)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(string.Format(formatString, strings) + Environment.NewLine);
            lock (streamLock)
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                if (flush)
                {
                    memoryStream.Flush();
                }
            }
        }

        public static void WriteToConsole(this MemoryStream memoryStream)
        {
            lock (streamLock)
            {
                long temporary = memoryStream.Position;
                memoryStream.Position = 0;
                using (var reader = new StreamReader(memoryStream, Encoding.Unicode, false, 0x1000, true))
                {
                    string text = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(text) == false)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}