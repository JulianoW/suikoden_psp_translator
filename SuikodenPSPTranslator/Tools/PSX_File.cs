using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuikodenPSP.Tools
{
    public class PSX_File
    {
        public string filename { get; set; }
        public List<PSX_Text_Table> tables { get; set; }
        public PSX_File()
        {
            tables = new List<PSX_Text_Table>();
        }
    }

}
