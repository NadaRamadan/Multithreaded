

## 📄  Multi-threaded File Word Counter

A simple C# console application that uses **multiple threads** to count the number of words in each `.txt` file within a specified directory. This project demonstrates practical use of the `Thread` class for parallel file processing.

---

### 🚀 Features

* Scans a folder for `.txt` files
* Spawns a separate thread for each file
* Counts words in each file without blocking the main thread
* Displays results as threads complete
* Handles file read errors gracefully
* Thread-safe console output

---

### 🧠 Concepts Practiced

* `System.Threading.Thread`
* Lambda expressions to pass parameters to threads
* File reading with `System.IO`
* Word counting logic
* Thread-safe output using `lock`

---

### 🛠️ How It Works

1. The program prompts the user to specify a folder path or uses the hardcoded path.
2. It fetches all `.txt` files from the folder.
3. For each file, it creates a new `Thread` that:

   * Reads the file
   * Counts the words
   * Prints the filename and word count

---

### 🧪 Example Output

```
📁 Found 3 files. Starting threads...

✔ File: report.txt - Word Count: 431
✔ File: summary.txt - Word Count: 298
✔ File: notes.txt - Word Count: 112
```

---

### 📁 Folder Structure

```
📁 MultiThreadedFileProcessor/
├── Program.cs
├── README.md
└── SampleFiles/
    ├── file1.txt
    ├── file2.txt
    └── file3.txt
```

---

### 📦 Requirements

* .NET SDK 6.0 or higher
* Windows or any OS with .NET support
* C# IDE (e.g., Visual Studio, Rider) or simple text editor + CLI

---

### 🔄 How to Run

1. Create a folder named `C:\TextFiles` (or change the path in the code).
2. Add `.txt` files with text content.
3. Run the project:

```bash
dotnet run
```

---

### ✅ Possible Improvements

* Limit max threads with `Semaphore`
* Add logging or save results to a file
* Use `ThreadPool` for more efficiency
* Add GUI (e.g., WinForms or WPF)

---

