using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C54")]
	public class WindowsInstallValidationEventArgs : InstallValidationEventArgs
	{
		[Token(Token = "0x170009D9")]
		public override string Receipt
		{
			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0x87FAB0", Offset = "0x87FAB0", VA = "0x87FAB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D4D")]
		[Address(RVA = "0x87FA4C", Offset = "0x87FA4C", VA = "0x87FA4C")]
		public WindowsInstallValidationEventArgs(ValidationStatus status)
		{
		}
	}
}
