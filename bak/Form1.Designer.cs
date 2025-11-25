namespace FTPFileUpload
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("노드0");
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new AntdUI.Button();
            input1 = new AntdUI.Input();
            ftp_ip = new AntdUI.Input();
            ftp_tree = new TreeView();
            button2 = new AntdUI.Button();
            ftp_port = new AntdUI.Input();
            ftp_id = new AntdUI.Input();
            ftp_pwd = new AntdUI.Input();
            ftp_connect = new AntdUI.Button();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(button1, 1, 2);
            tableLayoutPanel1.Controls.Add(input1, 0, 2);
            tableLayoutPanel1.Controls.Add(ftp_ip, 0, 0);
            tableLayoutPanel1.Controls.Add(ftp_tree, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 2, 2);
            tableLayoutPanel1.Controls.Add(ftp_port, 1, 0);
            tableLayoutPanel1.Controls.Add(ftp_id, 0, 1);
            tableLayoutPanel1.Controls.Add(ftp_pwd, 1, 1);
            tableLayoutPanel1.Controls.Add(ftp_connect, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 379F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Size = new Size(1020, 583);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(353, 103);
            button1.Name = "button1";
            button1.Size = new Size(144, 44);
            button1.TabIndex = 1;
            button1.Text = "파일 불러오기";
            button1.Click += button1_Click;
            // 
            // input1
            // 
            input1.BackColor = Color.White;
            input1.Enabled = false;
            input1.ForeColor = Color.White;
            input1.Location = new Point(3, 103);
            input1.Name = "input1";
            input1.Size = new Size(344, 44);
            input1.TabIndex = 4;
            // 
            // ftp_ip
            // 
            ftp_ip.Location = new Point(3, 3);
            ftp_ip.Name = "ftp_ip";
            ftp_ip.Size = new Size(344, 44);
            ftp_ip.TabIndex = 5;
            ftp_ip.Text = "127.0.0.1";
            // 
            // ftp_tree
            // 
            tableLayoutPanel1.SetColumnSpan(ftp_tree, 2);
            ftp_tree.Location = new Point(3, 153);
            ftp_tree.Name = "ftp_tree";
            treeNode1.Name = "노드0";
            treeNode1.Text = "노드0";
            ftp_tree.Nodes.AddRange(new TreeNode[] { treeNode1 });
            ftp_tree.PathSeparator = "/";
            ftp_tree.Size = new Size(494, 373);
            ftp_tree.TabIndex = 11;
            ftp_tree.AfterSelect += ftp_tree_AfterSelect;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(503, 103);
            button2.Name = "button2";
            button2.Size = new Size(144, 44);
            button2.TabIndex = 12;
            button2.Text = "업로드";
            button2.Click += button2_Click;
            // 
            // ftp_port
            // 
            ftp_port.Location = new Point(353, 3);
            ftp_port.Name = "ftp_port";
            ftp_port.Size = new Size(144, 44);
            ftp_port.TabIndex = 8;
            ftp_port.Text = "21";
            // 
            // ftp_id
            // 
            ftp_id.Location = new Point(3, 53);
            ftp_id.Name = "ftp_id";
            ftp_id.Size = new Size(344, 44);
            ftp_id.TabIndex = 6;
            ftp_id.Text = "ftp";
            // 
            // ftp_pwd
            // 
            ftp_pwd.Location = new Point(353, 53);
            ftp_pwd.Name = "ftp_pwd";
            ftp_pwd.Size = new Size(144, 44);
            ftp_pwd.TabIndex = 9;
            ftp_pwd.Text = "test001";
            // 
            // ftp_connect
            // 
            ftp_connect.DefaultBorderColor = Color.Black;
            ftp_connect.Location = new Point(503, 3);
            ftp_connect.Name = "ftp_connect";
            ftp_connect.Size = new Size(144, 44);
            ftp_connect.TabIndex = 7;
            ftp_connect.Text = "연결";
            ftp_connect.Click += ftp_connect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 583);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AntdUI.Button button1;
        private OpenFileDialog openFileDialog1;
        private AntdUI.Input input1;
        private AntdUI.Input ftp_ip;
        private AntdUI.Input ftp_id;
        private AntdUI.Button ftp_connect;
        private AntdUI.Input ftp_port;
        private AntdUI.Input ftp_pwd;
        private TreeView ftp_tree;
        private AntdUI.Button button2;
    }
}
