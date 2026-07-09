using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D86")]
	internal sealed class CheckSquareEnix : IAuthenticationState
	{
		[Token(Token = "0x400409C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE60C", Offset = "0x5BE60C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE3")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005363")]
			[Address(RVA = "0xAFF968", Offset = "0xAFF968", VA = "0xAFF968", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A130", Offset = "0x62A130")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005364")]
			[Address(RVA = "0xAFF970", Offset = "0xAFF970", VA = "0xAFF970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A140", Offset = "0x62A140")]
			private set
			{
			}
		}

		[Token(Token = "0x6005365")]
		[Address(RVA = "0xAFF97C", Offset = "0xAFF97C", VA = "0xAFF97C", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005366")]
		[Address(RVA = "0xAFFC84", Offset = "0xAFFC84", VA = "0xAFFC84")]
		public CheckSquareEnix()
		{
		}
	}
}
