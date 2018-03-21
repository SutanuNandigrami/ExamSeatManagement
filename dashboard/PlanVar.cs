using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard
{
    public class PlanVar
    {
        PlanVar() { }
        public string PaperCode { get; set; }
        public string Sem { get; set; }
        public string Subject { get; set; }
        public string Dept { get; set; }
        public string RoomNo { get; set; }
        public string Duration { get; set; }
        //public DateTime Date { get; set; }
        public string RollS { get; set; }
        public string RollE { get; set; }
        public int capasity { get; set; }
    }
}
