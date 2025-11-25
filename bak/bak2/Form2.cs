using AntdUI;
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
using static System.Net.WebRequestMethods;

namespace FTPFileUpload
{
    public partial class Form2 : Form
    {
        public bool IsConnected { get; set; }
        private string IP = string.Empty;
        private string Port = string.Empty;
        private string ID = string.Empty;
        private string Password = string.Empty;
        private Exception LastException;

        public Form2()
        {
            InitializeComponent();

            List<string> list = iniHelper.GetIniData();

            ftp_addr.Text = list[0];
            ftp_port.Text = list[1];
            ftp_id.Text = list[2];
            ftp_password.Text = list[3];

        }

        public bool ConnectToServer(string IP, string Port, string ID, string Password)
        {

            string URL = String.Format(@"ftp://{0}:{1}", this.IP, this.Port);

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);

            try
            {

                ftpRequest.Credentials = new NetworkCredential(ID, Password);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    this.IsConnected = true;

                    return true;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

                return false;

            }

        }

        private void LoadDirectoryTree(string path)
        {

            //ftp treeview clear
            tv_ftp.Nodes.Clear();
            TreeNode rootNode = new TreeNode(path);
            tv_ftp.Nodes.Add(rootNode);

            AddDirectoryNodes(rootNode, path);
            rootNode.Expand();
        }

        // remote 폴더, 파일 가져오는 메소드
        private void AddDirectoryNodes(TreeNode treeNode, string path)
        {
            List<string> directories = GetDirectoryListing(path);

            foreach (string dir in directories)
            {
                string[] parts = dir.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = parts[3];

                if (parts[2] == "<DIR>")
                {
                    // 디렉토리인 경우
                    TreeNode dirNode = new TreeNode(name);
                    treeNode.Nodes.Add(dirNode);
                    AddDirectoryNodes(dirNode, path + "/" + name);
                }
                else
                {
                    // 파일인 경우
                    TreeNode fileNode = new TreeNode(name);
                    treeNode.Nodes.Add(fileNode);
                }
            }
        }

        // 디렉토리 목록을 가져오는 메서드
        public List<string> GetDirectoryListing(string path)
        {
            // 디렉토리 목록을 저장할 List 생성
            List<string> directories = new List<string>();
            try
            {
                string url = $@"FTP://{this.IP}:{this.Port}/{path}";
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpWebRequest.Credentials = new NetworkCredential(this.ID, this.Password);
                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    while (!reader.EndOfStream)
                    {
                        directories.Add(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";
            }
            return directories;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            this.IP = ftp_addr.Text;
            this.Port = ftp_port.Text;
            this.ID = ftp_id.Text;
            this.Password = ftp_password.Text;

            this.IsConnected = false;

            bool bRtn = ConnectToServer(this.IP, this.Port, this.ID, this.Password);

            if (bRtn)
            {

                LoadDirectoryTree("/");

                ftp_addr.Enabled = false;
                ftp_port.Enabled = false;
                ftp_id.Enabled = false;
                ftp_password.Enabled = false;
                ftp_remember.Enabled = false;

                btn_connect.Text = "종료";

            }

        }

        private void ftp_fileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_uploadFileName.Text = openFileDialog1.FileName;
            }
        }

        private void ftp_upload_Click(object sender, EventArgs e)
        {
            TreeNode tn = tv_ftp.SelectedNode;

            string ftpPath = tn.FullPath;
            string filePath = lbl_uploadFileName.Text;
            string fileName = System.IO.Path.GetFileName(filePath);

            bool bResult = FileUpload(ftpPath, filePath, fileName);

            if (bResult)
            {

                LoadDirectoryTree("/");

            }
        }

        /// <summary>
        /// 파일 업로드
        /// </summary>
        /// <param name="ftpPath"></param>
        /// <param name="filePath"></param>
        private bool FileUpload(string ftpPath, string filePath, string fileName)
        {

            try
            {

                string URL = $@"ftp://{this.IP}:{this.Port}/{ftpPath}/{fileName}";

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);
                ftpRequest.Credentials = new NetworkCredential(this.ID, this.Password);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UsePassive = false;

                //파일정보를 Byte로열기
                byte[] fileContents = null;
                using (BinaryReader br = new BinaryReader(System.IO.File.Open(filePath, FileMode.Open)))
                {
                    long dataLength = br.BaseStream.Length;
                    fileContents = new byte[br.BaseStream.Length];
                    fileContents = br.ReadBytes((int)br.BaseStream.Length);
                }

                //FTP서버에 파일전송처리
                ftpRequest.ContentLength = fileContents.LongLength;
                using (Stream requestStream = ftpRequest.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                //FTP전송결과확인
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
