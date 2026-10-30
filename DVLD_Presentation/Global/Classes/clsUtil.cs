using DVLD_Presentation.Global.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Global_Classes
{
    internal static class clsUtil
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                }
                catch (IOException iox)
                {
                    clsMessageBox.ShowError($"Error creating folder: {iox.Message}");
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string FileName)
        {
            FileInfo fileInfo = new FileInfo(FileName);

            return GenerateGUID() + fileInfo.Extension;
        }

        public static bool CopyImageToProjectImagesFolder(ref string SourceFile)
        {
            string DestinationFolder = @"C:\Users\User\Downloads\DVLD-People-Images\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (IOException iox)
            {
                clsMessageBox.ShowError(iox.Message);
                return false;
            }

            SourceFile = DestinationFile;

            return true;
        }

        public static bool DeleteImageFromProjectImagesFolder(string ImagePath)
        {
            try
            {
                File.Delete(ImagePath);
            }
            catch (IOException iox)
            {
                clsMessageBox.ShowError($"Error: {iox.Message}");
                return false;
            }

            return true;
        }


        private static string _LoginFileName = "Login.txt";
        private static string _Separator = "#//#";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string LoginFilePath = CurrentDirectory + $"\\{_LoginFileName}";

                if (string.IsNullOrEmpty(Username))
                {
                    if (File.Exists(LoginFilePath))
                        File.Delete(LoginFilePath);
                    return true;
                }
                
                string Line = Username + _Separator + Password;
                
                using (StreamWriter writer = new StreamWriter(LoginFilePath))
                {
                    writer.WriteLine(Line);
                }

                return true;
            }
            catch (IOException iox)
            {
                clsMessageBox.ShowError(iox.Message);
                return false;
            }
        }

        public static bool GetStoredCredentials(ref string Username, ref string Password)
        {
            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string LoginFilePath = CurrentDirectory + $"\\{_LoginFileName}";

                if (File.Exists(LoginFilePath))
                {
                    using (StreamReader reader = new StreamReader(LoginFilePath))
                    {
                        string Line = "";

                        if ((Line = reader.ReadLine()) != null)
                        {
                            string[] Credentials = Line.Split(new string[] { _Separator }, StringSplitOptions.None);

                            Username = Credentials[0];
                            Password = Credentials[1];

                        }

                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (IOException iox)
            {
                clsMessageBox.ShowError(iox.Message);
                return false;
            }
        }

        public static string DateToString(DateTime Date)
        {
            return clsFormat.DateToString(Date);
        }

    }
}
