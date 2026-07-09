using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD8")]
	public sealed class SvcOpPushCustomNotification : SvcOpPostNotification
	{
		[Token(Token = "0x4003DE5")]
		private const string SVCOPNAME = "PushCustomNotification";

		[Token(Token = "0x4003DE6")]
		private const string SVCOP_PARAM_BADGE = "badge";

		[Token(Token = "0x4003DE7")]
		private const string SVCOP_PARAM_COMMA_SEPARATED_VALUES = "commaSeparatedValues";

		[Token(Token = "0x4003DE8")]
		private const string SVCOP_PARAM_CUSTOM_DATA = "customData";

		[Token(Token = "0x17000A7E")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F96")]
			[Address(RVA = "0xD3D43C", Offset = "0xD3D43C", VA = "0xD3D43C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7F")]
		protected override string PostBody
		{
			[Token(Token = "0x6004F98")]
			[Address(RVA = "0xD3D7D0", Offset = "0xD3D7D0", VA = "0xD3D7D0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F99")]
			[Address(RVA = "0xD3D81C", Offset = "0xD3D81C", VA = "0xD3D81C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6004F95")]
		[Address(RVA = "0xD3D434", Offset = "0xD3D434", VA = "0xD3D434")]
		public SvcOpPushCustomNotification([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F97")]
		[Address(RVA = "0xD3D480", Offset = "0xD3D480", VA = "0xD3D480")]
		public void Post(string userid, string message, [Optional] string[] messageParams, [Optional][DefaultParameterValue(-1)] int numberBadgesToDisplay, [Optional] KeyValuePair<string, string>[] customData)
		{
		}
	}
}
