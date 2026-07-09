using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D95")]
	internal sealed class MigrateGetSaveData : IAuthenticationState
	{
		[Token(Token = "0x2000D96")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598924", Offset = "0x598924")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x40040C3")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetMigrationData svcOp;

			[Token(Token = "0x40040C4")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x40040C5")]
			[FieldOffset(Offset = "0x20")]
			public string passphrase;

			[Token(Token = "0x60053A3")]
			[Address(RVA = "0x8C7B08", Offset = "0x8C7B08", VA = "0x8C7B08")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60053A4")]
			[Address(RVA = "0x8C7B10", Offset = "0x8C7B10", VA = "0x8C7B10")]
			internal void _003CHandle_003Eb__0()
			{
			}
		}

		[Token(Token = "0x40040B8")]
		internal const string DICT_KEY_BOOL = "SaveGameBoolean";

		[Token(Token = "0x40040B9")]
		internal const string DICT_KEY_INT32 = "SaveGameInt32";

		[Token(Token = "0x40040BA")]
		internal const string DICT_KEY_INT64 = "SaveGameInt64";

		[Token(Token = "0x40040BB")]
		internal const string DICT_KEY_SINGLE = "SaveGameSingle";

		[Token(Token = "0x40040BC")]
		internal const string DICT_KEY_STRING = "SaveGameString";

		[Token(Token = "0x40040BD")]
		internal const string DICT_KEY_UUID = "s_uuid";

		[Token(Token = "0x40040BE")]
		internal const string DICT_KEY_UID = "_id";

		[Token(Token = "0x40040BF")]
		private const string MIGRATIONGETDATA_ROOT_NODE = "GetMigrationData";

		[Token(Token = "0x40040C0")]
		private const string MIGRATIONGETDATA_PAYLOAD_NODE = "c_payload";

		[Token(Token = "0x40040C1")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultantAction;

		[Token(Token = "0x40040C2")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE69C", Offset = "0x5BE69C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AEE")]
		public bool IsInProgress
		{
			[Token(Token = "0x600539E")]
			[Address(RVA = "0x9C2234", Offset = "0x9C2234", VA = "0x9C2234", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A250", Offset = "0x62A250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600539F")]
			[Address(RVA = "0x9C223C", Offset = "0x9C223C", VA = "0x9C223C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A260", Offset = "0x62A260")]
			private set
			{
			}
		}

		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x9C2248", Offset = "0x9C2248", VA = "0x9C2248", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x9C2414", Offset = "0x9C2414", VA = "0x9C2414")]
		private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x9C3110", Offset = "0x9C3110", VA = "0x9C3110")]
		public MigrateGetSaveData()
		{
		}
	}
}
