using System;
using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Core.Logging;

namespace Technology.Remoting
{
	[Token(Token = "0x2000C23")]
	public sealed class RemoteServer : IDisposable
	{
		[Token(Token = "0x4003C6A")]
		public const string COMMAND_SEPARATOR = "¬";

		[Token(Token = "0x4003C6B")]
		public const char COMMAND_SEPARATOR_CHAR = '¬';

		[Token(Token = "0x4003C6C")]
		public const string COMMAND_LOG = "L";

		[Token(Token = "0x4003C6D")]
		public const string COMMAND_PING = "P";

		[Token(Token = "0x4003C6E")]
		public const int LISTEN_PORT = 37337;

		[Token(Token = "0x4003C6F")]
		public const int RECEIVE_TIMEOUT = 300000;

		[Token(Token = "0x4003C70")]
		[FieldOffset(Offset = "0x10")]
		private WinRTTCPClient _client;

		[Token(Token = "0x4003C71")]
		[FieldOffset(Offset = "0x18")]
		private WinRTTCPListener _listener;

		[Token(Token = "0x4003C72")]
		[FieldOffset(Offset = "0x20")]
		public Action<LogType, string, string> OnReceiveLog;

		[Token(Token = "0x170009C2")]
		public static string LocalIPAddress
		{
			[Token(Token = "0x6004CA4")]
			[Address(RVA = "0x96515C", Offset = "0x96515C", VA = "0x96515C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x964E08", Offset = "0x964E08", VA = "0x964E08")]
		public static string EscapeString(string data)
		{
			return null;
		}

		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x9651B8", Offset = "0x9651B8", VA = "0x9651B8")]
		public static string UnescapeString(string data)
		{
			return null;
		}

		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x965264", Offset = "0x965264", VA = "0x965264")]
		public void WaitForConnection(TimeSpan timeout)
		{
		}

		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x965464", Offset = "0x965464", VA = "0x965464")]
		public void ProcessMessages()
		{
		}

		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x9655E0", Offset = "0x9655E0", VA = "0x9655E0")]
		public void ParseLine(string line)
		{
		}

		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x9656C8", Offset = "0x9656C8", VA = "0x9656C8")]
		public void ParseLogLine(string[] data)
		{
		}

		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x965890", Offset = "0x965890", VA = "0x965890", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0x96592C", Offset = "0x96592C", VA = "0x96592C")]
		public RemoteServer()
		{
		}
	}
}
