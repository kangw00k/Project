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
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Client {
    public partial class MainForm : Form {

        public NetworkStream m_Stream;      // 네트워크 스트림
        public TcpClient m_Client;

        public int m_Port;                    // 포트번호
        public IPAddress m_Ip;
        public bool m_bConnect = false;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        public Login m_LoginClass;
        public string m_cID;
        public string m_cNickName;
        public int m_cWinNum;
        public int m_cLoseNum;
        

        public MainForm() {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e) {
            pnlJoin.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            m_Ip = IPAddress.Parse("127.0.0.1");
            m_Port = 2222;

            m_Client = new TcpClient();
            try {
                m_Client.Connect(m_Ip, m_Port);
                m_bConnect = true;
            } catch {
                m_bConnect = false;
                MessageBox.Show("서버와 연결이 되지 않았습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            m_Stream = m_Client.GetStream();
            if (!this.m_bConnect) {
                return;
            }

            Login login = new Login();
            login.Type = (int)PacketType.로그인;
            login.id = txtLoginID.Text;
            login.pw = txtLoginPW.Text;

            Packet.Serialize(login).CopyTo(this.sendBuffer, 0);
            this.Send();
            pnlWaitScreen.Visible = true;
            //this.Receive();

            
        }

        public void Send() {
            this.m_Stream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_Stream.Flush();

            for(int i = 0; i < 1024 * 4; i++) {
                this.sendBuffer[i] = 0;
            }
        }
        
        public void Receive() {
            if (!this.m_bConnect) {
                return;
            }
            int nread;

            try {
                nread = 0;
                nread = this.m_Stream.Read(readBuffer, 0, 1024 * 4);
            } catch {
                this.m_bConnect = false;
                this.m_Stream = null;
            }
            try {
                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type) {
                    case ((int)PacketType.로그인): {
                            m_LoginClass = (Login)Packet.Desserialize(this.readBuffer);

                            if (!m_LoginClass.bLogin) {
                                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtLoginID.Text = "";
                                txtLoginPW.Text = "";
                            } else {
                                m_cID = m_LoginClass.id;
                                m_cNickName = m_LoginClass.nickName;
                                m_cWinNum = m_LoginClass.winNum;
                                m_cLoseNum = m_LoginClass.loseNum;

                                pnlWaitScreen.Visible = true;

                            }


                            break;
                        }
                }
            }catch {

            }
        }

        private void btnJoinCancel_Click(object sender, EventArgs e)
        {
            pnlJoin.Visible = false;
        }
    }
}
