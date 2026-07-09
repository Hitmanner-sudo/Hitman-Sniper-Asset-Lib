using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D8E")]
	internal sealed class GenerateSquareEnixId : IAuthenticationState
	{
		[Token(Token = "0x40040AF")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultantAction;

		[Token(Token = "0x40040B0")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE65C", Offset = "0x5BE65C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE8")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005380")]
			[Address(RVA = "0xD9E2CC", Offset = "0xD9E2CC", VA = "0xD9E2CC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1D0", Offset = "0x62A1D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005381")]
			[Address(RVA = "0xD9E2D4", Offset = "0xD9E2D4", VA = "0xD9E2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1E0", Offset = "0x62A1E0")]
			private set
			{
			}
		}

		[Token(Token = "0x6005382")]
		[Address(RVA = "0xD9E2E0", Offset = "0xD9E2E0", VA = "0xD9E2E0", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005383")]
		[Address(RVA = "0xD9E468", Offset = "0xD9E468", VA = "0xD9E468")]
		private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x6005384")]
		[Address(RVA = "0xD9E77C", Offset = "0xD9E77C", VA = "0xD9E77C")]
		public GenerateSquareEnixId()
		{
		}
	}
}
