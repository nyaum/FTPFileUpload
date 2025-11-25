namespace FTPFileUpload
{
    partial class FTP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTP));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            local_path = new AntdUI.Input();
            lv_local = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ftp_port = new AntdUI.Input();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            ftp_addr = new AntdUI.Input();
            ftp_id = new AntdUI.Input();
            ftp_password = new AntdUI.Input();
            btn_connect = new AntdUI.Button();
            label3 = new AntdUI.Label();
            ftp_remember = new AntdUI.Checkbox();
            divider1 = new AntdUI.Divider();
            tableLayoutPanel2 = new TableLayoutPanel();
            ftp_path = new AntdUI.Input();
            lv_ftp = new ListView();
            header_name = new ColumnHeader();
            header_date = new ColumnHeader();
            header_ext = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            lst_log = new ListBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btn_upload = new AntdUI.Button();
            btn_download = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(ftp_port, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(ftp_addr, 1, 0);
            tableLayoutPanel1.Controls.Add(ftp_id, 1, 1);
            tableLayoutPanel1.Controls.Add(ftp_password, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_connect, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(ftp_remember, 4, 1);
            tableLayoutPanel1.Controls.Add(divider1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.Controls.Add(local_path, 0, 0);
            tableLayoutPanel4.Controls.Add(lv_local, 0, 1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // local_path
            // 
            resources.ApplyResources(local_path, "local_path");
            local_path.Name = "local_path";
            local_path.ReadOnly = true;
            // 
            // lv_local
            // 
            lv_local.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            resources.ApplyResources(lv_local, "lv_local");
            lv_local.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_local.MultiSelect = false;
            lv_local.Name = "lv_local";
            lv_local.UseCompatibleStateImageBehavior = false;
            lv_local.View = View.Details;
            lv_local.ItemSelectionChanged += lv_local_ItemSelectionChanged;
            lv_local.DoubleClick += lv_local_DoubleClick;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // ftp_port
            // 
            resources.ApplyResources(ftp_port, "ftp_port");
            ftp_port.Name = "ftp_port";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_addr
            // 
            resources.ApplyResources(ftp_addr, "ftp_addr");
            ftp_addr.Name = "ftp_addr";
            // 
            // ftp_id
            // 
            resources.ApplyResources(ftp_id, "ftp_id");
            ftp_id.Name = "ftp_id";
            // 
            // ftp_password
            // 
            resources.ApplyResources(ftp_password, "ftp_password");
            ftp_password.Name = "ftp_password";
            ftp_password.PasswordChar = '●';
            // 
            // btn_connect
            // 
            resources.ApplyResources(btn_connect, "btn_connect");
            btn_connect.Name = "btn_connect";
            btn_connect.Click += btn_connect_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_remember
            // 
            resources.ApplyResources(ftp_remember, "ftp_remember");
            ftp_remember.Name = "ftp_remember";
            // 
            // divider1
            // 
            tableLayoutPanel1.SetColumnSpan(divider1, 5);
            resources.ApplyResources(divider1, "divider1");
            divider1.Name = "divider1";
            divider1.Orientation = AntdUI.TOrientation.Right;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.Controls.Add(ftp_path, 0, 0);
            tableLayoutPanel2.Controls.Add(lv_ftp, 0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // ftp_path
            // 
            resources.ApplyResources(ftp_path, "ftp_path");
            ftp_path.Name = "ftp_path";
            ftp_path.ReadOnly = true;
            // 
            // lv_ftp
            // 
            lv_ftp.Columns.AddRange(new ColumnHeader[] { header_name, header_date, header_ext });
            resources.ApplyResources(lv_ftp, "lv_ftp");
            lv_ftp.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_ftp.MultiSelect = false;
            lv_ftp.Name = "lv_ftp";
            lv_ftp.UseCompatibleStateImageBehavior = false;
            lv_ftp.View = View.Details;
            lv_ftp.ItemSelectionChanged += lv_ftp_ItemSelectionChanged;
            lv_ftp.DoubleClick += lv_ftp_DoubleClick;
            // 
            // header_name
            // 
            resources.ApplyResources(header_name, "header_name");
            // 
            // header_date
            // 
            resources.ApplyResources(header_date, "header_date");
            // 
            // header_ext
            // 
            resources.ApplyResources(header_ext, "header_ext");
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 5);
            tableLayoutPanel3.Controls.Add(lst_log, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lst_log
            // 
            resources.ApplyResources(lst_log, "lst_log");
            lst_log.FormattingEnabled = true;
            lst_log.Name = "lst_log";
            lst_log.SelectionMode = SelectionMode.None;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(btn_upload, 0, 1);
            tableLayoutPanel5.Controls.Add(btn_download, 0, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // btn_upload
            // 
            resources.ApplyResources(btn_upload, "btn_upload");
            btn_upload.Icon = Properties.Resources.step_forward;
            btn_upload.IconSize = new Size(20, 20);
            btn_upload.IconSvg = "";
            btn_upload.Name = "btn_upload";
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_download
            // 
            resources.ApplyResources(btn_download, "btn_download");
            btn_download.Icon = Properties.Resources.step_back;
            btn_download.IconSize = new Size(20, 20);
            btn_download.Name = "btn_download";
            btn_download.Click += btn_download_Click;
            // 
            // FTP
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FTP";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Input ftp_addr;
        private AntdUI.Input ftp_port;
        private AntdUI.Input ftp_id;
        private AntdUI.Input ftp_password;
        private AntdUI.Button btn_connect;
        private AntdUI.Checkbox ftp_remember;
        private AntdUI.Divider divider1;
        private ColumnHeader header_name;
        private ColumnHeader header_date;
        private ColumnHeader header_ext;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Input ftp_path;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Input local_path;
        private ListView lv_local;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TableLayoutPanel tableLayoutPanel3;
        public ListBox lst_log;
        private ListView lv_ftp;
        private TableLayoutPanel tableLayoutPanel5;
        private AntdUI.Button btn_upload;
        private AntdUI.Button btn_download;
    }
}