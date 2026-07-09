using System;
using System.IO;
using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Core.Logging;

namespace Technology.Remoting
{
	[Token(Token = "0x2000C22")]
	public sealed class RemoteClient : IDisposable
	{
		[Token(Token = "0x4003C64")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string IPAddressFile;

		[Token(Token = "0x4003C65")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float PingTime;

		[Token(Token = "0x4003C66")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _ipaddress;

		[Token(Token = "0x4003C67")]
		[FieldOffset(Offset = "0x18")]
		private WinRTTCPClient _client;

		[Token(Token = "0x4003C68")]
		[FieldOffset(Offset = "0x20")]
		private StreamWriter _clientStream;

		[Token(Token = "0x4003C69")]
		[FieldOffset(Offset = "0x28")]
		private float _elapsedTime;

		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x964808", Offset = "0x964808", VA = "0x964808")]
		public RemoteClient()
		{
		}

		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x964810", Offset = "0x964810", VA = "0x964810")]
		public RemoteClient(string ipaddress)
		{
		}

		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x96483C", Offset = "0x96483C", VA = "0x96483C")]
		public void Connect()
		{
		}

		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x964B8C", Offset = "0x964B8C", VA = "0x964B8C")]
		private void Log(string message, string callStack, LogType level)
		{
		}

		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x964EF0", Offset = "0x964EF0", VA = "0x964EF0")]
		private void Ping()
		{
		}

		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x964F78", Offset = "0x964F78", VA = "0x964F78")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x965018", Offset = "0x965018", VA = "0x965018", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
