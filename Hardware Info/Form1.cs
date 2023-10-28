using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeviceInfo.DeviceProcess;
namespace Hardware_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmac_Click(object sender, EventArgs e)
        {
            mactxt.Text = Mac();
        }

        private void btnip_Click(object sender, EventArgs e)
        {
            iptxt.Text = IP();
        }

        private void btncpu_Click(object sender, EventArgs e)
        {
            cputxt.Text = getCPUInfo();
        }

        private void btnhdd_Click(object sender, EventArgs e)
        {
            hddtxt.Text = getHddSerial();
        }

        private void btnram_Click(object sender, EventArgs e)
        {
            ramtxt.Text = getRamSize();
        }

        private void btnvideo_Click(object sender, EventArgs e)
        {
            videotxt.Text = getVideoControllerInfo();
        }
    }
}
