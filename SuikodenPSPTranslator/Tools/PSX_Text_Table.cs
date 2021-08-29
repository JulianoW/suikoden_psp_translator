using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuikodenPSP.Tools
{
    public class PSX_Text_Table
    {
        public int table_id;
        public List<UInt32> pointers;
        public List<String> psx_text;
        public PSX_Text_Table()
        {
            pointers = new List<UInt32>();
            psx_text = new List<String>();
        }
    }
}
