namespace Multithreaded_file_processor
{
    internal class Program

    {
        static object consolelock = new object();
        static void Main(string[] args)
        {
            var folderPath = @"\text files";
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            if (!Directory.Exists(folderPath))
            {
                return;

            }
            Console.WriteLine($"Found {files.Length} files. Starting threads...\n");


            foreach (string file in files)
            {
                Thread t = new Thread(() => Proccess_file(file));
                t.Start();



            }
        }
        static void Proccess_file(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                int word_count = CountWords(content);

                lock (consolelock)
                {
                    Console.WriteLine($"File: {Path.GetFileName(filePath)},wordCount: {word_count}");

                }

            }
            catch (Exception ex)
            {
                lock (consolelock)
                {
                    Console.WriteLine($"File: {Path.GetFileName(filePath)} : {ex.Message}");

                }

            }


        }
        static int CountWords(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return 0;
            }

            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;    

        }
    }
}
