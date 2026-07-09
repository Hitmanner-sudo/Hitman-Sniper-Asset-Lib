using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD9")]
	public sealed class SvcOpPushCustomNotificationList : SvcOpPostNotification
	{
		[Token(Token = "0x4003DE9")]
		private const string SVCOPNAME = "PushCustomNotificationList";

		[Token(Token = "0x4003DEA")]
		private const string SVCOP_PARAM_UIDS = "uids";

		[Token(Token = "0x4003DEB")]
		private const string SVCOP_PARAM_COMMA_SEPARATED_VALUES = "commaSeparatedValues";

		[Token(Token = "0x4003DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1C4", Offset = "0x5BE1C4")]
		private string _003CPostBody_003Ek__BackingField;

		[Token(Token = "0x17000A80")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F9B")]
			[Address(RVA = "0xD3D828", Offset = "0xD3D828", VA = "0xD3D828", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A81")]
		protected override string PostBody
		{
			[Token(Token = "0x6004F9D")]
			[Address(RVA = "0xD3DB10", Offset = "0xD3DB10", VA = "0xD3DB10", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629300", Offset = "0x629300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F9E")]
			[Address(RVA = "0xD3DB18", Offset = "0xD3DB18", VA = "0xD3DB18", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629310", Offset = "0x629310")]
			set
			{
			}
		}

		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0xD3D820", Offset = "0xD3D820", VA = "0xD3D820")]
		public SvcOpPushCustomNotificationList([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0xD3D86C", Offset = "0xD3D86C", VA = "0xD3D86C")]
		public void Post(string message, string[] userIds, [Optional] string[] messageParams)
		{
		}
	}
}
