using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DA2")]
	public class AuthenticationEvent : EventArgs
	{
		[Token(Token = "0x40040FA")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE844", Offset = "0x5BE844")]
		private bool _003CSuccess_003Ek__BackingField;

		[Token(Token = "0x40040FB")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE854", Offset = "0x5BE854")]
		private string _003CMessage_003Ek__BackingField;

		[Token(Token = "0x17000B04")]
		public bool Success
		{
			[Token(Token = "0x600540A")]
			[Address(RVA = "0xC0BD50", Offset = "0xC0BD50", VA = "0xC0BD50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A480", Offset = "0x62A480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600540B")]
			[Address(RVA = "0xC0BD58", Offset = "0xC0BD58", VA = "0xC0BD58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A490", Offset = "0x62A490")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B05")]
		public string Message
		{
			[Token(Token = "0x600540C")]
			[Address(RVA = "0xC0BD64", Offset = "0xC0BD64", VA = "0xC0BD64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4A0", Offset = "0x62A4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600540D")]
			[Address(RVA = "0xC0BD6C", Offset = "0xC0BD6C", VA = "0xC0BD6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4B0", Offset = "0x62A4B0")]
			private set
			{
			}
		}

		[Token(Token = "0x600540E")]
		[Address(RVA = "0xC0BD74", Offset = "0xC0BD74", VA = "0xC0BD74")]
		public AuthenticationEvent(bool success, string message = "")
		{
		}
	}
}
