﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadManagement;

namespace TCP_IP
{
    public class CloseThread
    {
        public CloseThread() { }

        public void closeThread()
        {
            ThreadList.readThread.Abort();
        }
    }
}
