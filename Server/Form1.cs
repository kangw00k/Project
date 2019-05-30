using PacketClassLibrary;
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
/* mysql 참조 추가  */
using MySql.Data.Common;
using MySql.Data.MySqlClient;
/*                  */
namespace Server {
    public partial class Form1 : Form {
        /*  MySQL Connection  */
        MySqlConnection mysql_connect;  
        /*                    */
        static int counter = 0;
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public NetworkStream m_netStream;      // 네트워크 스트림
        private byte[] sendBuffer = new byte[1024 * 4]; // 쓰기
        private byte[] readBuffer = new byte[1024 * 4]; // 읽기

        public int m_Port;
        public IPAddress m_Ip;

        public bool m_bStop;
        private TcpListener server;
        private TcpClient client;
        private Thread m_thCliAccept;
        public bool m_bConnect = false;

        public Login m_loginClass;
        public Form1() {
            InitializeComponent();

            m_thCliAccept = new Thread(ServerStart);
            m_thCliAccept.IsBackground = true;
            m_thCliAccept.Start();
        }

        public void ServerStart() {
            try {
                m_Ip = IPAddress.Parse("127.0.0.1");
                m_Port = 2222;

                server = new TcpListener(m_Ip, m_Port);
                server.Start();
                Message("클라이언트 접속 대기중...");

                while (true) {
                    try {
                        Receive();
                    } catch {
                        break;
                    }

                }
                
                
            } catch {

            }
           
        }

        public void Receive() {
            counter++;
            client = server.AcceptTcpClient();

            if (!client.Connected) {
                return;
            }

            int nRead = 0;
            m_netStream = client.GetStream();
            try {
                nRead = this.m_netStream.Read(readBuffer, 0, 1024 * 4);
            } catch(Exception e) {

                m_bConnect = false;
                m_netStream = null;
                return;
            }
            try {
                m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
                if(LoginCheck(m_loginClass.id, m_loginClass.pw)) {
                    Message(m_loginClass.id + " 로그인");
                }
                else {
                    Message("로그인 실패");
                }
                
            } catch {

            }

        }
        /*  로그인 계정 DB에서 체크    */
        private bool LoginCheck(string userID, string userPW) {
            m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
            bool login = false;
            string strSelect = "SELECT * FROM UserInfo WHERE ID like '" + m_loginClass.id + "' AND Pswd like '" + m_loginClass.pw + "';";
            MySqlCommand cmd = new MySqlCommand(strSelect, mysql_connect);
            cmd.Parameters.Add(new MySqlParameter(m_loginClass.id, userID));
            cmd.Parameters.Add(new MySqlParameter(m_loginClass.pw, userPW));
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows) {
                login = true;
                rdr.Close();
            }
            else
                rdr.Close();
            return login;
        }
        /*                             */
        public void Message(string msg) {
            this.Invoke(new MethodInvoker(delegate () {
                txtLog.AppendText(msg + "\r\n");
            }));
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*  MySQL 연결  */
            string str_connect = "Server=127.0.0.1; Database=Project; Uid=root; Pwd=1q2w3e4r!;";
            mysql_connect = new MySqlConnection(str_connect);
            mysql_connect.Open();
            /*              */
        }
    }
}
