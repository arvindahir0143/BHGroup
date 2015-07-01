using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHGroup.Areas.Admin.ViewModels
{
    public class LetterModel
    {
        public DateTime Date { set; get; }
        public string Name { set; get; }
        public string Address{ set; get; }
        public int Qty { set; get; }
        public string plottype { set; get; }
        public string PlotDesc { set; get; }
        public string phoneno { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}