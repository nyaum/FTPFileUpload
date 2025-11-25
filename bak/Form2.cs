using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPFileUpload
{
    public partial class Form2 : Form
    {
        public bool IsConnected { get; set; }
        private string IP = string.Empty;
        private string Port = string.Empty;
        private string ID = string.Empty;
        private string Password = string.Empty;

        public Form2()
        {
            InitializeComponent();

            List<string> list = iniHelper.GetIniData();

            ftp_addr.Text = list[0];
            ftp_port.Text = list[1];
            ftp_id.Text = list[2];
            ftp_password.Text = list[3];

        }

        public FtpWebRequest ConnectToServer(string IP, string Port, string ID, string Password)
        {

            string URL = String.Format(@"ftp://{0}:{1}", this.IP, this.Port);

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);

            try
            {

                ftpRequest.Credentials = new NetworkCredential(ID, Password);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = false;

                return ftpRequest;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

                return ftpRequest;

            }

        }

        public bool ShowDirectory(FtpWebRequest ftpRequest)
        {

            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

            StreamReader reader;
            reader = new StreamReader(ftpResponse.GetResponseStream());

            string strData;
            strData = reader.ReadToEnd();

            string[] dir = strData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            TreeNode rootNode = tv_ftp.Nodes["root"];

            // before tree init root dir clear
            rootNode.Nodes.Clear();
            // init tree
            initTree(dir);
            // after tree init root dir expand
            rootNode.Expand();

            return true;
        }

        public void initTree(string[] dir)
        {
            //string URL = String.Format(@"ftp://{0}:{1}/", this.IP, this.Port);

            TreeNode rootNode = tv_ftp.Nodes["root"];

            // 첫 연결시에만 root 아래에 폴더를 만든다
            if(rootNode.Nodes.Count == 0)
            {
                for (int i = 0; i < dir.Length; i++)
                {
                    rootNode.Nodes.Add(dir[i]);
                }
            }

            TreeNode tn = rootNode.Nodes[0];

            // 하위 디렉토리가 있는지 확인
            for (int i = 0; i < dir.Length; i++)
            {


            }


            //TreeNode rootNode = tv_ftp.Nodes["root"];

            // TODO : 디렉토리 트리뷰로 한번에 들어가게 만들기...
            //for (int i = 0; i < dir.Length; i++)
            //{
            //    rootNode.Nodes.Add(dir[i]);
            //}


        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            this.IP = ftp_addr.Text;
            this.Port = ftp_port.Text;
            this.ID = ftp_id.Text;
            this.Password = ftp_password.Text;

            this.IsConnected = false;

            FtpWebRequest ftpRequest = ConnectToServer(this.IP, this.Port, this.ID, this.Password);

            bool bRtn = ShowDirectory(ftpRequest);

            if (bRtn)
            {
                if (ftp_remember.Checked)
                {
                    // ini file init
                    iniHelper.iniInit(this.IP, this.Port, this.ID, this.Password);
                }

                ftp_addr.Enabled = false;
                ftp_port.Enabled = false;
                ftp_id.Enabled = false;
                ftp_password.Enabled = false;
                ftp_remember.Enabled = false;

                btn_connect.Text = "종료";

            }

        }

    }
}
