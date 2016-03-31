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
            InitializeComponent();
            ProcessName = processName;
            ThreadsOfProcess = new ProcessThread[threadsOfProcess.Count];
            threadsOfProcess.CopyTo(ThreadsOfProcess, 0);
            Text = "Threads of " + ProcessName;
            threadGridView.ColumnCount = 4;
            threadGridView.Columns[0].HeaderText = "ThreadId";
            threadGridView.Columns[1].HeaderText = "StartAddress";
            threadGridView.Columns[2].HeaderText = "StartTime";
            threadGridView.Columns[3].HeaderText = "State";
            refreshList();
        }

        private void refreshList()
        {
            threadGridView.Rows.Clear();
            foreach (ProcessThread thread in ThreadsOfProcess)
            {
                object[] record = { thread.Id, thread.StartAddress, thread.StartTime, thread.ThreadState };
                threadGridView.Rows.Add(record);
            }
        }
    }
}
