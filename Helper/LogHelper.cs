using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPFileUpload.Helper
{
    public static class LogHelper
    {

        public static void Write(string msg)
        {
            FTP.ftp.lst_log.Items.Add($"[{UtilityHelper.GetNowDate()}]\t" + msg);

            int visibleItems = FTP.ftp.lst_log.ClientSize.Height / FTP.ftp.lst_log.ItemHeight;
            FTP.ftp.lst_log.TopIndex = Math.Max(FTP.ftp.lst_log.Items.Count - visibleItems + 1, 0);
        }

        public static void ExceptionWrite(Exception ex)
        {
            FTP.ftp.lst_log.Items.Add($"[{UtilityHelper.GetNowDate()}]\t" + ex.Message);

            int visibleItems = FTP.ftp.lst_log.ClientSize.Height / FTP.ftp.lst_log.ItemHeight;
            FTP.ftp.lst_log.TopIndex = Math.Max(FTP.ftp.lst_log.Items.Count - visibleItems + 1, 0);
        }

    }
}
