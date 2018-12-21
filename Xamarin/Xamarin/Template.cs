using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamarin
{
    public class Template
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Iname { get; set; }
        public int Tmoney { get; set; }
    }

}
