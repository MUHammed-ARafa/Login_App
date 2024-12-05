using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.DirectoryServices;

namespace Login_App
{
    internal class DataFile
    {
        public static string dataPath = Application.StartupPath + @"\UsersData.txt";
        public static string currecntUserDataPath = Application.StartupPath + @"\CurrentUser.txt";
        public static List<Dictionary<string, string>> readUsersData(string path)
        {
            List<Dictionary<string, string>> usersData = new();
            Dictionary<string, string> user = new();
            StreamReader sr = new(path);
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                {
                    usersData.Add(new Dictionary<string, string>(user)); // usersData.Add(user)
                    user.Clear();
                }
                else
                {
                    string[] keyAnVal = line.Split(':');
                    user.Add(keyAnVal[0].Trim(), keyAnVal[1].Trim());
                }
            }
            sr.Close();
            return usersData;
        }
        public static void writeData(string fName, string lName, string email, string pass, string gender, string phone, string path)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine($"First Name: {fName}");
            writer.WriteLine($"Last Name: {lName}");
            writer.WriteLine($"Email: {email}");
            writer.WriteLine($"Password: {pass}");
            writer.WriteLine($"Gender: {gender}");
            writer.WriteLine($"Phone NO: {phone}");
            writer.WriteLine();
            writer.Close();
        }
    }
}
