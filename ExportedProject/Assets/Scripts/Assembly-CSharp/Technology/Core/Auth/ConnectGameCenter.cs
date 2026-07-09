using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D8A")]
	internal sealed class ConnectGameCenter : IAuthenticationState
	{
		[Token(Token = "0x40040A9")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE62C", Offset = "0x5BE62C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE5")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005371")]
			[Address(RVA = "0x8E0978", Offset = "0x8E0978", VA = "0x8E0978", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A170", Offset = "0x62A170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005372")]
			[Address(RVA = "0x8E0980", Offset = "0x8E0980", VA = "0x8E0980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A180", Offset = "0x62A180")]
			private set
			{
			}
		}

		[Token(Token = "0x6005373")]
		[Address(RVA = "0x8E098C", Offset = "0x8E098C", VA = "0x8E098C", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005374")]
		[Address(RVA = "0x8E0A3C", Offset = "0x8E0A3C", VA = "0x8E0A3C")]
		public ConnectGameCenter()
		{
		}
	}
}
