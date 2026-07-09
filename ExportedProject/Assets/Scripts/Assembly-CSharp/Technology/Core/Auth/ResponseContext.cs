using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D9E")]
	public class ResponseContext
	{
		[Token(Token = "0x40040E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE784", Offset = "0x5BE784")]
		private int _003CErrorCode_003Ek__BackingField;

		[Token(Token = "0x40040E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE794", Offset = "0x5BE794")]
		private string _003CMessage_003Ek__BackingField;

		[Token(Token = "0x40040E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7A4", Offset = "0x5BE7A4")]
		private OSRequestState _003CState_003Ek__BackingField;

		[Token(Token = "0x40040E7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE7B4", Offset = "0x5BE7B4")]
		private Dictionary<string, object> _003CMeta_003Ek__BackingField;

		[Token(Token = "0x17000AF9")]
		public int ErrorCode
		{
			[Token(Token = "0x60053D0")]
			[Address(RVA = "0x966900", Offset = "0x966900", VA = "0x966900")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2D0", Offset = "0x62A2D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60053D1")]
			[Address(RVA = "0x966908", Offset = "0x966908", VA = "0x966908")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2E0", Offset = "0x62A2E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AFA")]
		public string Message
		{
			[Token(Token = "0x60053D2")]
			[Address(RVA = "0x966910", Offset = "0x966910", VA = "0x966910")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2F0", Offset = "0x62A2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D3")]
			[Address(RVA = "0x966918", Offset = "0x966918", VA = "0x966918")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A300", Offset = "0x62A300")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AFB")]
		public OSRequestState State
		{
			[Token(Token = "0x60053D4")]
			[Address(RVA = "0x966920", Offset = "0x966920", VA = "0x966920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A310", Offset = "0x62A310")]
			get
			{
				return default(OSRequestState);
			}
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0x966928", Offset = "0x966928", VA = "0x966928")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A320", Offset = "0x62A320")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AFC")]
		public Dictionary<string, object> Meta
		{
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0x966930", Offset = "0x966930", VA = "0x966930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A330", Offset = "0x62A330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0x966938", Offset = "0x966938", VA = "0x966938")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A340", Offset = "0x62A340")]
			private set
			{
			}
		}

		[Token(Token = "0x60053D8")]
		[Address(RVA = "0x966940", Offset = "0x966940", VA = "0x966940")]
		public ResponseContext(string message, int errorCode, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x966994", Offset = "0x966994", VA = "0x966994")]
		public ResponseContext(string message, int errorCode, OSRequestState state)
		{
		}
	}
}
