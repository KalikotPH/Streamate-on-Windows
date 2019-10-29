using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamate
{
    [System.Serializable]
    public class ConnectInfo
    {
        public string contype;
        public string chanid;

        public ConnectInfo(string contypes, string chaids)
        {
            contype = contypes;
            chanid = chaids;
        }
    }
}
