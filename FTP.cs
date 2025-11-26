using AntdUI;
using AntdUI.Svg;
using ExCSS;
using FTPFileUpload.Helper;
using FTPFileUpload.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FTPFileUpload
{
    public partial class FTP : Form
    {
        public bool IsConnected { get; set; }
        private string IP = string.Empty;
        private string Port = string.Empty;
        private string ID = string.Empty;
        private string Password = string.Empty;
        private string RootFtpURL = string.Empty;
        private string CurrentFtpURL = string.Empty;

        private string RootLocalURL = string.Empty;
        private string CurrentLocalURL = string.Empty;

        public static FTP ftp;

        public FTP()
        {

            ftp = this;

            InitializeComponent();

            List<string> list = iniHelper.GetIniData();

            ftp_addr.Text = list[0];
            ftp_port.Text = list[1];
            ftp_id.Text = list[2];
            ftp_password.Text = list[3];
            ftp_remember.Checked = bool.Parse(list[4]);

        }

        #region FTP Connection

        /// <summary>
        /// FTP 서버 연결
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="ID"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public FtpWebRequest ConnectToServer(string URL, string ID, string Password)
        {

            //string URL = String.Format(@"ftp://{0}:{1}", this.IP, this.Port);

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URL);

            try
            {

                ftpRequest.Credentials = new NetworkCredential(ID, Password);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                ftpRequest.UsePassive = false;

                //this.CurrentPath = URL;
                //ftp_path.Text = this.CurrentPath;

                this.CurrentFtpURL = URL;
                ftp_path.Text = this.CurrentFtpURL;

                return ftpRequest;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

                return ftpRequest;

            }

        }

        /// <summary>
        /// FTP 서버 디렉토리 가져오기
        /// </summary>
        /// <param name="ftpRequest"></param>
        /// <returns></returns>
        public bool ShowFTPDirectory(FtpWebRequest ftpRequest)
        {

            LogHelper.Write("FTP 디렉토리 불러오는 중 ...");

            List<string> directories = new List<string>();

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    while (!reader.EndOfStream)
                    {
                        directories.Add(reader.ReadLine());
                    }
                }
            }
            catch { }

            // ListView 생성
            initFTPListView(directories);

            //btn_download.Enabled = false;

            LogHelper.Write("FTP 디렉토리 불러오기 완료");

            return true;
        }

        /// <summary>
        /// FTP 서버 디렉토리 리스트뷰로 출력
        /// </summary>
        /// <param name="directories"></param>
        public void initFTPListView(List<string> directories)
        {

            try
            {

                LogHelper.Write("FTP 디렉토리 출력 중 ...");

                lv_ftp.Items.Clear();

                ListViewItem lvi = new ListViewItem();

                // foreach로 들어가기 전에 상위 디렉토리... 리스트를 만들어줌
                // root 디렉토리라면 만들지 않음
                if (this.RootFtpURL != this.CurrentFtpURL)
                {
                    lvi.Text = "...";
                    lvi.ImageIndex = 0;
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("폴더");
                    lvi.Name = "lvi_up";
                    lv_ftp.Items.Add(lvi);
                }

                foreach (string dir in directories)
                {

                    lvi = new ListViewItem();

                    string[] arr = dir.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);

                    string date = arr[0] + " " + arr[1];

                    string ext = "";

                    //lvi.Text = arr[3];
                    lvi.Text = string.Join(" ", arr.Skip(3));

                    // 날짜 지정
                    // 원본 데이터 형식 정의
                    string originalFormat = "MM-dd-yy hh:mmtt";

                    // DateTime 객체로 변환
                    DateTime dateTime = DateTime.ParseExact(date, originalFormat, CultureInfo.InvariantCulture);

                    // 원하는 형식으로 변환
                    string targetFormat = "yyyy-MM-dd tt h:mm";
                    string result = dateTime.ToString(targetFormat, CultureInfo.InvariantCulture);

                    // 오전/오후 표시를 한글로 변경
                    date = result.Replace("AM", "오전").Replace("PM", "오후");

                    lvi.SubItems.Add(date);

                    // 파일 유형
                    switch (arr[2])
                    {
                        case "<DIR>":
                            ext = "폴더";
                            break;
                        default:
                            ext = "파일";
                            break;
                    }

                    lvi.SubItems.Add(ext);

                    lv_ftp.Items.Add(lvi);

                }

                LogHelper.Write("FTP 디렉토리 출력 완료");
            }
            catch (Exception ex)
            {

                LogHelper.ExceptionWrite(ex);

            }

        }

        /// <summary>
        /// 하위 디렉토리 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_ftp_DoubleClick(object sender, EventArgs e)
        {

            int selectRow = lv_ftp.SelectedItems[0].Index;

            if (lv_ftp.Items[selectRow].SubItems[2].Text == "파일") return;

            // 상위 디렉토리 이동일 경우
            if (lv_ftp.Items[selectRow].Name == "lvi_up")
            {
                // 상위 디렉토리 얻기
                int lastSlashIndex = this.CurrentFtpURL.LastIndexOf('/', this.CurrentFtpURL.Length - 2);

                // 끝에 있는 '/'를 제외하고 그 앞의 '/' 위치를 찾음
                this.CurrentFtpURL = this.CurrentFtpURL.Substring(0, lastSlashIndex + 1);
            }
            else
            {
                this.CurrentFtpURL = this.CurrentFtpURL + lv_ftp.Items[selectRow].SubItems[0].Text + "/";
            }

            ftp_path.Text = this.CurrentFtpURL;

            // ConnectToServer로 다시 연결?

            FtpWebRequest ftpRequest = ConnectToServer(this.CurrentFtpURL, this.ID, this.Password);

            ShowFTPDirectory(ftpRequest);

        }

        /// <summary>
        /// 디렉토리 주소 받아오기 및 다운로드 버튼 활성화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_ftp_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //int selectRow = lv_ftp.SelectedItems[0].Index;
            int selectRow = e.Item.Index;

            if (selectRow == -1)
            {
                return;
            }

            string URL = "";

            if (lv_ftp.Items[selectRow].Name == "lvi_up")
            {
                URL = this.CurrentFtpURL;
            }
            else
            {
                URL = this.CurrentFtpURL + lv_ftp.Items[selectRow].SubItems[0].Text + "/";
            }


            ftp_path.Text = URL;

            if (e.IsSelected)
            {
                // 선택된 list가 폴더가 아닐 경우, 다운로드 버튼 활성화
                if (lv_ftp.Items[selectRow].SubItems[2].Text != "폴더")
                {
                    btn_download.Enabled = true;
                }
                else
                {
                    btn_download.Enabled = false;
                }
            }
            else
            {
                btn_download.Enabled = false;
            }
        }

        /// <summary>
        /// 파일 FTP > Local 로 다운로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_download_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_ftp.SelectedItems.Count == 0)
                {
                    LogHelper.Write("다운로드 할 파일을 선택해주세요.");

                    return;
                }

                LogHelper.Write($"경로 {this.CurrentLocalURL}에 파일 다운로드 중 ...");

                int selectRow = lv_ftp.SelectedItems[0].Index;
                string fileName = lv_ftp.Items[selectRow].SubItems[0].Text;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.CurrentFtpURL + fileName);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(this.ID, this.Password);
                request.KeepAlive = false;

                // TODO : 로컬 리스트뷰를 클릭 후, 그 위치에 넣을 수 있게 작업
                //string dlLocation = $"C:\\Users\\iiroom\\Downloads\\";
                string dlLocation = $"{this.CurrentLocalURL}";
                string dlFullPath = UtilityHelper.GetAvailablePathname(dlLocation, fileName);

                // 먼저 파일 크기 조회 (진행률 계산용)
                long totalLength = 0;
                try
                {
                    FtpWebRequest sizeRequest = (FtpWebRequest)WebRequest.Create(this.CurrentFtpURL + fileName);
                    sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                    sizeRequest.Credentials = new NetworkCredential(this.ID, this.Password);
                    sizeRequest.KeepAlive = false;
                    using (FtpWebResponse sizeResponse = (FtpWebResponse)sizeRequest.GetResponse())
                    {
                        totalLength = sizeResponse.ContentLength;
                    }
                }
                catch
                {
                    totalLength = -1; // 파일 크기를 알 수 없는 경우
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(dlFullPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1MB 버퍼
                    int bytesRead;
                    long totalRead = 0;

                    while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                        totalRead += bytesRead;

                        if (totalLength > 0) // 파일 크기를 알 수 있을 때만 %
                        {
                            double progress = (double)totalRead / totalLength * 100;
                            LogHelper.Write($"다운로드 진행률: {progress:F2}%");
                        }
                        else
                        {
                            LogHelper.Write($"다운로드 중... {totalRead} bytes 읽음");
                        }
                    }
                }

                LogHelper.Write($"경로 {this.CurrentLocalURL}에 파일 다운로드 완료");

                request.Abort();
                // 다운로드 완료 후 리스트뷰를 다시 불러와야함
                bool bRtn = ShowLocalDirectory(this.CurrentLocalURL);

            }
            catch (Exception ex)
            {
                LogHelper.ExceptionWrite(ex);
            }
        }
        
        /// <summary>
        /// 우클릭 메뉴 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_ftp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var menulist = new AntdUI.IContextMenuStripItem[]
                {
                    new AntdUI.ContextMenuStripItem("이름 변경", "New Name")
                    {
                        IconSvg = Resources.Svg.pencil_square,
                        ID = "E"
                    },
                    new AntdUI.ContextMenuStripItem("파일 삭제", "Delete")
                    {
                        IconSvg = Resources.Svg.document_minus,
                        ID = "D"
                    },

                };
                AntdUI.ContextMenuStrip.open(this, it =>
                {

                    switch (it.ID)
                    {
                        case "E":
                            // 파일 이름 변경 함수

                            EditFtpFileName();

                            break;
                        case "D":
                            // 파일 삭제 함수

                            DeleteFtpFileName();

                            break;
                    }

                    // 처리 완료 후 리스트뷰를 다시 불러와야함(ftp)

                    var request = CreateFtpRequest(this.CurrentFtpURL, WebRequestMethods.Ftp.ListDirectoryDetails);

                    ShowFTPDirectory(request);

                    btn_download.Enabled = false;

                }, menulist);
            }
        }
        
        /// <summary>
        /// 파일 삭제
        /// </summary>
        /// <param name="url"></param>
        private void DeleteFtpFileName(string url = "")
        {
            int i = lv_ftp.SelectedItems[0].Index;

            if (string.IsNullOrEmpty(url))
            {
                url = $"{this.CurrentFtpURL}{lv_ftp.Items[i].Text}";
            }

            // 상위 디렉토리 클릭 시 무시
            if (lv_ftp.Items[i].Name == "lvi_up")
                return;

            try
            {
                LogHelper.Write($"{url} 경로 파일 삭제 중 ...");

                var listRequest = CreateFtpRequest(url, WebRequestMethods.Ftp.ListDirectoryDetails);

                List<string> lines = new List<string>();
                using (var listResponse = (FtpWebResponse)listRequest.GetResponse())
                using (var listStream = listResponse.GetResponseStream())
                using (var listReader = new StreamReader(listStream))
                {
                    while (!listReader.EndOfStream)
                    {
                        lines.Add(listReader.ReadLine());
                    }
                }

                foreach (string line in lines)
                {
                    string[] arr = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string name = string.Join(" ", arr.Skip(3));
                    string ext = arr[2];

                    string fileUrl = $"{url}/{name}";

                    if (ext.Equals("<DIR>", StringComparison.OrdinalIgnoreCase))
                    {
                        DeleteFtpFileName(fileUrl);
                    }
                    else
                    {
                        using (var deleteResponse = (FtpWebResponse)CreateFtpRequest(fileUrl, WebRequestMethods.Ftp.DeleteFile).GetResponse())
                        {
                            LogHelper.Write($"{fileUrl} 파일 삭제 완료");
                        }
                    }
                }

                using (var removeResponse = (FtpWebResponse)CreateFtpRequest(url, WebRequestMethods.Ftp.RemoveDirectory).GetResponse())
                {
                    LogHelper.Write($"{url} 디렉토리 삭제 완료");
                }
            }
            catch (Exception ex)
            {
                LogHelper.ExceptionWrite(ex);
            }
        }
        
        /// <summary>
        /// FTP 연결할때 쓰는 그거
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private FtpWebRequest CreateFtpRequest(string url, string method)
        {
            var request = (FtpWebRequest)WebRequest.Create(url);
            request.Method = method;
            request.Credentials = new NetworkCredential(this.ID, this.Password);
            request.KeepAlive = false;
            return request;
        }


        private void EditFtpFileName()
        {

        }

        #endregion

        #region Local Connection

        /// <summary>
        /// Local 서버 디렉토리 가져오기
        /// </summary>
        /// <param name="FolderName"></param>
        /// <returns></returns>
        public bool ShowLocalDirectory(string FolderName)
        {
            LogHelper.Write("로컬 디렉토리 불러오는 중 ...");

            List<string> directories = new List<string>();

            // 다시 드라이브 목록으로 돌아올때 처리
            if (FolderName == "")
            {
                DriveInfo[] allDrive = DriveInfo.GetDrives();

                List<string> rootdir = new List<string>();

                foreach (DriveInfo info in allDrive)
                {
                    if (info.DriveType == DriveType.Fixed)
                    {
                        rootdir.Add(info.Name.Substring(0, 2) + "||드라이브");
                    }

                }

                initLocalListView(rootdir);

                return true;
            }

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName);

            foreach (System.IO.DirectoryInfo info in di.GetDirectories())
            {

                if ((info.Attributes & FileAttributes.System) == FileAttributes.System ||
                    (info.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
                {
                    // 특수 폴더 >> 무시
                    continue;
                }

                directories.Add(info.Name + "|" + info.CreationTime + "|" + "폴더");
            }

            foreach (System.IO.FileInfo info in di.GetFiles())
            {

                // except : 파일 확장자가 없는 파일 (ex. README 단독 파일) 일 경우, Exception 발생.
                if (info.Extension == "")
                {
                    directories.Add(info.Name + "|" + info.CreationTime + "|" + "파일");
                }
                else
                {
                    directories.Add(info.Name + "|" + info.CreationTime + "|" + info.Extension);
                }
            }

            // ListView 생성
            initLocalListView(directories);

            //btn_download.Enabled = false;

            LogHelper.Write("로컬 디렉토리 불러오기 완료");

            return true;
        }

        /// <summary>
        /// Local 서버 디렉토리 리스트뷰로 출력
        /// </summary>
        /// <param name="directories"></param>
        public void initLocalListView(List<string> directories)
        {
            try
            {
                LogHelper.Write("로컬 디렉토리 출력 중 ...");

                lv_local.Items.Clear();

                ListViewItem lvi = new ListViewItem();

                // foreach로 들어가기 전에 상위 디렉토리... 리스트를 만들어줌
                // root 디렉토리라면 만들지 않음
                if (this.RootLocalURL != this.CurrentLocalURL)
                {
                    lvi.Text = "...";
                    lvi.ImageIndex = 0;
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("폴더");
                    lvi.Name = "lvi_up";
                    lv_local.Items.Add(lvi);
                }

                foreach (string dir in directories)
                {

                    lvi = new ListViewItem();

                    string[] arr = dir.Split("|");

                    lvi.Text = arr[0];
                    lvi.SubItems.Add(arr[1]);

                    string ext = "";
                    // 파일 유형
                    switch (arr[2])
                    {
                        case "드라이브":
                            ext = "드라이브";
                            break;
                        case "폴더":
                            ext = "폴더";
                            break;
                        default:
                            ext = "파일";
                            break;
                    }

                    lvi.SubItems.Add(ext);


                    lv_local.Items.Add(lvi);
                }

                LogHelper.Write("로컬 디렉토리 출력 완료");

            }
            catch (Exception ex)
            {
                LogHelper.ExceptionWrite(ex);
            }
        }

        /// <summary>
        /// 하위 디렉토리로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_local_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                int selectRow = lv_local.SelectedItems[0].Index;

                if (lv_local.Items[selectRow].SubItems[2].Text == "파일") return;

                // 상위 디렉토리 이동일 경우
                if (lv_local.Items[selectRow].Name == "lvi_up")
                {
                    // 상위 디렉토리 얻기
                    int lastSlashIndex = this.CurrentLocalURL.LastIndexOf('/', this.CurrentLocalURL.Length - 2);

                    // 끝에 있는 '/'를 제외하고 그 앞의 '/' 위치를 찾음
                    this.CurrentLocalURL = this.CurrentLocalURL.Substring(0, lastSlashIndex + 1);
                }
                else
                {
                    this.CurrentLocalURL = this.CurrentLocalURL + lv_local.Items[selectRow].SubItems[0].Text + "/";
                }

                local_path.Text = this.CurrentLocalURL;



                bool bRtn = ShowLocalDirectory(local_path.Text);
            }
            catch (Exception ex)
            {
                int lastSlashIndex = this.CurrentLocalURL.LastIndexOf('/', this.CurrentLocalURL.Length - 2);
                this.CurrentLocalURL = this.CurrentLocalURL.Substring(0, lastSlashIndex + 1);
                local_path.Text = this.CurrentLocalURL;

                LogHelper.ExceptionWrite(ex);

                //lst_log.Items.Add(UtilityHelper.GetNowDate() + "\t 권한이 없습니다.");
            }
        }

        /// <summary>
        /// 디렉토리 주소 받아오기 및 다운로드 버튼 활성화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_local_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int selectRow = e.Item.Index;

            string URL = "";

            if (lv_local.Items[selectRow].Name == "lvi_up")
            {
                URL = this.CurrentLocalURL;
            }
            else
            {
                URL = this.CurrentLocalURL + lv_local.Items[selectRow].SubItems[0].Text + "/";
            }


            local_path.Text = URL;

            if (e.IsSelected)
            {
                // 선택된 list가 폴더가 아닐 경우, 다운로드 버튼 활성화
                if (lv_local.Items[selectRow].SubItems[2].Text != "폴더" &&
                    lv_local.Items[selectRow].SubItems[2].Text != "드라이브")
                {
                    btn_upload.Enabled = true;
                }
                else
                {
                    btn_upload.Enabled = false;
                }
            }
            else
            {
                btn_upload.Enabled = false;
            }

        }

        /// <summary>
        /// 파일 Local > FTP 로 업로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelper.Write($"경로 {this.CurrentFtpURL}에 파일 업로드 중 ...");

                int selectRow = lv_local.SelectedItems[0].Index;
                string fileName = lv_local.Items[selectRow].SubItems[0].Text;

                string uniqueFileName = UtilityHelper.GetAvailableFtpFilename(this.CurrentFtpURL, fileName, this.ID, this.Password);

                //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.CurrentFtpURL + fileName);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.CurrentFtpURL + uniqueFileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(this.ID, this.Password);

                // 전체 파일 크기 (진행률 계산용)
                long totalLength = new FileInfo(this.CurrentLocalURL + fileName).Length;
                long totalSent = 0;

                // FTP 서버에 파일 전송 (스트리밍 방식) >> 용량 문제로 대용량 파일은 조각 단위로 읽어서 보내야함.
                using (Stream requestStream = request.GetRequestStream())
                using (FileStream fs = new FileStream(this.CurrentLocalURL + fileName, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1MB 버퍼
                    int bytesRead;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        requestStream.Write(buffer, 0, bytesRead);
                        totalSent += bytesRead;

                        double progress = (double)totalSent / totalLength * 100;
                        LogHelper.Write($"업로드 진행률: {progress:F2}%");
                    }
                }

                //FTP전송결과확인
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    LogHelper.Write($"경로 {this.CurrentFtpURL}에 파일 업로드 완료");
                }

                // 다운로드 완료 후 리스트뷰를 다시 불러와야함(ftp)
                var reloadRequest = CreateFtpRequest(this.CurrentFtpURL, WebRequestMethods.Ftp.ListDirectoryDetails);

                ShowFTPDirectory(reloadRequest);

            }
            catch (Exception ex)
            {
                LogHelper.ExceptionWrite(ex);
            }
        }

        #endregion

        /// <summary>
        /// FTP 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsConnected)
                {
                    this.IP = ftp_addr.Text;
                    this.Port = ftp_port.Text;
                    this.ID = ftp_id.Text;
                    this.Password = ftp_password.Text;
                    this.RootFtpURL = $@"ftp://{this.IP}:{this.Port}/";


                    this.CurrentFtpURL = this.RootFtpURL;
                    this.CurrentLocalURL = this.RootLocalURL;

                    this.IsConnected = false;

                    LogHelper.Write($"{this.RootFtpURL} 에 연결 중 ... ");

                    FtpWebRequest ftpRequest = ConnectToServer(this.CurrentFtpURL, this.ID, this.Password);

                    bool bRtn = ShowFTPDirectory(ftpRequest);

                    if (bRtn)
                    {
                        if (ftp_remember.Checked)
                        {
                            // ini file init
                            iniHelper.iniInit(this.IP, this.Port, this.ID, this.Password, ftp_remember.Checked);
                        }

                        ftp_addr.Enabled = false;
                        ftp_port.Enabled = false;
                        ftp_id.Enabled = false;
                        ftp_password.Enabled = false;
                        ftp_remember.Enabled = false;

                        ftp_path.Text = this.CurrentFtpURL;
                        btn_connect.Text = "종료";

                    }

                    // ftp 연결 완료, local 연결 시작

                    // 로컬에서는 버튼을 처음 눌렀을때 드라이브 목록을 불러옴

                    LogHelper.Write("로컬 디렉토리 불러오는 중 ...");
                    local_path.Text = "";

                    DriveInfo[] driveList = DriveInfo.GetDrives();

                    List<string> directories = new List<string>();

                    foreach (DriveInfo info in driveList)
                    {
                        if (info.DriveType == DriveType.Fixed)
                        {
                            directories.Add(info.Name.Substring(0, 2) + "||드라이브");
                        }
                    }

                    initLocalListView(directories);

                    LogHelper.Write("로컬 디렉토리 불러오기 완료");

                    LogHelper.Write("연결 성공");

                    this.IsConnected = true;
                }
                else
                {

                    LogHelper.Write("연결을 종료 하는 중 ...");

                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(this.RootFtpURL);
                    ftpRequest.KeepAlive = false;

                    if (ftpRequest != null)
                    {
                        ftpRequest.Abort(); // 강제 종료
                    }

                    // 입력값 초기화
                    ftp_path.Text = "";
                    local_path.Text = "";

                    // 연결 주소 입력창 활성화
                    ftp_addr.Enabled = true;
                    ftp_port.Enabled = true;
                    ftp_id.Enabled = true;
                    ftp_password.Enabled = true;
                    ftp_remember.Enabled = true;

                    // 파라미터 초기화
                    this.IsConnected = false;
                    this.IP = string.Empty;
                    this.Port = string.Empty;
                    this.ID = string.Empty;
                    this.Password = string.Empty;
                    this.RootFtpURL = string.Empty;
                    this.CurrentFtpURL = string.Empty;
                    this.RootLocalURL = string.Empty;
                    this.CurrentLocalURL = string.Empty;

                    // 버튼 초기화
                    btn_connect.Text = "연결";
                    btn_upload.Enabled = false;
                    btn_download.Enabled = false;

                    // 리스트뷰 초기화
                    lv_ftp.Items.Clear();
                    lv_local.Items.Clear();

                    LogHelper.Write("연결 종료");

                }


            }
            catch (Exception ex)
            {
                LogHelper.ExceptionWrite(ex);
            }

        }


    }
}
