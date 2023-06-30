using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        public string Upload(IFormFile file,string rootPath);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string rootPath);
    }
}
