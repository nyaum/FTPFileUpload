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
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.90476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.952383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047632F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.952383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.Size = new Size(904, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(local_path, 0, 0);
            tableLayoutPanel4.Controls.Add(lv_local, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 100);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(386, 326);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // local_path
            // 
            local_path.Dock = DockStyle.Fill;
            local_path.Location = new Point(3, 3);
            local_path.Name = "local_path";
            local_path.Size = new Size(380, 39);
            local_path.TabIndex = 13;
            // 
            // lv_local
            // 
            lv_local.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lv_local.Dock = DockStyle.Fill;
            lv_local.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_local.Location = new Point(6, 51);
            lv_local.Margin = new Padding(6);
            lv_local.Name = "lv_local";
            lv_local.Size = new Size(374, 269);
            lv_local.TabIndex = 11;
            lv_local.UseCompatibleStateImageBehavior = false;
            lv_local.View = View.Details;
            lv_local.ItemSelectionChanged += lv_local_ItemSelectionChanged;
            lv_local.DoubleClick += lv_local_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "수정일";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "유형";
            columnHeader3.Width = 100;
            // 
            // ftp_port
            // 
            ftp_port.Dock = DockStyle.Fill;
            ftp_port.Location = new Point(496, 3);
            ftp_port.Name = "ftp_port";
            ftp_port.Size = new Size(273, 39);
            ftp_port.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(101, 39);
            label1.TabIndex = 0;
            label1.Text = "FTP Address";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(389, 3);
            label2.Name = "label2";
            label2.Size = new Size(101, 39);
            label2.TabIndex = 1;
            label2.Text = "FTP Port";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(389, 48);
            label4.Name = "label4";
            label4.Size = new Size(101, 39);
            label4.TabIndex = 3;
            label4.Text = "FTP Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_addr
            // 
            ftp_addr.Dock = DockStyle.Fill;
            ftp_addr.Location = new Point(110, 3);
            ftp_addr.Name = "ftp_addr";
            ftp_addr.Size = new Size(273, 39);
            ftp_addr.TabIndex = 4;
            // 
            // ftp_id
            // 
            ftp_id.Dock = DockStyle.Fill;
            ftp_id.Location = new Point(110, 48);
            ftp_id.Name = "ftp_id";
            ftp_id.Size = new Size(273, 39);
            ftp_id.TabIndex = 6;
            // 
            // ftp_password
            // 
            ftp_password.Dock = DockStyle.Fill;
            ftp_password.Location = new Point(496, 48);
            ftp_password.Name = "ftp_password";
            ftp_password.Size = new Size(273, 39);
            ftp_password.TabIndex = 7;
            // 
            // btn_connect
            // 
            btn_connect.Dock = DockStyle.Fill;
            btn_connect.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_connect.Location = new Point(775, 3);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(126, 39);
            btn_connect.TabIndex = 8;
            btn_connect.Text = "연결";
            btn_connect.Click += btn_connect_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(101, 39);
            label3.TabIndex = 2;
            label3.Text = "FTP ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_remember
            // 
            ftp_remember.Dock = DockStyle.Fill;
            ftp_remember.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ftp_remember.Location = new Point(802, 48);
            ftp_remember.Margin = new Padding(30, 3, 3, 3);
            ftp_remember.Name = "ftp_remember";
            ftp_remember.Size = new Size(99, 39);
            ftp_remember.TabIndex = 9;
            ftp_remember.Text = "정보 저장";
            // 
            // divider1
            // 
            tableLayoutPanel1.SetColumnSpan(divider1, 5);
            divider1.Dock = DockStyle.Fill;
            divider1.Location = new Point(3, 93);
            divider1.Name = "divider1";
            divider1.Orientation = AntdUI.TOrientation.Right;
            divider1.Size = new Size(898, 4);
            divider1.TabIndex = 10;
            divider1.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ftp_path, 0, 0);
            tableLayoutPanel2.Controls.Add(lv_ftp, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(493, 100);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(411, 326);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // ftp_path
            // 
            ftp_path.Dock = DockStyle.Fill;
            ftp_path.Location = new Point(3, 3);
            ftp_path.Name = "ftp_path";
            ftp_path.Size = new Size(405, 39);
            ftp_path.TabIndex = 13;
            // 
            // lv_ftp
            // 
            lv_ftp.Columns.AddRange(new ColumnHeader[] { header_name, header_date, header_ext });
            lv_ftp.Dock = DockStyle.Fill;
            lv_ftp.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_ftp.Location = new Point(6, 51);
            lv_ftp.Margin = new Padding(6);
            lv_ftp.Name = "lv_ftp";
            lv_ftp.Size = new Size(399, 269);
            lv_ftp.TabIndex = 11;
            lv_ftp.UseCompatibleStateImageBehavior = false;
            lv_ftp.View = View.Details;
            lv_ftp.ItemSelectionChanged += lv_ftp_ItemSelectionChanged;
            lv_ftp.DoubleClick += lv_ftp_DoubleClick;
            // 
            // header_name
            // 
            header_name.Text = "이름";
            header_name.Width = 130;
            // 
            // header_date
            // 
            header_date.Text = "수정일";
            header_date.Width = 170;
            // 
            // header_ext
            // 
            header_ext.Text = "유형";
            header_ext.Width = 100;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 5);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lst_log, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 429);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(898, 129);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // lst_log
            // 
            lst_log.Dock = DockStyle.Fill;
            lst_log.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lst_log.FormattingEnabled = true;
            lst_log.ItemHeight = 17;
            lst_log.Location = new Point(3, 3);
            lst_log.Name = "lst_log";
            lst_log.SelectionMode = SelectionMode.None;
            lst_log.Size = new Size(892, 123);
            lst_log.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(btn_upload, 0, 1);
            tableLayoutPanel5.Controls.Add(btn_download, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(389, 103);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(101, 320);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // btn_upload
            // 
            btn_upload.Dock = DockStyle.Fill;
            btn_upload.Enabled = false;
            btn_upload.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_upload.Icon = Properties.Resources.step_forward;
            btn_upload.IconSize = new Size(20, 20);
            btn_upload.IconSvg = "";
            btn_upload.Location = new Point(3, 113);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(95, 44);
            btn_upload.TabIndex = 0;
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_download
            // 
            btn_download.Dock = DockStyle.Fill;
            btn_download.Enabled = false;
            btn_download.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_download.Icon = Properties.Resources.step_back;
            btn_download.IconSize = new Size(20, 20);
            btn_download.Location = new Point(3, 163);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(95, 44);
            btn_download.TabIndex = 1;
            btn_download.Click += btn_download_Click;
            // 
            // FTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FTP";
            Text = "FTP";
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