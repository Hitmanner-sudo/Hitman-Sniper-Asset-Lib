using System.IO;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E09")]
	public class WinRTTCPClient
	{
		[Token(Token = "0x4004259")]
		[FieldOffset(Offset = "0x10")]
		private TcpClient _socket;

		[Token(Token = "0x17000B71")]
		public bool Connected
		{
			[Token(Token = "0x6005638")]
			[Address(RVA = "0x87F1A4", Offset = "0x87F1A4", VA = "0x87F1A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B72")]
		public int SendTimeout
		{
			[Token(Token = "0x6005639")]
			[Address(RVA = "0x87F1C0", Offset = "0x87F1C0", VA = "0x87F1C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600563A")]
			[Address(RVA = "0x87F1DC", Offset = "0x87F1DC", VA = "0x87F1DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000B73")]
		public int ReceiveTimeout
		{
			[Token(Token = "0x600563B")]
			[Address(RVA = "0x87F1F8", Offset = "0x87F1F8", VA = "0x87F1F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600563C")]
			[Address(RVA = "0x87F214", Offset = "0x87F214", VA = "0x87F214")]
			set
			{
			}
		}

		[Token(Token = "0x600563D")]
		[Address(RVA = "0x87F230", Offset = "0x87F230", VA = "0x87F230")]
		public WinRTTCPClient()
		{
		}

		[Token(Token = "0x600563E")]
		[Address(RVA = "0x87F298", Offset = "0x87F298", VA = "0x87F298")]
		public WinRTTCPClient(TcpClient socket)
		{
		}

		[Token(Token = "0x600563F")]
		[Address(RVA = "0x87F2C4", Offset = "0x87F2C4", VA = "0x87F2C4")]
		public void Connect(string hostName, int port)
		{
		}

		[Token(Token = "0x6005640")]
		[Address(RVA = "0x87F2E0", Offset = "0x87F2E0", VA = "0x87F2E0")]
		public Stream GetInputStream()
		{
			return null;
		}

		[Token(Token = "0x6005641")]
		[Address(RVA = "0x87F2FC", Offset = "0x87F2FC", VA = "0x87F2FC")]
		public Stream GetOutputStream()
		{
			return null;
		}

		[Token(Token = "0x6005642")]
		[Address(RVA = "0x87F318", Offset = "0x87F318", VA = "0x87F318")]
		public void Close()
		{
		}
	}
}
