using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B33")]
	internal class ShopEvent : EventArgs
	{
		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCC48", Offset = "0x5BCC48")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCC58", Offset = "0x5BCC58")]
		private Transaction _003CTransaction_003Ek__BackingField;

		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCC68", Offset = "0x5BCC68")]
		private Packages _003CPackages_003Ek__BackingField;

		[Token(Token = "0x170008E8")]
		public string ErrorMessage
		{
			[Token(Token = "0x600466F")]
			[Address(RVA = "0x844804", Offset = "0x844804", VA = "0x844804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626AF8", Offset = "0x626AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004670")]
			[Address(RVA = "0x84480C", Offset = "0x84480C", VA = "0x84480C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B08", Offset = "0x626B08")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E9")]
		public Transaction Transaction
		{
			[Token(Token = "0x6004671")]
			[Address(RVA = "0x844814", Offset = "0x844814", VA = "0x844814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B18", Offset = "0x626B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004672")]
			[Address(RVA = "0x84481C", Offset = "0x84481C", VA = "0x84481C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B28", Offset = "0x626B28")]
			private set
			{
			}
		}

		[Token(Token = "0x170008EA")]
		public Packages Packages
		{
			[Token(Token = "0x6004673")]
			[Address(RVA = "0x844824", Offset = "0x844824", VA = "0x844824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B38", Offset = "0x626B38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004674")]
			[Address(RVA = "0x84482C", Offset = "0x84482C", VA = "0x84482C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626B48", Offset = "0x626B48")]
			private set
			{
			}
		}

		[Token(Token = "0x6004675")]
		[Address(RVA = "0x844834", Offset = "0x844834", VA = "0x844834")]
		private ShopEvent()
		{
		}

		[Token(Token = "0x6004676")]
		[Address(RVA = "0x841D08", Offset = "0x841D08", VA = "0x841D08")]
		public ShopEvent(string errorMessage)
		{
		}

		[Token(Token = "0x6004677")]
		[Address(RVA = "0x844898", Offset = "0x844898", VA = "0x844898")]
		public ShopEvent(Packages packages)
		{
		}

		[Token(Token = "0x6004678")]
		[Address(RVA = "0x844944", Offset = "0x844944", VA = "0x844944")]
		public ShopEvent(Packages packages, string errorMessage)
		{
		}

		[Token(Token = "0x6004679")]
		[Address(RVA = "0x8449D4", Offset = "0x8449D4", VA = "0x8449D4")]
		public ShopEvent(Transaction transaction, string errorMessage)
		{
		}
	}
}
