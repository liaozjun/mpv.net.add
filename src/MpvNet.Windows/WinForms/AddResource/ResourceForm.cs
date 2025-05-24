using MpvNet.Windows.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MpvNet.Windows.WinForms.AddResource
{
    public partial class ResourceForm : Form
    {
        public ResourceForm()
        {
            InitializeComponent();
            UpdateDarkMode();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += ResourceForm_Load;
        }

        private void ResourceForm_Load(object? sender, EventArgs e)
        { 
        }

        void UpdateDarkMode()
        {
            if (Environment.OSVersion.Version >= new Version(10, 0, 18985))
                DwmSetWindowAttribute(Handle, 20, new[] { Theme.DarkMode ? 1 : 0 }, 4);  // DWMWA_USE_IMMERSIVE_DARK_MODE = 20
        }
        [DllImport("DwmApi")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
    }
}
