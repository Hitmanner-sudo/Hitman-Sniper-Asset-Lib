using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B2C")]
	public class PackageEvent : EventArgs
	{
		[Token(Token = "0x40038F6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCBA8", Offset = "0x5BCBA8")]
		private Transaction _003CTransaction_003Ek__BackingField;

		[Token(Token = "0x40038F7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCBB8", Offset = "0x5BCBB8")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x170008D9")]
		public Transaction Transaction
		{
			[Token(Token = "0x6004630")]
			[Address(RVA = "0x8F3EF0", Offset = "0x8F3EF0", VA = "0x8F3EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626928", Offset = "0x626928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004631")]
			[Address(RVA = "0x8F3EF8", Offset = "0x8F3EF8", VA = "0x8F3EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626938", Offset = "0x626938")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DA")]
		public string ErrorMessage
		{
			[Token(Token = "0x6004632")]
			[Address(RVA = "0x8F3F00", Offset = "0x8F3F00", VA = "0x8F3F00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626948", Offset = "0x626948")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004633")]
			[Address(RVA = "0x8F3F08", Offset = "0x8F3F08", VA = "0x8F3F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626958", Offset = "0x626958")]
			private set
			{
			}
		}

		[Token(Token = "0x6004634")]
		[Address(RVA = "0x8F3F10", Offset = "0x8F3F10", VA = "0x8F3F10")]
		public PackageEvent(Transaction transaction, string ErrorMessage)
		{
		}

		[Token(Token = "0x6004635")]
		[Address(RVA = "0x8F3E00", Offset = "0x8F3E00", VA = "0x8F3E00")]
		public PackageEvent(string ErrorMessage)
		{
		}
	}
}
