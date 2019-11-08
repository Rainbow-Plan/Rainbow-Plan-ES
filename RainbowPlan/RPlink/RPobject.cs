using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPlink
{
    public class RPobject
    {
        private int Ins;

        public int ins
        {
            get { return Ins; }
            set { Ins = value; }
        }

        private String Id;

        public String id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Eng;

        public String eng
        {
            get { return Eng; }
            set { Eng = value; }
        }

        private String Cn;

        public String cn
        {
            get { return Cn; }
            set { Cn = value; }
        }

        public RPobject() { }
        public RPobject(int Ins) 
        {
            this.Ins = Ins;
        }
        public RPobject(int Ins,String Id,String Eng,String Cn)
        {
            this.Ins = Ins;
            this.Id = Id;
            this.Eng = Eng;
            this.Cn = Cn;
        }

    }
}
