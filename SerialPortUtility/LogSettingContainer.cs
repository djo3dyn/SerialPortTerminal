using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialPortUtility
{
    public class LogSettingContainer
    {
       
        public string rxName { get; set; }
        public string txName { get; set; }
        public bool wordwrapEn { get; set; }
        public bool txLogEn { get; set; }
        public bool infoEn { get; set; }
        public bool rxNameEn { get; set; }
        public bool txNameEn { get; set; }
        public Color rxColor { get; set; }
        public Color txColor { get; set; }
        public Color infColor { get; set; }
        public Font rxFont { get; set; }
        public Font txFont { get; set; }
        public Font infFont { get; set; }

    }
}
