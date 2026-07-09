using System;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C52")]
	public class InstallValidationEventArgs : EventArgs
	{
		[Token(Token = "0x2000C53")]
		public enum ValidationStatus
		{
			[Token(Token = "0x4003CA9")]
			Success = 0,
			[Token(Token = "0x4003CAA")]
			Failure = 1,
			[Token(Token = "0x4003CAB")]
			Unknown = 2
		}

		[Token(Token = "0x4003CA5")]
		[FieldOffset(Offset = "0x10")]
		private readonly ValidationStatus _status;

		[Token(Token = "0x4003CA6")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _platform;

		[Token(Token = "0x4003CA7")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _receipt;

		[Token(Token = "0x170009D6")]
		public ValidationStatus Status
		{
			[Token(Token = "0x6004D48")]
			[Address(RVA = "0xB13F30", Offset = "0xB13F30", VA = "0xB13F30")]
			get
			{
				return default(ValidationStatus);
			}
		}

		[Token(Token = "0x170009D7")]
		public string Platform
		{
			[Token(Token = "0x6004D49")]
			[Address(RVA = "0xB13F38", Offset = "0xB13F38", VA = "0xB13F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D8")]
		public virtual string Receipt
		{
			[Token(Token = "0x6004D4A")]
			[Address(RVA = "0xB13F40", Offset = "0xB13F40", VA = "0xB13F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0xB13F48", Offset = "0xB13F48", VA = "0xB13F48")]
		public InstallValidationEventArgs(ValidationStatus status, string platform, string receipt)
		{
		}

		[Token(Token = "0x6004D4C")]
		[Address(RVA = "0xB13FD4", Offset = "0xB13FD4", VA = "0xB13FD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
