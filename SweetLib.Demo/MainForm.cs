using System;
using System.Windows.Forms;
//using SweetLib.Utils.TaskBar;

namespace SweetLib.Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioProgressCheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton) sender;
            if(!radio.Checked)
                return;
            
            int state = Convert.ToInt32(radio.Tag);
            /*TaskBarProgress.TaskbarStates realState = (TaskBarProgress.TaskbarStates)Convert.ToInt32(radio.Tag);
            TaskBarProgress.SetState(Handle, TaskBarProgress.TaskbarStates.Indeterminate);*/
        }

        private void tbrTaskBarProgress_ValueChanged(object sender, EventArgs e)
        {
            //TaskBarProgress.SetValue(Handle, tbrTaskBarProgress.Value, tbrTaskBarProgress.Maximum);
        }
    }
}
