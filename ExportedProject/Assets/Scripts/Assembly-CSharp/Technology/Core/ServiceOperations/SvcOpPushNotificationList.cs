using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDB")]
	public sealed class SvcOpPushNotificationList : SvcOpPostNotification
	{
		[Token(Token = "0x4003DF2")]
		private const string SVCOPNAME = "PushNotificationList";

		[Token(Token = "0x4003DF3")]
		private const string SVCOP_PARAM_UIDS = "uids";

		[Token(Token = "0x4003DF4")]
		private const string SVCOP_PARAM_COMMA_SEPARATED_VALUES = "commaSeparatedValues";

		[Token(Token = "0x4003DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1E4", Offset = "0x5BE1E4")]
		private string _003CPostBody_003Ek__BackingField;

		[Token(Token = "0x17000A84")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FA5")]
			[Address(RVA = "0xD3E2B8", Offset = "0xD3E2B8", VA = "0xD3E2B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A85")]
		protected override string PostBody
		{
			[Token(Token = "0x6004FA7")]
			[Address(RVA = "0xD3E5A0", Offset = "0xD3E5A0", VA = "0xD3E5A0", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629340", Offset = "0x629340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FA8")]
			[Address(RVA = "0xD3E5A8", Offset = "0xD3E5A8", VA = "0xD3E5A8", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629350", Offset = "0x629350")]
			set
			{
			}
		}

		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0xD3E2B0", Offset = "0xD3E2B0", VA = "0xD3E2B0")]
		public SvcOpPushNotificationList([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0xD3E2FC", Offset = "0xD3E2FC", VA = "0xD3E2FC")]
		public void Post(string notificationId, string[] userIds, [Optional] string[] messageParams)
		{
		}
	}
}
