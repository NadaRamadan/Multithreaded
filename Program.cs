namespace Multithreaded_file_processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var folderPath= @"\text files";
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            foreach (string file in files)
            {
                Thread t = new Thread(() => Proccess_file(file));
                t.Start();



            }
        }
        void Proccess_file(string filePath)
        {

        }

    }
}
