# Images to PDF Converter

A high-performance **C#/.NET Console Application** that recursively converts image collections into PDF documents while preserving image quality and optimizing file size. The application automatically extracts ZIP archives, compresses images intelligently, and generates detailed processing logs, making it ideal for handling large batches of scanned documents, invoices, reports, and image archives.

---

## ✨ Features

- 📁 Recursively scans nested folders for images.
- 📦 Automatically extracts ZIP archives before processing.
- 🖼️ Supports multiple image formats:
  - JPG / JPEG
  - PNG
  - WebP
- 📄 Creates one PDF for each image folder.
- 🗜️ Smart image compression using **SkiaSharp**.
- ⚙️ Supports custom JPEG quality or automatic quality adjustment based on image size.
- 📐 Automatically resizes oversized images while maintaining aspect ratio.
- 📂 Preserves the original folder hierarchy in the output directory.
- 📝 Generates detailed processing logs with timestamps.
- 🔄 Skips already generated PDFs to avoid duplicate processing.
- 🧹 Automatically deletes extracted ZIP files after successful processing.
- ⚠️ Includes retry mechanisms for file deletion and folder cleanup.

---

## 🚀 Technologies Used

- C#
- .NET
- iText 7
- SkiaSharp
- System.IO.Compression

---

## 📂 Project Structure

```
ImagesToPdf
│
├── Program.cs
├── OutputPDFs/
├── Process.log
└── ImagesToPdf.csproj
```

---

## 📥 Supported Input Formats

- `.jpg`
- `.jpeg`
- `.png`
- `.webp`
- `.zip` (Automatically extracted)

---

## 💻 Command Line Usage

```bash
ImagesToPdf.exe --input "C:\InputFolder" --output "C:\OutputFolder" --quality 90 --overRideQuality true
```

### Parameters

| Parameter | Description | Required |
|-----------|-------------|----------|
| `--input` | Root folder containing images or ZIP files | ✅ |
| `--output` | Output directory for generated PDFs | ❌ |
| `--quality` | JPEG compression quality (1-100) | ❌ |
| `--overRideQuality` | Use specified quality (`true`) or automatic quality (`false`) | ❌ |

If no output directory is provided, the application automatically creates an **OutputFolder** next to the input directory.

---

## 📁 Example Folder Structure

### Input

```
InputFolder
│
├── Customer1
│   ├── IMG001.jpg
│   ├── IMG002.png
│
├── Customer2
│   ├── Photo1.webp
│   ├── Photo2.jpg
│
└── Archive.zip
```

### Output

```
OutputFolder
│
├── OutputPDFs
│   ├── Customer1.pdf
│   ├── Customer2.pdf
│   └── Archive.pdf
│
└── [DD-MM-YYYY HH-MM-SS] Process.log
```

---

## ⚙️ How It Works

1. Scans the input directory recursively.
2. Detects and extracts ZIP archives.
3. Searches for supported image files.
4. Compresses and resizes images when required.
5. Generates one PDF per image folder.
6. Writes detailed processing information to a log file.
7. Cleans up extracted ZIP folders and temporary files.

---

## 📈 Performance Highlights

- Efficient recursive folder traversal.
- Optimized memory usage.
- Automatic image resizing for large images.
- Reduced PDF size through intelligent JPEG compression.
- Retry logic for file and directory operations.
- Skips PDFs that have already been generated.

---

## 📸 Image Optimization

The application uses **SkiaSharp** to optimize images before adding them to the PDF.

When **`--overRideQuality false`** is specified:

- Images larger than **1 MB** → Quality **60**
- Images between **500 KB – 1 MB** → Quality **70**
- Smaller images → Quality **75**

When **`--overRideQuality true`** is specified, the application uses the value provided via the `--quality` parameter.

---

## 📝 Logging

Every execution generates a timestamped log file containing:

- Application start/end
- Folder traversal
- ZIP extraction status
- PDF creation progress
- Image processing progress
- Errors and exceptions

Example:

```
[12-07-2026 10-30-15 PM] - APPLICATION START
[12-07-2026 10-30-17 PM] - 25 images found for Customer1.pdf
[12-07-2026 10-30-22 PM] - PDF created successfully
[12-07-2026 10-30-23 PM] - APPLICATION END
```

---

## 🎯 Use Cases

- Bulk image-to-PDF conversion
- Invoice archiving
- Scanned document digitization
- Image archive processing
- Document management systems
- Report generation
- Automated batch PDF creation

---

## 📄 License

This project is available under the **MIT License**. Feel free to use, modify, and distribute it for personal or commercial purposes.

---

## 👨‍💻 Author

**Ronak Vaghela**

.NET Developer | C# | ASP.NET Core | ASP.NET Core MVC | ASP.NET Core Web API / CI/CD | SQL Server | JavaScript
