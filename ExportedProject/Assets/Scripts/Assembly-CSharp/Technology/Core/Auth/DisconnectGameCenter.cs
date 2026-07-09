using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D8D")]
	internal sealed class DisconnectGameCenter : IAuthenticationState
	{
		[Token(Token = "0x40040AE")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE64C", Offset = "0x5BE64C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE7")]
		public bool IsInProgress
		{
			[Token(Token = "0x600537C")]
			[Address(RVA = "0xC15950", Offset = "0xC15950", VA = "0xC15950", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1B0", Offset = "0x62A1B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600537D")]
			[Address(RVA = "0xC15958", Offset = "0xC15958", VA = "0xC15958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1C0", Offset = "0x62A1C0")]
			private set
			{
			}
		}

		[Token(Token = "0x600537E")]
		[Address(RVA = "0xC15964", Offset = "0xC15964", VA = "0xC15964", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x600537F")]
		[Address(RVA = "0xC15A14", Offset = "0xC15A14", VA = "0xC15A14")]
		public DisconnectGameCenter()
		{
		}
	}
}
