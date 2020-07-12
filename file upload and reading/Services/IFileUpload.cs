using BlazorInputFile;
using file_upload_and_reading.Data;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace file_upload_and_reading.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
        Task UploadAsync2(IFileListEntry file);
        public List<Students> GetStudents();
        public List<Students2> GetStudents2s();
        public void GenerateExcel(IJSRuntime iJSRuntime);

    }
}
