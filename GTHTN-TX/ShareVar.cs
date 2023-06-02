using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Visa;
using Ivi.Visa;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace GTHTN_TX
{
    class ShareVar
    {
        //IP of DL550
        static public MessageBasedSession Visa_DL550 = null;
        static public string IPaddress_DL550 = "TCPIP0::169.254.124.0::10733::SOCKET";
        static public bool DL550_State = false;

        // IP of TTi-1908P
        static public MessageBasedSession Visa_1908P = null;
        static public string IPaddress_1908P = "TCPIP0::169.254.148.32::9221::SOCKET";
        //static public string IPaddress_1908P = "TCPIP0::192.168.1.100::9221::SOCKET";
        static public bool TTi1908P_State = false;

        // IP of DSOX2022A
        static public MessageBasedSession Visa_DSOX2022A = null;
        static public string IPaddress_DSOX2022A = "TCPIP0::a-dx2022a-10220.local::5025::SOCKET";
        static public bool DSOX2022A_State = false;

        // IP of XLTT
        static public Int32 localPort_XLTT = 1024;
        static public string IP_XLTT = "169.254.1.7";
        static public UdpClient udpXLTT = null;
        static public bool XLTT_State = false;

        // Data of XLTT
        static public Byte[] SendData = new byte[] { 0xAA, 0x55, 0x01, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x23 };

        // Rada Main Targe
        /// Rada Kolchuga
        static public uc_Kolchuga.uc_Kolchuga_M0 uc_Kolchuga_M0;//=new uc_Kolchuga.uc_Kolchuga_M0() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
    }
}
