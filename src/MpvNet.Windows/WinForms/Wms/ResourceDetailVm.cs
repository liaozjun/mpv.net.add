using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MpvNet.Windows.WinForms.Wms
{ 
     public class ResourceDetailVm : AntdUI.NotifyProperty
    {
        AntdUI.CellImage _img;
        public AntdUI.CellImage img
        {
            get => _img;
            set
            {
                _img = value;
                OnPropertyChanged();
            }
        }
        public string vodPlayUrl { get; set; }
        public long typeId { get; set; }
        public string vodPic { get; set; }

        string _typeName;
        public string typeName
        {
            get => _typeName;
            set
            {
                if (_typeName == value) return;
                _typeName = value;
                OnPropertyChanged();
            }
        }

        string _vodName;
        public string vodName
        {
            get => _vodName;
            set
            {
                if (_vodName == value) return;
                _vodName = value;
                OnPropertyChanged();
            }
        }

        string _vodRemarks;
        public string vodRemarks
        {
            get => _vodRemarks;
            set
            {
                if (_vodRemarks == value) return;
                _vodRemarks = value;
                OnPropertyChanged();
            }
        }

        string _vodArea;
        public string vodArea
        {
            get => _vodArea;
            set
            {
                if (_vodArea == value) return;
                _vodArea = value;
                OnPropertyChanged();
            }
        }

        string _vodTime;
        public string vodTime
        {
            get => _vodTime;
            set
            {
                if (_vodTime == value) return;
                _vodTime = value;
                OnPropertyChanged();
            }
        }

        string _vodContent;
        public string vodContent
        {
            get => _vodContent;
            set
            {
                if (_vodContent == value) return;
                _vodContent = value;
                OnPropertyChanged();
            }
        }
        AntdUI.CellLink[] _btns;
        public AntdUI.CellLink[] btns
        {
            get => _btns;
            set
            {
                _btns = value;
                OnPropertyChanged();
            }
        }
        public enum TaskOptEnum
        {
            Play,
            Detail,
            Tomp4,
            Delete,
            Goon,
        }
        public void init()
        {
            var l = new List<AntdUI.CellLink>();
            //l.Add(new AntdUI.CellButton(TaskOptEnum.Play.ToString(), "播放", AntdUI.TTypeMini.Primary) { BorderWidth = 1 });
            l.Add(new AntdUI.CellButton(TaskOptEnum.Detail.ToString(), "查看", AntdUI.TTypeMini.Primary) { BorderWidth = 1 });
            //l.Add(new AntdUI.CellButton(TaskOptEnum.Detail.ToString(), "详情", AntdUI.TTypeMini.Success) { BorderWidth = 1 });

            //l.Add(new AntdUI.CellButton(TaskOptEnum.Tomp4.ToString(), "转MP4", AntdUI.TTypeMini.Default) { BorderWidth = 1, Enabled = this.toMp4 == "是" ? false : true });
            //l.Add(new AntdUI.CellButton(TaskOptEnum.Delete.ToString(), "删除", AntdUI.TTypeMini.Default) { BorderWidth = 1 });

            _btns = l.ToArray();

            if (!string.IsNullOrWhiteSpace(vodPic))
            {
                try
                {
                    Uri uritmp = new Uri(vodPic);
                    var filename = HttpUtility.UrlDecode(uritmp.Segments.Last());
                    Image img = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics", $"{typeId}", filename));

                    _img = new AntdUI.CellImage(img);
                    _img.Size = new Size(96, 126);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

            }
            //     new AntdUI.CellImage(Properties.Resources.bg1)

        }

    }


}
