namespace FTPFileUpload
{
    partial class Form2
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
            tv_ftp = new TreeView();
            tableLayoutPanel2 = new TableLayoutPanel();
            divider2 = new AntdUI.Divider();
            tableLayoutPanel4 = new TableLayoutPanel();
            ftp_upload = new AntdUI.Button();
            lbl_uploadFileName = new AntdUI.Label();
            ftp_fileSelect = new AntdUI.Button();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047594F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9523811F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9523811F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857189F));
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
            tableLayoutPanel1.Controls.Add(tv_ftp, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.Size = new Size(900, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ftp_port
            // 
            ftp_port.Dock = DockStyle.Fill;
            ftp_port.Location = new Point(494, 6);
            ftp_port.Name = "ftp_port";
            ftp_port.Size = new Size(270, 38);
            ftp_port.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 0;
            label1.Text = "FTP Address";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(388, 6);
            label2.Name = "label2";
            label2.Size = new Size(100, 38);
            label2.TabIndex = 1;
            label2.Text = "FTP Port";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(388, 50);
            label4.Name = "label4";
            label4.Size = new Size(100, 38);
            label4.TabIndex = 3;
            label4.Text = "FTP Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_addr
            // 
            ftp_addr.Dock = DockStyle.Fill;
            ftp_addr.Location = new Point(112, 6);
            ftp_addr.Name = "ftp_addr";
            ftp_addr.Size = new Size(270, 38);
            ftp_addr.TabIndex = 4;
            // 
            // ftp_id
            // 
            ftp_id.Dock = DockStyle.Fill;
            ftp_id.Location = new Point(112, 50);
            ftp_id.Name = "ftp_id";
            ftp_id.Size = new Size(270, 38);
            ftp_id.TabIndex = 6;
            // 
            // ftp_password
            // 
            ftp_password.Dock = DockStyle.Fill;
            ftp_password.Location = new Point(494, 50);
            ftp_password.Name = "ftp_password";
            ftp_password.Size = new Size(270, 38);
            ftp_password.TabIndex = 7;
            // 
            // btn_connect
            // 
            btn_connect.Dock = DockStyle.Fill;
            btn_connect.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_connect.Location = new Point(770, 6);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(124, 38);
            btn_connect.TabIndex = 8;
            btn_connect.Text = "연결";
            btn_connect.Click += btn_connect_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 2;
            label3.Text = "FTP ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_remember
            // 
            ftp_remember.Dock = DockStyle.Fill;
            ftp_remember.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ftp_remember.Location = new Point(770, 50);
            ftp_remember.Name = "ftp_remember";
            ftp_remember.Size = new Size(124, 38);
            ftp_remember.TabIndex = 9;
            ftp_remember.Text = "정보 저장";
            // 
            // divider1
            // 
            tableLayoutPanel1.SetColumnSpan(divider1, 5);
            divider1.Dock = DockStyle.Fill;
            divider1.Location = new Point(6, 94);
            divider1.Name = "divider1";
            divider1.Orientation = AntdUI.TOrientation.Right;
            divider1.Size = new Size(888, 7);
            divider1.TabIndex = 10;
            divider1.Text = "";
            // 
            // tv_ftp
            // 
            tableLayoutPanel1.SetColumnSpan(tv_ftp, 3);
            tv_ftp.Dock = DockStyle.Fill;
            tv_ftp.Location = new Point(6, 107);
            tv_ftp.Name = "tv_ftp";
            tv_ftp.Size = new Size(482, 304);
            tv_ftp.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(divider2, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Location = new Point(494, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4639177F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4639177F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.6082458F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4639177F));
            tableLayoutPanel2.Size = new Size(400, 304);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // divider2
            // 
            tableLayoutPanel2.SetColumnSpan(divider2, 5);
            divider2.Dock = DockStyle.Fill;
            divider2.Location = new Point(3, 89);
            divider2.Name = "divider2";
            divider2.Orientation = AntdUI.TOrientation.Right;
            divider2.Size = new Size(394, 14);
            divider2.TabIndex = 16;
            divider2.Text = "";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(ftp_upload, 1, 1);
            tableLayoutPanel4.Controls.Add(lbl_uploadFileName, 0, 0);
            tableLayoutPanel4.Controls.Add(ftp_fileSelect, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(394, 80);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // ftp_upload
            // 
            ftp_upload.Dock = DockStyle.Fill;
            ftp_upload.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ftp_upload.Location = new Point(200, 43);
            ftp_upload.Name = "ftp_upload";
            ftp_upload.Size = new Size(191, 34);
            ftp_upload.TabIndex = 2;
            ftp_upload.Text = "업로드";
            ftp_upload.Click += ftp_upload_Click;
            // 
            // lbl_uploadFileName
            // 
            tableLayoutPanel4.SetColumnSpan(lbl_uploadFileName, 2);
            lbl_uploadFileName.Dock = DockStyle.Fill;
            lbl_uploadFileName.Location = new Point(3, 3);
            lbl_uploadFileName.Name = "lbl_uploadFileName";
            lbl_uploadFileName.Size = new Size(388, 34);
            lbl_uploadFileName.TabIndex = 0;
            lbl_uploadFileName.Text = "";
            // 
            // ftp_fileSelect
            // 
            ftp_fileSelect.Dock = DockStyle.Fill;
            ftp_fileSelect.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ftp_fileSelect.Location = new Point(3, 43);
            ftp_fileSelect.Name = "ftp_fileSelect";
            ftp_fileSelect.Size = new Size(191, 34);
            ftp_fileSelect.TabIndex = 1;
            ftp_fileSelect.Text = "파일 선택";
            ftp_fileSelect.Click += ftp_fileSelect_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
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
        private TreeView tv_ftp;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Divider divider2;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Label lbl_uploadFileName;
        private AntdUI.Button ftp_upload;
        private AntdUI.Button ftp_fileSelect;
        private OpenFileDialog openFileDialog1;
    }
}