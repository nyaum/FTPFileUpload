using AntdUI;
using System.Net;
using System.Security.Policy;

namespace FTPFileUpload
{
    public partial class Form1 : Form
    {

        public bool IsConnected { get; set; }
        private string ip = string.Empty;
        private string port = string.Empty;
        private string userId = string.Empty;
        private string pwd = string.Empty;


        public Form1()
        {
            InitializeComponent();

        }

        #region FTP 서버 연결

        // FTP 서버 연결
        public bool ConnectToServer(string ip, string port, string userId, string pwd, int node = -1)
        {
            this.IsConnected = false;

            this.ip = ip;
            this.port = port;
            this.userId = userId;
            this.pwd = pwd;

            string dirName = "";

            TreeNode tn = ftp_tree.SelectedNode;

            if (node != -1)
            {
                dirName = tn.FullPath;
            }

            string URL = String.Format(@"ftp://{0}:{1}/{2}", this.ip, this.port, dirName);

            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);
                ftpRequest.Credentials = new NetworkCredential(userId, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = false;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                // 연결에 성공했다면 디렉토리를 보여줌             
                //if (System.IO.Path.GetExtension(URL) != "")

                string ext = checkDirectory(URL);

                if (ext == "dir")
                {
                    ShowDirectory(ftpRequest, node);
                }

                this.IsConnected = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

                return false;

            }

            return true;

        }

        public bool ShowDirectory(FtpWebRequest ftpRequest, int node = -1)
        {

            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

            StreamReader reader;
            reader = new StreamReader(ftpResponse.GetResponseStream());

            string strData;
            strData = reader.ReadToEnd();

            string[] dir = strData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            TreeNode tn = ftp_tree.SelectedNode;

            if (node == -1)
            {
                for (int i = 0; i < dir.Length; i++)
                {

                    ftp_tree.Nodes.Add(dir[i]);

                }
            }
            else
            {
                // 하위 노드 Add 전, 디렉토리 비우기
                tn.Nodes.Clear();

                for (int i = 0; i < dir.Length; i++)
                {
                    tn.Nodes.Add(dir[i]);

                }
            }


            return true;
        }

        private void ftp_connect_Click(object sender, EventArgs e)
        {

            string strAddr = ftp_ip.Text.ToString();
            string strPort = ftp_port.Text.ToString();
            string strID = ftp_id.Text.ToString();
            string strPwd = ftp_pwd.Text.ToString();

            string URL = String.Format(@"ftp://{0}:{1}/", strAddr, strPort);

            // 로딩중 표시
            ftp_connect.Loading = true;
            ftp_connect.Text = " 연결중...";
            ftp_tree.Nodes.Clear();

            bool bResult = ConnectToServer(strAddr, strPort, strID, strPwd);

            if (this.IsConnected == true)
            {
                ftp_connect.Loading = false;
                ftp_connect.Text = "연결됨";
                ftp_connect.DefaultBorderColor = Color.LightGreen;
                button2.Enabled = true;

            }
            else
            {
                ftp_connect.Loading = false;
                ftp_connect.Text = "연결 실패";
            }

        }

        //디렉토리인지 판별하는 함수
        public static string checkDirectory(string URL)
        {

            string ext = System.IO.Path.GetExtension(URL);

            switch (ext)
            {
                // 확장자 체크

                // 폴더
                case "":
                    return "dir";
                default:
                    return "file";

            }
        }

        #endregion

        private void ftp_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            // 함수 호출 순서
            // ConnectToServer > ShowDirectory

            ConnectToServer(ftp_ip.Text, ftp_port.Text, ftp_id.Text, ftp_pwd.Text, e.Node.Index);

            e.Node.Expand();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1.Clear();

            string strFilePath = null;

            openFileDialog1.InitialDirectory = "C:\\";

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    strFilePath = openFileDialog1.FileName;
            //    input1.Text = strFilePath.Split("\\")[strFilePath.Split("\\").Length - 1];
            //}

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode tn = ftp_tree.SelectedNode;

            string ftpPath = tn.FullPath;
            string filePath = input1.Text;
            string fileName = System.IO.Path.GetFileName(filePath);

            bool bResult = FileUpload(ftpPath, filePath, fileName);

            if (bResult)
            {
                tn.Toggle();

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
                string strAddr = ftp_ip.Text.ToString();
                string strPort = ftp_port.Text.ToString();
                string strID = ftp_id.Text.ToString();
                string strPwd = ftp_pwd.Text.ToString();

                string URL = String.Format(@"ftp://{0}:{1}/{2}/{3}", strAddr, strPort, ftpPath, fileName);

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);
                ftpRequest.Credentials = new NetworkCredential(userId, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UsePassive = false;

                //파일정보를 Byte로열기
                byte[] fileContents = null;
                using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
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
