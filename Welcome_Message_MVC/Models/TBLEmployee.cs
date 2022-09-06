using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Welcome_Message_MVC.Models
{
    public class TBLEmployee
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_city { get; set; }
        public DateTime dateofbirth { get; set; }

    }
}