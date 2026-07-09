using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C4E")]
	public class AndroidInstallValidationEventArgs : InstallValidationEventArgs
	{
		[Token(Token = "0x4003CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int? _reason;

		[Token(Token = "0x4003CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly int? _errorCode;

		[Token(Token = "0x4003CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string _message;

		[Token(Token = "0x170009D2")]
		public int? Reason
		{
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0xD6E4C0", Offset = "0xD6E4C0", VA = "0xD6E4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D3")]
		public int? ErrorCode
		{
			[Token(Token = "0x6004D3E")]
			[Address(RVA = "0xD6E4C8", Offset = "0xD6E4C8", VA = "0xD6E4C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D4")]
		public string Message
		{
			[Token(Token = "0x6004D3F")]
			[Address(RVA = "0xD6E4D0", Offset = "0xD6E4D0", VA = "0xD6E4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D5")]
		public override string Receipt
		{
			[Token(Token = "0x6004D40")]
			[Address(RVA = "0xD6E4D8", Offset = "0xD6E4D8", VA = "0xD6E4D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D41")]
		[Address(RVA = "0xD6E4E4", Offset = "0xD6E4E4", VA = "0xD6E4E4")]
		public AndroidInstallValidationEventArgs(ValidationStatus status, [Optional] int? reason, [Optional] int? errorCode, [Optional] string message)
		{
		}

		[Token(Token = "0x6004D42")]
		[Address(RVA = "0xD6E568", Offset = "0xD6E568", VA = "0xD6E568", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
