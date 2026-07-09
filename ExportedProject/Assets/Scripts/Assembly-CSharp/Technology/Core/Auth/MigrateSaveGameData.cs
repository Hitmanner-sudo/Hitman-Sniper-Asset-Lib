using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D97")]
	internal sealed class MigrateSaveGameData : IAuthenticationState
	{
		[Token(Token = "0x2000D98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598934", Offset = "0x598934")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x40040C9")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpAuthorizeMigration svcOp;

			[Token(Token = "0x40040CA")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x40040CB")]
			[FieldOffset(Offset = "0x20")]
			public string passphrase;

			[Token(Token = "0x60053AA")]
			[Address(RVA = "0x8C7B34", Offset = "0x8C7B34", VA = "0x8C7B34")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60053AB")]
			[Address(RVA = "0x8C7B3C", Offset = "0x8C7B3C", VA = "0x8C7B3C")]
			internal void _003CHandle_003Eb__0()
			{
			}
		}

		[Token(Token = "0x40040C6")]
		internal const string MIGRATION_PARENT_NODE = "AuthorizeMigration";

		[Token(Token = "0x40040C7")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultantAction;

		[Token(Token = "0x40040C8")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE6AC", Offset = "0x5BE6AC")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AEF")]
		public bool IsInProgress
		{
			[Token(Token = "0x60053A5")]
			[Address(RVA = "0x9C3118", Offset = "0x9C3118", VA = "0x9C3118", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A270", Offset = "0x62A270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60053A6")]
			[Address(RVA = "0x9C3120", Offset = "0x9C3120", VA = "0x9C3120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A280", Offset = "0x62A280")]
			private set
			{
			}
		}

		[Token(Token = "0x60053A7")]
		[Address(RVA = "0x9C312C", Offset = "0x9C312C", VA = "0x9C312C", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x60053A8")]
		[Address(RVA = "0x9C32F8", Offset = "0x9C32F8", VA = "0x9C32F8")]
		private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x60053A9")]
		[Address(RVA = "0x9C3604", Offset = "0x9C3604", VA = "0x9C3604")]
		public MigrateSaveGameData()
		{
		}
	}
}
