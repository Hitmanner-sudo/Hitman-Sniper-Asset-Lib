using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD7")]
	public abstract class SvcOpPostNotification : SvcOpPost
	{
		[Token(Token = "0x4003DDE")]
		private const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x4003DDF")]
		private const string QUERYSTRING_PARAM_PARAMS_KEY = "s_params";

		[Token(Token = "0x4003DE0")]
		private const string QUERYSTRING_PARAM_MESSAGE = "s_messageString";

		[Token(Token = "0x4003DE1")]
		private const string QUERYSTRING_PARAM_MESSAGEID = "s_messageId";

		[Token(Token = "0x4003DE2")]
		private const string QUERYSTRING_PARAM_DEVICE_TOKEN = "s_deviceToken";

		[Token(Token = "0x4003DE3")]
		private const string QUERYSTRING_PARAM_LANG = "s_language";

		[Token(Token = "0x4003DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1B4", Offset = "0x5BE1B4")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x17000A7D")]
		protected sealed override string SvcOpCmdQueryString
		{
			[Token(Token = "0x6004F91")]
			[Address(RVA = "0xD3CFF0", Offset = "0xD3CFF0", VA = "0xD3CFF0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292E0", Offset = "0x6292E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F92")]
			[Address(RVA = "0xD3CFF8", Offset = "0xD3CFF8", VA = "0xD3CFF8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292F0", Offset = "0x6292F0")]
			set
			{
			}
		}

		[Token(Token = "0x6004F93")]
		[Address(RVA = "0xD3D000", Offset = "0xD3D000", VA = "0xD3D000")]
		protected SvcOpPostNotification([Optional] Action<IResponseContext> responseFunction, bool requiresEditorToken = false)
		{
		}

		[Token(Token = "0x6004F94")]
		[Address(RVA = "0xD3D080", Offset = "0xD3D080", VA = "0xD3D080")]
		protected void Post(string userid, string notificationId, string message, string deviceToken, string language, string[] messageParams)
		{
		}
	}
}
