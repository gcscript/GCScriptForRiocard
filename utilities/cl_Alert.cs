using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilities
{
    public static class cl_Alert
    {
        public static void Alert(string msg, frm_Alert.enmType type)
        {
            frm_Alert frm = new frm_Alert();
            frm.showAlert(msg, type);
        }
    }
}
