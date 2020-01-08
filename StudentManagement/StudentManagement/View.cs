using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class View
    {
        public int ID { get; set; }
        public string FULLNAME { get; set; }
        public System.DateTime BIRTHDAY { get; set; }
        public string GENDER { get; set; }
        public string CLASS{ get; set; }

        public View (STUDENT stu)
        {
            this.ID = stu.ID;
            this.FULLNAME = stu.FULLNAME;
            this.BIRTHDAY = stu.BIRTHDAY;
            string gen = "Female";
            if (stu.GENDER ==  true)
            {
                gen = "Male";
            }
            this.GENDER = gen;
            this.CLASS = stu.CLASS.CLASSNAME;
        }
    }
}
