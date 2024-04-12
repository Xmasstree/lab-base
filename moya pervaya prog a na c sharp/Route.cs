using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_pervaya_prog_a_na_c_sharp
{
    class Route
    {
        private string start_point;
        private string finish_point;
        private string number;


        public Route(string start_point, string finish_point, string number)
        {
            this.start_point = start_point;
            this.finish_point = finish_point;
            this.number = number;
        }

        public Route()
        {
            start_point = "Sortym";
            finish_point = "База Отдыха";
            number = "11F";
        }


        public string START_POINT
        {
            get { return start_point; }
            set {start_point  = value; }
        }

        public string FINISH_POINT
        {
            get { return finish_point; }
            set {finish_point  = value; }
        }


        public string NUMBER
        {
            get { return number; }
            set { number = value; }
        }
        
    }

  
}
