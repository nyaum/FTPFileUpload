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
            TreeNode treeNode1 = new TreeNode("root");
            TreeNode treeNode2 = new TreeNode("root");
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
            splitter1 = new AntdUI.Splitter();
            tv_main = new TreeView();
            tv_ftp = new TreeView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047613F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.952383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047632F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.952383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
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
            tableLayoutPanel1.Controls.Add(splitter1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.88888884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(900, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ftp_port
            // 
            ftp_port.Location = new Point(495, 3);
            ftp_port.Name = "ftp_port";
            ftp_port.Size = new Size(272, 39);
            ftp_port.TabIndex = 5;
            // 
            // label1
            // 
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
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(388, 3);
            label2.Name = "label2";
            label2.Size = new Size(101, 39);
            label2.TabIndex = 1;
            label2.Text = "FTP Port";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(388, 48);
            label4.Name = "label4";
            label4.Size = new Size(101, 39);
            label4.TabIndex = 3;
            label4.Text = "FTP Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ftp_addr
            // 
            ftp_addr.Location = new Point(110, 3);
            ftp_addr.Name = "ftp_addr";
            ftp_addr.Size = new Size(272, 39);
            ftp_addr.TabIndex = 4;
            // 
            // ftp_id
            // 
            ftp_id.Location = new Point(110, 48);
            ftp_id.Name = "ftp_id";
            ftp_id.Size = new Size(272, 39);
            ftp_id.TabIndex = 6;
            // 
            // ftp_password
            // 
            ftp_password.Location = new Point(495, 48);
            ftp_password.Name = "ftp_password";
            ftp_password.Size = new Size(272, 39);
            ftp_password.TabIndex = 7;
            // 
            // btn_connect
            // 
            btn_connect.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_connect.Location = new Point(773, 3);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(124, 39);
            btn_connect.TabIndex = 8;
            btn_connect.Text = "연결";
            btn_connect.Click += btn_connect_Click;
            // 
            // label3
            // 
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
            ftp_remember.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ftp_remember.Location = new Point(773, 48);
            ftp_remember.Name = "ftp_remember";
            ftp_remember.Size = new Size(124, 39);
            ftp_remember.TabIndex = 9;
            ftp_remember.Text = "정보 저장";
            // 
            // divider1
            // 
            tableLayoutPanel1.SetColumnSpan(divider1, 5);
            divider1.Location = new Point(3, 93);
            divider1.Name = "divider1";
            divider1.Orientation = AntdUI.TOrientation.Right;
            divider1.Size = new Size(894, 7);
            divider1.TabIndex = 10;
            divider1.Text = "";
            // 
            // splitter1
            // 
            tableLayoutPanel1.SetColumnSpan(splitter1, 15);
            splitter1.Location = new Point(3, 106);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(tv_main);
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(tv_ftp);
            splitter1.Size = new Size(894, 341);
            splitter1.SplitterDistance = 444;
            splitter1.TabIndex = 11;
            // 
            // tv_main
            // 
            tv_main.Dock = DockStyle.Fill;
            tv_main.Location = new Point(0, 0);
            tv_main.Name = "tv_main";
            treeNode1.Name = "root";
            treeNode1.Text = "root";
            tv_main.Nodes.AddRange(new TreeNode[] { treeNode1 });
            tv_main.Size = new Size(444, 341);
            tv_main.TabIndex = 0;
            // 
            // tv_ftp
            // 
            tv_ftp.Dock = DockStyle.Fill;
            tv_ftp.Location = new Point(0, 0);
            tv_ftp.Name = "tv_ftp";
            treeNode2.Name = "root";
            treeNode2.Text = "root";
            tv_ftp.Nodes.AddRange(new TreeNode[] { treeNode2 });
            tv_ftp.Size = new Size(446, 341);
            tv_ftp.TabIndex = 1;
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
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
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
        private AntdUI.Splitter splitter1;
        private TreeView tv_main;
        private TreeView tv_ftp;
    }
}