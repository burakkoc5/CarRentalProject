﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            //Creates safe area
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0 && file !=null)
            {
                using (FileStream stream = new FileStream(sourcepath, FileMode.Create))
                {
                    //File copied to safe area
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            //File moved to real directory
            File.Move(sourcepath, result);
            return result;
        }


        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
        private static string newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;
            if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".jpeg")
            {
                string path = Environment.CurrentDirectory + @"wwwroot\Images";
                var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

                string result = $@"{path}\{newPath}";
                return result;

            }

            throw new Exception("Dosya uzantısı jpeg,png veya jpg olmak zorundadır.");
            
        }
    }
}