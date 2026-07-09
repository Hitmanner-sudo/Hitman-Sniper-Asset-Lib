using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C35")]
	internal class RijndaelEncryptor : RevertibleFilter
	{
		[Token(Token = "0x4003C86")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PasswordHash;

		[Token(Token = "0x4003C87")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string VIKey;

		[Token(Token = "0x4003C88")]
		[FieldOffset(Offset = "0x10")]
		private readonly string SaltKey;

		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x96E0CC", Offset = "0x96E0CC", VA = "0x96E0CC")]
		internal RijndaelEncryptor()
		{
		}

		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x96E124", Offset = "0x96E124", VA = "0x96E124", Slot = "5")]
		internal override object Apply(object input)
		{
			return null;
		}

		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x96E544", Offset = "0x96E544", VA = "0x96E544", Slot = "6")]
		internal override object Revert(object output)
		{
			return null;
		}
	}
}
