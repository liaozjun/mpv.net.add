using AntdUI;
using AntdUI.In;
using Flurl.Http;
using Mapster;
using MpvNet.Windows.Helper;
using MpvNet.Windows.UI;
using MpvNet.Windows.WinForms.Dtos;
using MpvNet.Windows.WinForms.Models;
using MpvNet.Windows.WinForms.Wms;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace MpvNet.Windows.WinForms.AddResource
{
    public partial class ResourceForm : Form
    {
        //BackgroundWorker worker;
        public ResourceForm()
        {

            InitializeComponent();
            UpdateDarkMode();
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += ResourceForm_Load;
            //worker = new BackgroundWorker();
            //worker.DoWork += Worker_DoWork;
            //worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            //worker.WorkerSupportsCancellation = true;
            //worker.ProgressChanged += Worker_ProgressChanged;
            //worker.WorkerReportsProgress = true;
            this.pagination1.ValueChanged += Pagination1_ValueChanged;
            this.FormClosing += ResourceForm_FormClosing;
            
        }

        private void ResourceForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (btnGet.Loading)
            {
                e.Cancel = true;
                MessageBox.Show("媒体获取中...稍后再关闭");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        { 
            base.OnFormClosed(e);
        }

        private void Pagination1_ValueChanged(object sender, PagePageEventArgs e)
        {
            table1.DataSource = this.getData();
        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResourceForm_Load(object? sender, EventArgs e)
        {
            table1.Columns = new AntdUI.ColumnCollection {
                //new AntdUI.ColumnCheck("check").SetFixed(),
                new AntdUI.Column("img", "图片").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("vodName", "名称").SetWidth("300").SetLocalizationTitleID("Table.Column."),
                  new AntdUI.Column("typeName", "类型").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("vodRemarks", "备注").SetWidth("200").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("vodArea", "区域").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("vodContent", "内容").SetWidth("600").SetLineBreak(true).SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("vodTime", "时间").SetLocalizationTitleID("Table.Column."),
                //new AntdUI.Column("btns", "操作").S etWidth("200").SetLocalizationTitleID("Table.Column."),
            };


            pagination1.PageSizeOptions = new int[] { 10, 20, 30, 50, 100 };
            pagination1.PageSize = 10;
            pagination1.Current = 1;

            table1.DataSource = this.getData();
        }

        List<ResourceDetailVm> getData()
        {
            int totalNumber = 0;
            int totalPage = 0;
            List<ResourceDetail> zy1Details = DbHelper.getIns().Queryable<ResourceDetail>()
                .WhereIF(!string.IsNullOrWhiteSpace(SearchTxt.Text), p => p.vodName.Contains(SearchTxt.Text))
                .OrderByDescending(p => p.vodTime)
                .ToPageList(pagination1.Current, pagination1.PageSize, ref totalNumber, ref totalPage);
            pagination1.Total = totalNumber;

            var dtolist = zy1Details.Adapt<List<ResourceDetailVm>>();
            dtolist.ForEach(p => p.init());
            return dtolist;
        }

        void UpdateDarkMode()
        {
            if (Environment.OSVersion.Version >= new Version(10, 0, 18985))
                DwmSetWindowAttribute(Handle, 20, new[] { Theme.DarkMode ? 1 : 0 }, 4);  // DWMWA_USE_IMMERSIVE_DARK_MODE = 20
        }
        [DllImport("DwmApi")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        int HourGet()
        {
            int h = 24;
            if (selectHourGet.Text == "一天")
            {
                h = 24;
            }
            else if (selectHourGet.Text == "一周")
            {
                h = 24 * 7;
            }
            else if (selectHourGet.Text == "一月")
            {
                h = 24 * 30;
            }

            return h;
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            btnGet.Loading = true;
            AntdUI.ITask.Run(() =>
            {
                try
                {
                    int h = HourGet();
                    int pg = 1;
                    string url = "http://json.heimuer.xyz/api.php/provide/vod/?ac=list&ac=videolist&t=&pg={0}&h={1}&ids=&wd=";
                    string p1 = string.Format(url, pg, h);
                    ResourcePageResult ret = p1.WithHeader("Content-Type", "text/html;charset=utf-8")
                        .WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.6261.95 Safari/537.36")
                        .GetJsonAsync<ResourcePageResult>().Result;

                    if (ret.list.Count <= 0)
                    {
                        return;
                    }

                    string picsDic = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics");
                    if (!Directory.Exists(picsDic))
                    {
                        Directory.CreateDirectory(picsDic);
                    }


                    SqlSugarClient db = DbHelper.getIns();

                    int tick1 = 0;
                    foreach (ResourceDetail item in ret.list)
                    {
                        this.ResourceDetailProcess(db, item, picsDic);
                        tick1++;
                        Invoke(new Action(() =>
                        {
                            string info = $" 第{pg}页,{tick1}/{ret.list.Count} 条,{item.vodName}";
                            this.Text = info;
                        }));
                    }
                    int pageCount = ret.pagecount;
                    for (pg = 2; pg <= pageCount; pg++)
                    {
                        p1 = string.Format(url, pg, h);
                        ResourcePageResult ret2 = p1.WithHeader("Content-Type", "text/html;charset=utf-8")
                        .WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.6261.95 Safari/537.36")
                        .GetJsonAsync<ResourcePageResult>().Result;

                        int tick = 0;
                        foreach (ResourceDetail item in ret2.list)
                        {
                            this.ResourceDetailProcess(db, item, picsDic);
                            tick++;
                            Invoke(new Action(() =>
                            {
                                string info = $" 第{pg}/{pageCount}页,{tick}/{ret2.list.Count} 条,{item.vodName}";
                                this.Text = info;
                            }));
                        }
                    }
                    Invoke(new Action(() =>
                    {
                        this.Text = $"共{pageCount}页，已完成";
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }, () =>
            {
                pagination1.Current = 1;
                table1.DataSource = this.getData();
                btnGet.Loading = false;
            });
        }
        void ResourceDetailProcess(SqlSugarClient db, ResourceDetail item, string picsDic)
        {
            string picDic = Path.Combine(picsDic, $"{item.typeId}");
            if (!Directory.Exists(picDic))
            {
                Directory.CreateDirectory(picDic);
            }
            if (!string.IsNullOrWhiteSpace(item.vodPic))
            {
                Uri uritmp = new Uri(item.vodPic);
                var filename = HttpUtility.UrlDecode(uritmp.Segments.Last());

                string filePath = Path.Combine(picDic, filename);
                if (!File.Exists(filePath))
                {
                    try
                    {
                        item.vodPic.DownloadFileAsync(picDic).Wait();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            if (db.Queryable<ResourceDetail>().Count(p => p.vodId == item.vodId) != 0)
            {
                db.Updateable<ResourceDetail>(item).ExecuteCommand();
            }
            else
            {
                db.Insertable<ResourceDetail>(item).ExecuteCommand();
            }
        }

        private void SearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pagination1.Current = 1;
                table1.DataSource = this.getData();
            }
        }
        public record playInfo(string pname, string name, string purl);
        private void table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            AntdUI.Table table = sender as AntdUI.Table;
            //MessageBox.Show($"{table.SelectedIndex}");
            List<ResourceDetailVm> dtos = table.DataSource as List<ResourceDetailVm>;
            var zy1detailDto = dtos[table.SelectedIndex - 1];
            string[] jis = zy1detailDto.vodPlayUrl.Split("#");
            if (jis.Length > 0)
            {
                List<playInfo?> playInfoList = jis.Select(p =>
                {
                    string[] ji = p.Split("$");
                    if (ji.Length > 1)
                    {
                        return new playInfo(zy1detailDto.vodName, ji[0], ji[1]);
                    }
                    return null;
                }).Where(p => p != null).Reverse().ToList();
                flowLayoutPanel1.Controls.Clear();
                foreach (var pi in playInfoList)
                {
                    var btn = new AntdUI.Button();
                    btn.Text = pi.name;
                    btn.Height = 40;
                    btn.Width = 100;
                    btn.Tag = pi;
                    btn.Click += Play;
                    flowLayoutPanel1.Controls.Add(btn);
                }

            }
        }

        private void Play(object? sender, EventArgs e)
        {
            AntdUI.Button btn = (AntdUI.Button)sender;
            playInfo pi = btn.Tag as playInfo;
            if (MainForm.Instance != null)
            {
                //MainForm.Instance.Invoke(() =>
                //{
                    MainForm.Instance.Title = $"{pi.pname},{pi.name}";
                    MainForm.Instance.BringToFront();

                //});
                
                Player.CommandV("loadfile", pi.purl);
            }
        }
    }
}
