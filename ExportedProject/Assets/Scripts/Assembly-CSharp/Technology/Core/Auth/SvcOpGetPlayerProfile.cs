using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DC5")]
	public abstract class SvcOpGetPlayerProfile : SvcOpGet
	{
		[Token(Token = "0x40041BF")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x40041C0")]
		public const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

		[Token(Token = "0x40041C1")]
		public const string QUERYSTRING_PARAM_FIELDS_KEY = "s_fields";

		[Token(Token = "0x40041C2")]
		public const string QUERYSTRING_PARAM_COUNTRY_KEY = "s_country";

		[Token(Token = "0x40041C3")]
		public const string QUERYSTRING_PARAM_JSON_KEY = "s_json";

		[Token(Token = "0x40041C4")]
		public const string QUERYSTRING_PARAM_LANG_KEY = "s_language";

		[Token(Token = "0x40041C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF3CC", Offset = "0x5BF3CC")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x17000B41")]
		protected sealed override string SvcOpCmdQueryString
		{
			[Token(Token = "0x60054CA")]
			[Address(RVA = "0xD39268", Offset = "0xD39268", VA = "0xD39268", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A920", Offset = "0x62A920")]
			get
			{
				return null;
			}
			[Token(Token = "0x60054CB")]
			[Address(RVA = "0xD39270", Offset = "0xD39270", VA = "0xD39270", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A930", Offset = "0x62A930")]
			set
			{
			}
		}

		[Token(Token = "0x60054CC")]
		[Address(RVA = "0xD39278", Offset = "0xD39278", VA = "0xD39278")]
		protected SvcOpGetPlayerProfile([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054CD")]
		[Address(RVA = "0xD392F4", Offset = "0xD392F4", VA = "0xD392F4")]
		protected void GetViaJSON(string userid, string name, KeyValuePair<string, string>[] pairs)
		{
		}

		[Token(Token = "0x60054CE")]
		[Address(RVA = "0xD396A8", Offset = "0xD396A8", VA = "0xD396A8")]
		protected void GetViaJSON(string userid, KeyValuePair<string, string>[] pairs)
		{
		}

		[Token(Token = "0x60054CF")]
		[Address(RVA = "0xD3971C", Offset = "0xD3971C", VA = "0xD3971C")]
		protected void GetViaCountry(string userid, string country)
		{
		}

		[Token(Token = "0x60054D0")]
		[Address(RVA = "0xD39790", Offset = "0xD39790", VA = "0xD39790")]
		protected void Get(string userid, string name)
		{
		}

		[Token(Token = "0x60054D1")]
		[Address(RVA = "0xD39804", Offset = "0xD39804", VA = "0xD39804")]
		protected void Get(string userid)
		{
		}

		[Token(Token = "0x60054D2")]
		[Address(RVA = "0xD39374", Offset = "0xD39374", VA = "0xD39374")]
		protected void Get(string userid, string name, string country, KeyValuePair<string, string>[] pairs, string language)
		{
		}
	}
}
