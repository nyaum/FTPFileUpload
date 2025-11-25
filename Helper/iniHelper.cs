using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FTPFileUpload.Helper
{
    internal class iniHelper
    {

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static void SetValue(string path, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        public static string GetValue(string path, string Section, string Key, string Default)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, Default, temp, 255, path);
            if (temp != null && temp.Length > 0) return temp.ToString();
            else return Default;
        }

        public static bool iniInit(string q, string w, string e, string r, bool remember)
        {

            //ini파일 경로 지정
            string iniPath = Application.StartupPath + @"\config.ini";

            //저장하기

            // [Connection]
            SetValue(iniPath, "Connection", "IP", q);
            SetValue(iniPath, "Connection", "Port", w);
            SetValue(iniPath, "Connection", "ID", e);
            SetValue(iniPath, "Connection", "Password", r);
            SetValue(iniPath, "Connection", "Remember", remember.ToString());


            return true;
        }

        public static List<string> GetIniData()
        {
            string iniPath = Application.StartupPath + @"\config.ini";

            // ini 파일이 없으면 생성
            if (!File.Exists(iniPath)) 
            {

                iniInit("", "", "", "", false);

            }

            string pubData1 = GetValue(iniPath, "Connection", "IP", "");
            string pubData2 = GetValue(iniPath, "Connection", "Port", "");
            string pubData3 = GetValue(iniPath, "Connection", "ID", "");
            string pubData4 = GetValue(iniPath, "Connection", "Password", "");
            string pubDate5 = GetValue(iniPath, "Connection", "Remember", "");

            List<string> list = new List<string>();

            list.Add(pubData1);
            list.Add(pubData2);
            list.Add(pubData3);
            list.Add(pubData4);
            list.Add(pubDate5);

            return list;
        }

    }
}
