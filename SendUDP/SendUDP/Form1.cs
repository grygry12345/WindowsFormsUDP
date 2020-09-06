using System;
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

namespace SendUDP
{
    public partial class frmSend : Form
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        static IPAddress broadcast = IPAddress.Parse("192.168.1.255");
        IPEndPoint ep = new IPEndPoint(broadcast, 11000);

        public frmSend()
        {
            InitializeComponent();
        }

        private void SendUDP()
        {
            byte[] sendbuf = Encoding.ASCII.GetBytes(txtInfo.Text);

            s.SendTo(sendbuf, ep);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(SendUDP));
            t.Start();
        }

    }
}
