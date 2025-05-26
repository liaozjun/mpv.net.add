using MpvNet.Windows.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpvNet.Windows.WinForms.Dtos
{
    public class ResourcePageResult
    {
        public int code { get; set; }//": 1,
        public string? msg { get; set; }//: "数据列表",
        public int page { get; set; }//": "1",
        public int pagecount { get; set; }//": 4,
        public int limit { get; set; }//: "20",
        public int total { get; set; }//": 61,
        public List<ResourceDetail> list { get; set; }
    }
}
