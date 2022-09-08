using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_uygulamasi
{
    internal class ErrorLogger
    {
        public ArrayList logs = new ArrayList();

        public void log(Exception err)
        {
            logs.Add(err);
        }
    }
}
