using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        public void SetupValues(int min,int max,int value)
        {
            progressBar.Minimum = min;
            progressBar.Maximum = max;
            progressBar.Value = value;
        }

        public void IncrementProgress(int value)
        {
            progressBar.Increment(value);
        }

        public void SetProgress(int value)
        {
            progressBar.Value = value;
        }
    }
}
