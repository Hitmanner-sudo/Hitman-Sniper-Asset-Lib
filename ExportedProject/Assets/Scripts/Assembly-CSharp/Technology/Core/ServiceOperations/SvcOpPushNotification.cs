using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDA")]
	public sealed class SvcOpPushNotification : SvcOpPostNotification
	{
		[Token(Token = "0x4003DED")]
		private const string SVCOPNAME = "PushNotification";

		[Token(Token = "0x4003DEE")]
		private const string SVCOP_PARAM_BADGE = "badge";

		[Token(Token = "0x4003DEF")]
		private const string SVCOP_PARAM_COMMA_SEPARATED_VALUES = "commaSeparatedValues";

		[Token(Token = "0x4003DF0")]
		private const string SVCOP_PARAM_CUSTOM_DATA = "customData";

		[Token(Token = "0x4003DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1D4", Offset = "0x5BE1D4")]
		private string _003CPostBody_003Ek__BackingField;

		[Token(Token = "0x17000A82")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FA0")]
			[Address(RVA = "0xD3DB28", Offset = "0xD3DB28", VA = "0xD3DB28", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A83")]
		protected override string PostBody
		{
			[Token(Token = "0x6004FA2")]
			[Address(RVA = "0xD3DEBC", Offset = "0xD3DEBC", VA = "0xD3DEBC", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629320", Offset = "0x629320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FA3")]
			[Address(RVA = "0xD3DEC4", Offset = "0xD3DEC4", VA = "0xD3DEC4", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629330", Offset = "0x629330")]
			set
			{
			}
		}

		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0xD3DB20", Offset = "0xD3DB20", VA = "0xD3DB20")]
		public SvcOpPushNotification([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0xD3DB6C", Offset = "0xD3DB6C", VA = "0xD3DB6C")]
		public void Post(string userid, string notificationId, [Optional] string[] messageParams, [Optional][DefaultParameterValue(-1)] int numberBadgesToDisplay, [Optional] KeyValuePair<string, string>[] customData)
		{
		}
	}
}
