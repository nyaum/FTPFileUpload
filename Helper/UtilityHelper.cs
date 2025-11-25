using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FTPFileUpload.Helper
{
    public class UtilityHelper
    {
        public static string GetNowDate()
        {
            string Rtn = "";

            Rtn = DateTime.Now.ToString();

            return Rtn;
        }

        /// <summary>
        /// <para>DateTime Formatter</para>
        /// <para>format 1 : yyyy-MM-dd</para>
        /// <para>format 2 : yyyy-MM-dd HH:mm:ss</para>
        /// <para>format 3 : yyyy-MM-dd dddd HH:mm:ss</para>
        /// <para>format 4 : yyyy-MM-dd tt hh:mm:ss</para>
        /// <para>format 5 : yyyy</para>
        /// <para>format 6 : yyyy년 MM월 dd일</para>
        /// <para>format 7 : yyyyMMddHHmmss</para>
        /// <para>format 8 : DateTime Differ</para>
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string DateTimeFormat(string date, int format)
        {
            string Rtn = "";


            if (date != "" && date != null)
            {

                DateTime dt = Convert.ToDateTime(date);

                switch (format)
                {
                    case 1:
                        Rtn = string.Format("{0:yyyy-MM-dd}", dt);
                        break;
                    case 2:
                        Rtn = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
                        break;
                    case 3:
                        Rtn = string.Format("{0:yyyy-MM-dd dddd HH:mm:ss}", dt);
                        break;
                    case 4:
                        Rtn = string.Format("{0:yyyy-MM-dd tt hh:mm:ss}", dt);
                        break;
                    case 5:
                        Rtn = string.Format("{0:yyyy}", dt);
                        break;
                    case 6:
                        Rtn = string.Format("{0:yyyy년 MM월 dd일}", dt);
                        break;
                    case 7:
                        Rtn = string.Format("{0:yyyyMMddHHmmss}", dt);
                        break;
                    case 8:
                        Rtn = string.Format("{0:yyMMdd}", dt);
                        break;
                    case 9:

                        TimeSpan dateDiff = Convert.ToDateTime(GetNowDate()) - dt;

                        double diffDay = dateDiff.Days;

                        double diffMonth = Math.Truncate(diffDay / 30);

                        double diffYear = Math.Truncate(diffMonth / 12);

                        double diffHour = dateDiff.Hours;
                        double diffMinute = dateDiff.Minutes;
                        double diffSecond = dateDiff.Seconds;

                        if (diffYear > 0)
                        {
                            Rtn = string.Format("{0}년 전", diffYear);
                            break;
                        }

                        if (diffMonth > 0)
                        {
                            Rtn = string.Format("{0}달 전", diffMonth);
                            break;
                        }

                        if (diffDay > 0)
                        {
                            Rtn = string.Format("{0}일 전", diffDay);
                            break;
                        }

                        if (diffHour > 0)
                        {
                            Rtn = string.Format("{0}시간 전", diffHour);
                            break;
                        }

                        if (diffMinute > 0)
                        {
                            Rtn = string.Format("{0}분 전", diffMinute);
                            break;
                        }

                        if (diffSecond > 0)
                        {
                            Rtn = string.Format("{0}초 전", diffSecond);
                            break;
                        }

                        break;
                }
            }

            return Rtn;

        }

        public static string GetAvailablePathname(string folderPath, string filename)

        {
            int invalidChar = 0;
            do
            {
                invalidChar = filename.IndexOfAny(Path.GetInvalidFileNameChars());

                if (invalidChar != -1)
                    filename = filename.Remove(invalidChar, 1);
            }
            while (invalidChar != -1);


            string fullPath = Path.Combine(folderPath, filename);
            string filenameWithoutExtention = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);


            while (File.Exists(fullPath))
            {
                Regex rg = new Regex(@".*\((?<Num>\d*)\)");
                Match mt = rg.Match(fullPath);


                if (mt.Success)
                {
                    string numberOfCopy = mt.Groups["Num"].Value;
                    int nextNumberOfCopy = int.Parse(numberOfCopy) + 1;
                    int posStart = fullPath.LastIndexOf("(" + numberOfCopy + ")");

                    fullPath = string.Format("{0}({1}){2}", fullPath.Substring(0, posStart), nextNumberOfCopy, extension);
                }
                else
                {
                    fullPath = folderPath + filenameWithoutExtention + " (2)" + extension;
                }
            }
            return fullPath;
        }

        // 중복 이름 자동 생성
        public static string GetAvailableFtpFilename(string ftpUrl, string filename, string id, string password)
        {
            string nameWithoutExt = Path.GetFileNameWithoutExtension(filename);
            string ext = Path.GetExtension(filename);
            string newName = filename;

            // 정규식으로 (숫자) 패턴 찾기
            Regex rg = new Regex(@"\((?<Num>\d+)\)$");

            while (FtpFileExists(ftpUrl, newName, id, password))
            {
                Match mt = rg.Match(Path.GetFileNameWithoutExtension(newName));
                if (mt.Success)
                {
                    int number = int.Parse(mt.Groups["Num"].Value);
                    number++;
                    // 기존 (n) 제거 후 새 번호 붙이기
                    string baseName = nameWithoutExt.Substring(0, nameWithoutExt.LastIndexOf("("));
                    newName = $"{baseName} ({number}){ext}";
                    nameWithoutExt = Path.GetFileNameWithoutExtension(newName);
                }
                else
                {
                    // 처음 중복이면 (2) 붙이기
                    newName = $"{nameWithoutExt} (2){ext}";
                    nameWithoutExt = Path.GetFileNameWithoutExtension(newName);
                }
            }

            return newName;
        }

        // FTP 서버에 파일 존재 여부 확인
        private static bool FtpFileExists(string ftpUrl, string fileName, string id, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl + fileName);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(id, password);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    return true; // 파일 있음
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response != null && response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false; // 파일 없음
                throw;
            }
        }
    }
}
