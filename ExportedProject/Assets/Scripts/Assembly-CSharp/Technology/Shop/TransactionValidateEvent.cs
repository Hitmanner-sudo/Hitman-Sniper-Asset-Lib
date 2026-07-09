using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B3B")]
	internal class TransactionValidateEvent : EventArgs
	{
		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCFBC", Offset = "0x5BCFBC")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x170008F7")]
		public string ErrorMessage
		{
			[Token(Token = "0x60046F1")]
			[Address(RVA = "0xC96F88", Offset = "0xC96F88", VA = "0xC96F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CD8", Offset = "0x626CD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046F2")]
			[Address(RVA = "0xC96F90", Offset = "0xC96F90", VA = "0xC96F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CE8", Offset = "0x626CE8")]
			private set
			{
			}
		}

		[Token(Token = "0x60046F3")]
		[Address(RVA = "0xC96F98", Offset = "0xC96F98", VA = "0xC96F98")]
		private TransactionValidateEvent()
		{
		}

		[Token(Token = "0x60046F4")]
		[Address(RVA = "0xC96FFC", Offset = "0xC96FFC", VA = "0xC96FFC")]
		public TransactionValidateEvent(string errorMessage)
		{
		}
	}
}
