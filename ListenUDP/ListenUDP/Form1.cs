using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenUDP
{
    public partial class frmUDPListener : Form
    {
        const int listenPort = 11000;
        UdpClient listener = new UdpClient(listenPort);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

        public frmUDPListener()
        {
            InitializeComponent();
        }

        private void frmUDPListener_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            lblListener.Text = "...";
            byte[] bytes = listener.Receive(ref groupEP);

            lblListener.Text = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
        }
    }
}
