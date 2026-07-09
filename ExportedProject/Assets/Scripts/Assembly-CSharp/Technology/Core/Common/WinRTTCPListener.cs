using System.Net.Sockets;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E0B")]
	public class WinRTTCPListener
	{
		[Token(Token = "0x400425B")]
		[FieldOffset(Offset = "0x10")]
		private TcpListener _listener;

		[Token(Token = "0x6005646")]
		[Address(RVA = "0x87F4E0", Offset = "0x87F4E0", VA = "0x87F4E0")]
		public WinRTTCPListener(string ipAddress, int port)
		{
		}

		[Token(Token = "0x6005647")]
		[Address(RVA = "0x87F5A0", Offset = "0x87F5A0", VA = "0x87F5A0")]
		public void Start()
		{
		}

		[Token(Token = "0x6005648")]
		[Address(RVA = "0x87F5BC", Offset = "0x87F5BC", VA = "0x87F5BC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6005649")]
		[Address(RVA = "0x87F5D8", Offset = "0x87F5D8", VA = "0x87F5D8")]
		public bool Pending()
		{
			return default(bool);
		}

		[Token(Token = "0x600564A")]
		[Address(RVA = "0x87F5F4", Offset = "0x87F5F4", VA = "0x87F5F4")]
		public WinRTTCPClient AcceptTcpClient()
		{
			return null;
		}
	}
}
