using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CBF")]
	public abstract class SvcOpGetFacebook : SvcOpGet
	{
		[Token(Token = "0x4003DAB")]
		private const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x4003DAC")]
		private const string QUERYSTRING_PARAM_PARAMS_KEY = "s_params";

		[Token(Token = "0x4003DAD")]
		private const string QUERYSTRING_PARAM_NOTIFICATIONID_KEY = "s_notificationid";

		[Token(Token = "0x4003DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE174", Offset = "0x5BE174")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x17000A67")]
		protected sealed override string SvcOpCmdQueryString
		{
			[Token(Token = "0x6004F32")]
			[Address(RVA = "0xD379D4", Offset = "0xD379D4", VA = "0xD379D4", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629260", Offset = "0x629260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F33")]
			[Address(RVA = "0xD379DC", Offset = "0xD379DC", VA = "0xD379DC", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629270", Offset = "0x629270")]
			set
			{
			}
		}

		[Token(Token = "0x6004F34")]
		[Address(RVA = "0xD379E4", Offset = "0xD379E4", VA = "0xD379E4")]
		protected SvcOpGetFacebook([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F35")]
		[Address(RVA = "0xD37A60", Offset = "0xD37A60", VA = "0xD37A60")]
		protected void Get(string uid)
		{
		}

		[Token(Token = "0x6004F36")]
		[Address(RVA = "0xD37AC8", Offset = "0xD37AC8", VA = "0xD37AC8")]
		protected void Get(string uid, string notificationId, string[] messageParams)
		{
		}
	}
}
