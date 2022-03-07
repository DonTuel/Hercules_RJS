using System;
using System.Net;
using System.Net.Sockets;

namespace Hercules_RJS
{
    class HerculesConnection
    {
#region "  Properties"
        private Action<String> _AppendMethod;
        public Action<String> AppendMethod { get { return _AppendMethod; } }

        private TcpClient _Client;
        public TcpClient Client { get { return _Client; } }

        private NetworkStream _Stream;
        public NetworkStream Stream { get { return _Stream; } }

        private Int32 _LastReadLength;
        public Int32 LastReadLength { get { return _LastReadLength; } }

        private Boolean _Connected;
        public Boolean Connected { get { return _Connected; } }

        private String _ErrorMessage;
        public String ErrorMessage { get { return _ErrorMessage; } }

        private String _StringAddress;
        private IPAddress _IPAddress;
        private Int32 _Port;
        private readonly Byte[] _Buffer;
#endregion

        public HerculesConnection()
        {
            _AppendMethod = null;
            _Client = null;
            _Stream = null;
            _LastReadLength = -1;
            _StringAddress = null;
            _IPAddress = null;
            _Buffer = new byte[64];
            _Connected = false;
        }

        public HerculesConnection(String address, Int32 port, Action<String> append)
        {
            _Client = null;
            _Stream = null;
            _AppendMethod = append;
            _Port = port;
            _Buffer = new byte[64];
            _Connected = false;

            _StringAddress = address;
            _IPAddress = null;
            if (address.Contains("."))
            {
                String[] ipv4 = address.Split('.');
                if (ipv4.Length == 4)
                {
                    Byte[] b = new Byte[4];
                    for (int i = 0; i < 4; i++) { b[i] = Convert.ToByte(ipv4[i]); }
                    _IPAddress = new IPAddress(b);
                    _StringAddress = null;
                }
            }
        }

        public Boolean Connect()
        {
            if (_Client == null)
            {
                try
                {
                    _Client = new TcpClient();
                    if (_StringAddress == null) { _Client.Connect(_IPAddress, _Port); }
                    else { _Client.Connect(_StringAddress, _Port); }
                    _Stream = _Client.GetStream();
                    _Connected = true;
                }
                catch (Exception ex)
                {
                    _ErrorMessage = ex.Message;
                    _Connected = false;
                }
            }
            return _Connected;
        }

        public Boolean Connect(String address, Int32 port, Action<String> append)
        {
            _Client = null;
            _Stream = null;
            _AppendMethod = append;
            _Connected = false;
            _Port = port;

            _StringAddress = address;
            _IPAddress = null;
            if (address.Contains("."))
            {
                String[] ipv4 = address.Split('.');
                if (ipv4.Length == 4)
                {
                    Byte[] b = new Byte[4];
                    for (int i = 0; i < 4; i++) { b[i] = Convert.ToByte(ipv4[i]); }
                    _IPAddress = new IPAddress(b);
                    _StringAddress = null;
                }
            }

            return Connect();
        }

        public void Disconnect()
        {
            if (!(_Client == null)) { _Client.Close(); _Client.Dispose(); }
            _Client = null;
            _Stream = null;
            _Connected = false;
        }

        public void AwaitData()
        {
            _Stream.BeginRead(_Buffer, 0, _Buffer.Length, DoDataRead, this);
        }

        public void DoDataRead(IAsyncResult result)
        {
            HerculesConnection hc = (HerculesConnection)result.AsyncState;
            try
            {
                if ((hc._Stream != null) && (hc._Stream.CanRead))
                {
                    hc._LastReadLength = hc._Stream.EndRead(result);
                    if (hc._LastReadLength > 0)
                    {
                        String msg = System.Text.Encoding.ASCII.GetString(hc._Buffer);
                        hc._AppendMethod(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                hc._LastReadLength = -1;
                hc._AppendMethod(ex.Message);
            }
        }
    }
}
