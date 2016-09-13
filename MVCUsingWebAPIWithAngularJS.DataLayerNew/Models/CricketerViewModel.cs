using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCUsingWebAPIWithAngularJS.DataLayer.Models
{
    public class CricketerViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ODI { get; set; }
        public int? Test { get; set; }
        public Boolean Update { get; set; }
    }

    public class CricketerDetailViewModel
    {
        public int Id { get; set; }
        public int Cricketer_Id { get; set; }
        public string Team { get; set; }
        public int ODI_Runs { get; set; }
        public int Test_Runs { get; set; }
        public int Wickets { get; set; }
    }
    public class CricketerODIStatsViewModel
    {
        public int Id { get; set; }
        public int Cricketer_Id { get; set; }
        public string Name { get; set; }
        public int Half_Century { get; set; }
        public int Century { get; set; }
    }
    public class CricketerTestStatsViewModel
    {
        public int Id { get; set; }
        public int Cricketer_Id { get; set; }
        public string Name { get; set; }
        public int Half_Century { get; set; }
        public int Century { get; set; }
    }
}
