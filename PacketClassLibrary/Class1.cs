using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
public enum PacketType {
    초기화 = 0,
    로그인,

}

namespace PacketClassLibrary
{
    public class Class1{

    }
    [Serializable]
    public class Packet {
        public int Length;
        public int Type;

        public Packet() {
            this.Length = 0;
            this.Type = 0;
        }

        public static byte[] Serialize(Object o) {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);

            return ms.ToArray();
        }

        public static Object Desserialize(byte[] bt) {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt) {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();

            return obj;
        }
    }

    [Serializable]
    public class Initialize : Packet {
        public int Data = 0;
    }

    [Serializable]
    public class Login : Packet{
        public string id;
        public string pw;
        public string nickName;
        public bool bLogin;
        public int winNum;
        public int loseNum;

        public Login() {
            id = null;
            pw = null;
            nickName = null;
            winNum = 0;
            loseNum = 0;
        }
    }

    [Serializable]
    public class PathInfo : Packet {    // 경로를 보내거나 파일 또는 디렉토리 정보를 
        public string path;             // 송수신 하는 패킷
        public string eventName;
        public DirectoryInfo dir;
        public DirectoryInfo[] subDirInfo;
        public FileInfo fiInfo;
        public FileInfo[] fiArray;

        public PathInfo() {
            this.path = null;
            this.eventName = null;
            this.dir = null;
            this.subDirInfo = null;
            this.fiInfo = null;
            this.fiArray = null;
        }
    }

    [Serializable]
    public class FDownload : Packet {   // 다운로드 파일의 버퍼를 송수신하는 패킷
        public int size;
        public byte[] buffer;

        public FDownload() {
            size = 0;
            buffer = new byte[1024 * 2];
        }
    }
}
