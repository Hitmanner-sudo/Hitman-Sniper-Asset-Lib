using System;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C55")]
	public class iOSInstallValidationEventArgs : InstallValidationEventArgs
	{
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _isFromRefresh;

		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0x30")]
		private readonly DateTime _originalPurchaseDate;

		[Token(Token = "0x170009DA")]
		public bool IsFromRefresh
		{
			[Token(Token = "0x6004D4F")]
			[Address(RVA = "0x888C14", Offset = "0x888C14", VA = "0x888C14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009DB")]
		public DateTime OriginalPurchaseDate
		{
			[Token(Token = "0x6004D50")]
			[Address(RVA = "0x888C1C", Offset = "0x888C1C", VA = "0x888C1C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x888C24", Offset = "0x888C24", VA = "0x888C24")]
		public iOSInstallValidationEventArgs(ValidationStatus status)
		{
		}

		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x888C30", Offset = "0x888C30", VA = "0x888C30")]
		public iOSInstallValidationEventArgs(ValidationStatus status, string receipt, bool isFromRefresh)
		{
		}

		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x888CC4", Offset = "0x888CC4", VA = "0x888CC4")]
		public iOSInstallValidationEventArgs(ValidationStatus status, string receipt, bool isFromRefresh, DateTime originalPurchaseDate)
		{
		}
	}
}
