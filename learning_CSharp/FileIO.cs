using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    static class FileIO
    {
        // ✅ 1. প্রজেক্ট রুট ডিরেক্টরি বের করা
        public static string GetPath()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo? parentDir = Directory.GetParent(currentDir);
            if (parentDir?.Parent?.Parent == null)
            {
                Console.WriteLine("Unable to determine the project directory.");
                return "";
            }
            return parentDir.Parent.Parent.FullName;
        }


        // ✅ 2. ফোল্ডার তৈরি (যদি না থাকে)
        public static string CreateDir(string basePath, string name)
        {
            string dirPath = Path.Combine(basePath, name);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
                Console.WriteLine($"Folder created: {name}");
            }
            return dirPath;
        }

        // ✅ 3. ফাইলে লেখা
        public static void WriteToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine("File written successfully.");
        }

        // ✅ 4. ফাইলে অ্যাপেন্ড করা
        public static void AppendToFile(string filePath, string content)
        {
            File.AppendAllText(filePath, content + Environment.NewLine);
            Console.WriteLine("Content appended to file.");
        }

        // ✅ 5. ফাইল থেকে ডেটা পড়া
        public static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Content:\n" + content);
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }

        // ✅ 6. ফাইল লাইন বাই লাইন পড়া
        public static void ReadLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("File lines:");
                foreach (string line in lines)
                {
                    Console.WriteLine("- " + line);
                }
            }
        }

        // ✅ 7. সব ফাইল দেখানো নির্দিষ্ট ফোল্ডারে
        public static void ShowFiles(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("Files in " + dirPath);
                string[] files = Directory.GetFiles(dirPath);
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
        }

        // ✅ 8. ফাইল ডিলিট করা
        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted: " + filePath);
            }
            else
            {
                Console.WriteLine("File not found to delete.");
            }
        }

        // ✅ 9. Execute method — সব কিছু একসাথে চালানো
        public static void Execute()
        {
            string projectDir = GetPath();
            string assetsDir = CreateDir(projectDir, "Assets");

            string filePath = Path.Combine(assetsDir, "myfile.txt");

            // ইউজার ইনপুট নিয়ে লেখা
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string content = $"Hello, {name}!";
            WriteToFile(filePath, content);

            // নতুন লাইন অ্যাপেন্ড
            AppendToFile(filePath, $"Today is: {DateTime.Now}");

            // রিড
            ReadFile(filePath);

            // লাইন বাই লাইন
            ReadLines(filePath);

            // ফোল্ডারে সব ফাইল দেখাও
            ShowFiles(assetsDir);

            // আপনি চাইলে ফাইল ডিলিট করতে পারেন নিচের লাইন আনকমেন্ট করে
             //DeleteFile(filePath);
        }
    }
}
