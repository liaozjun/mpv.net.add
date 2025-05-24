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
            pagination1 = new AntdUI.Pagination();
            splitter1 = new AntdUI.Splitter();
            table1 = new AntdUI.Table();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            pageHeader1.Location = new System.Drawing.Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.Size = new System.Drawing.Size(1201, 23);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "pageHeader1";
            // 
            // pagination1
            // 
            pagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            pagination1.Location = new System.Drawing.Point(0, 716);
            pagination1.Name = "pagination1";
            pagination1.Size = new System.Drawing.Size(1201, 23);
            pagination1.TabIndex = 1;
            pagination1.Text = "pagination1";
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitter1.Location = new System.Drawing.Point(0, 23);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(table1);
            splitter1.Size = new System.Drawing.Size(1201, 693);
            splitter1.SplitterDistance = 862;
            splitter1.TabIndex = 2;
            // 
            // table1
            // 
            table1.Location = new System.Drawing.Point(126, 73);
            table1.Name = "table1";
            table1.Size = new System.Drawing.Size(496, 373);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // ResourceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1201, 739);
            Controls.Add(splitter1);
            Controls.Add(pagination1);
            Controls.Add(pageHeader1);
            Name = "ResourceForm";
            Text = "ResourceForm";
            splitter1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Pagination pagination1;
        private AntdUI.Splitter splitter1;
        private AntdUI.Table table1;
    }
}