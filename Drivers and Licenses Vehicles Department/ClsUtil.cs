using System;
using System.IO;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public class ClsUtil
    {
        private static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating folder: " + ex.Message, "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        private static string ReplaceFileNameWithGUID(string SourceFile)
        {
            FileInfo Fi = new FileInfo(SourceFile);
            string extn = Fi.Extension;
            return GenerateGUID() + extn;
        }

        public static bool CopyImageToProjectImageFolder(ref string SourceFile)
        {
            string DestinationFolder = @"C:\DVLD-People-Images\";

            // التحقق من إنشاء المجلد قبل الاستمرار
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            // التحقق من أن الملف المصدر موجود قبل محاولة نسخه
            if (!File.Exists(SourceFile))
            {
                MessageBox.Show("Error: The selected image file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string DestinationFile = Path.Combine(DestinationFolder, ReplaceFileNameWithGUID(SourceFile));

            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying file: " + ex.Message, "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFile = DestinationFile; 
            return true;
        }
    }
}
