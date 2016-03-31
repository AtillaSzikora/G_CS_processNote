//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessNote
{
    public partial class ThreadsForm : Form
    {
        private string ProcessName;
        private ProcessThread[] ThreadsOfProcess;

        public ThreadsForm(string processName, ProcessThreadCollection threadsOfProcess)
        {
            ProcessName = processName;
            ThreadsOfProcess = new ProcessThread[threadsOfProcess.Count];
            threadsOfProcess.CopyTo(ThreadsOfProcess, 0);
            InitializeComponent();
            Text = "Threads of " + ProcessName;
            refreshList();
        }

        private void refreshList()
        {
            threadsBox.Items.AddRange(ThreadsOfProcess);
            Refresh();
        }
    }
}
