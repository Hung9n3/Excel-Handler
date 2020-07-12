using BlazorInputFile;
using ExcelDataReader;
using file_upload_and_reading.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace file_upload_and_reading.Services
{
    public class FileUpload : IFileUpload
    {
        public List<Students2> students2 = new List<Students2>();
        public List<Students> students = new List<Students>();
        public List<Result> Results = new List<Result>();

        public string path { get; set; }
        public string path2 { get; set; }

        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            path = Path.Combine(_environment.ContentRootPath, "Upload", fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
        public List<Students> GetStudents()
        {
            var fileName = path;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        students.Add(new Students()
                        {
                            Name = reader.GetValue(0).ToString(),
                            Role = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString()
                        });
                    }
                }
                return students;
            }
        }

        public List<Students2> GetStudents2s()
        {
            var fileName = path2;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        students2.Add(new Students2()
                        {
                            Name = reader.GetValue(0).ToString(),
                            Role = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString()
                        });
                    }
                }
                return students2;
            }
        }
        public async Task UploadAsync2(IFileListEntry fileEntry)
        {
            path2 = Path.Combine(_environment.ContentRootPath, "Upload", fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path2, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
        public void Combine()
        {
          for(int i = 0;i+1 <= students.Count(); i++)
            {
                Results.Add(new Result()
                {
                    Name = students[i].Name + students2[i].Name,
                    Role = students[i].Role + students2[i].Role,
                    Email = students[i].Email + students2[i].Email
                });
            }
        }
        public void GenerateExcel(IJSRuntime iJSRuntime)
        {
            Combine();
            byte[] fileContents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                int n = Results.Count();
                for(int i = 0; i + 1 <= n; i++)
                {
                    
                    
                        workSheet.Cells[i + 1, 1].Value = Results[i].Name;
                        workSheet.Cells[i + 1, 2].Value = Results[i].Role;
                        workSheet.Cells[i + 1, 3].Value = Results[i].Email;
                        workSheet.Cells[i + 1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                        workSheet.Cells[i + 1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                        workSheet.Cells[i + 1, 3].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                        workSheet.Cells[i + 1, 1].Style.Font.Size = 12;
                        workSheet.Cells[i + 1, 2].Style.Font.Size = 12;
                        workSheet.Cells[i + 1, 3].Style.Font.Size = 12;
                    
                }
                fileContents = package.GetAsByteArray();
            }
            iJSRuntime.InvokeAsync<FileUpload>(
              "saveAsFile",
              "Student List.xlsx",
              Convert.ToBase64String(fileContents)
              );
        }
    }
}
