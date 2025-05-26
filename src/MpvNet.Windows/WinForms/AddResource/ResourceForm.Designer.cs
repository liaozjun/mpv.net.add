namespace MpvNet.Windows.WinForms.AddResource
{
    partial class ResourceForm
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
            pageHeader1 = new AntdUI.PageHeader();
            btnGet = new AntdUI.Button();
            selectHourGet = new AntdUI.Select();
            SearchTxt = new AntdUI.Input();
            pagination1 = new AntdUI.Pagination();
            splitter1 = new AntdUI.Splitter();
            table1 = new AntdUI.Table();
            flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            pageHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.BackColor = System.Drawing.Color.White;
            pageHeader1.Controls.Add(btnGet);
            pageHeader1.Controls.Add(selectHourGet);
            pageHeader1.Controls.Add(SearchTxt);
            pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            pageHeader1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            pageHeader1.Location = new System.Drawing.Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.Size = new System.Drawing.Size(1201, 40);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "";
            // 
            // btnGet
            // 
            btnGet.BorderWidth = 1F;
            btnGet.Dock = System.Windows.Forms.DockStyle.Left;
            btnGet.IconSvg = "ShareAltOutlined";
            btnGet.JoinMode = AntdUI.TJoinMode.Right;
            btnGet.Location = new System.Drawing.Point(119, 0);
            btnGet.Name = "btnGet";
            btnGet.Size = new System.Drawing.Size(92, 40);
            btnGet.TabIndex = 2;
            btnGet.Text = "获取";
            btnGet.Click += btnGet_Click;
            // 
            // selectHourGet
            // 
            selectHourGet.Dock = System.Windows.Forms.DockStyle.Left;
            selectHourGet.Items.AddRange(new object[] { "一天", "一周", "一月" });
            selectHourGet.JoinMode = AntdUI.TJoinMode.Left;
            selectHourGet.Location = new System.Drawing.Point(0, 0);
            selectHourGet.Name = "selectHourGet";
            selectHourGet.Size = new System.Drawing.Size(119, 40);
            selectHourGet.TabIndex = 3;
            selectHourGet.Text = "一天";
            // 
            // SearchTxt
            // 
            SearchTxt.Dock = System.Windows.Forms.DockStyle.Right;
            SearchTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            SearchTxt.Location = new System.Drawing.Point(632, 0);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "输入内容";
            SearchTxt.PrefixSvg = "SearchOutlined";
            SearchTxt.Size = new System.Drawing.Size(569, 40);
            SearchTxt.TabIndex = 0;
            SearchTxt.KeyUp += SearchTxt_KeyUp;
            // 
            // pagination1
            // 
            pagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            pagination1.Location = new System.Drawing.Point(0, 699);
            pagination1.Name = "pagination1";
            pagination1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            pagination1.Size = new System.Drawing.Size(1201, 40);
            pagination1.TabIndex = 1;
            pagination1.Text = "pagination1";
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitter1.Location = new System.Drawing.Point(0, 40);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(table1);
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(flowLayoutPanel1);
            splitter1.Panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            splitter1.Size = new System.Drawing.Size(1201, 659);
            splitter1.SplitterDistance = 862;
            splitter1.TabIndex = 2;
            // 
            // table1
            // 
            table1.Dock = System.Windows.Forms.DockStyle.Fill;
            table1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            table1.Location = new System.Drawing.Point(0, 0);
            table1.Name = "table1";
            table1.Size = new System.Drawing.Size(862, 659);
            table1.TabIndex = 0;
            table1.Text = "table1";
            table1.CellClick += table1_CellClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(335, 659);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ResourceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1201, 739);
            Controls.Add(splitter1);
            Controls.Add(pagination1);
            Controls.Add(pageHeader1);
            Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            Name = "ResourceForm";
            Text = "ResourceForm";
            pageHeader1.ResumeLayout(false);
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Pagination pagination1;
        private AntdUI.Splitter splitter1;
        private AntdUI.Table table1;
        private AntdUI.Input SearchTxt;
        private AntdUI.Button btnGet;
        private AntdUI.Select selectHourGet;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
    }
}