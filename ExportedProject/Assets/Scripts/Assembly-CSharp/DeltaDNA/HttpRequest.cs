using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001316")]
	internal class HttpRequest
	{
		[Token(Token = "0x2001317")]
		internal enum HTTPMethodType
		{
			[Token(Token = "0x4005B80")]
			GET = 0,
			[Token(Token = "0x4005B81")]
			POST = 1
		}

		[Token(Token = "0x4005B7A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> headers;

		[Token(Token = "0x4005B7B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611190", Offset = "0x611190")]
		private string _003CURL_003Ek__BackingField;

		[Token(Token = "0x4005B7C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6111A0", Offset = "0x6111A0")]
		private HTTPMethodType _003CHTTPMethod_003Ek__BackingField;

		[Token(Token = "0x4005B7D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6111B0", Offset = "0x6111B0")]
		private string _003CHTTPBody_003Ek__BackingField;

		[Token(Token = "0x4005B7E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6111C0", Offset = "0x6111C0")]
		private int _003CTimeoutSeconds_003Ek__BackingField;

		[Token(Token = "0x17000CBF")]
		internal string URL
		{
			[Token(Token = "0x6007014")]
			[Address(RVA = "0xA159FC", Offset = "0xA159FC", VA = "0xA159FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CE90", Offset = "0x62CE90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007015")]
			[Address(RVA = "0xA15A04", Offset = "0xA15A04", VA = "0xA15A04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CEA0", Offset = "0x62CEA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CC0")]
		internal HTTPMethodType HTTPMethod
		{
			[Token(Token = "0x6007016")]
			[Address(RVA = "0xA15A0C", Offset = "0xA15A0C", VA = "0xA15A0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CEB0", Offset = "0x62CEB0")]
			get
			{
				return default(HTTPMethodType);
			}
			[Token(Token = "0x6007017")]
			[Address(RVA = "0xA15A14", Offset = "0xA15A14", VA = "0xA15A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CEC0", Offset = "0x62CEC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CC1")]
		internal string HTTPBody
		{
			[Token(Token = "0x6007018")]
			[Address(RVA = "0xA15A1C", Offset = "0xA15A1C", VA = "0xA15A1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CED0", Offset = "0x62CED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007019")]
			[Address(RVA = "0xA15A24", Offset = "0xA15A24", VA = "0xA15A24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CEE0", Offset = "0x62CEE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CC2")]
		internal int TimeoutSeconds
		{
			[Token(Token = "0x600701A")]
			[Address(RVA = "0xA15A2C", Offset = "0xA15A2C", VA = "0xA15A2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CEF0", Offset = "0x62CEF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600701B")]
			[Address(RVA = "0xA15A34", Offset = "0xA15A34", VA = "0xA15A34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CF00", Offset = "0x62CF00")]
			set
			{
			}
		}

		[Token(Token = "0x6007013")]
		[Address(RVA = "0xA15910", Offset = "0xA15910", VA = "0xA15910")]
		internal HttpRequest(string url)
		{
		}

		[Token(Token = "0x600701C")]
		[Address(RVA = "0xA15A3C", Offset = "0xA15A3C", VA = "0xA15A3C")]
		internal Dictionary<string, string> getHeaders()
		{
			return null;
		}

		[Token(Token = "0x600701D")]
		[Address(RVA = "0xA15A44", Offset = "0xA15A44", VA = "0xA15A44")]
		internal void setHeader(string field, string value)
		{
		}

		[Token(Token = "0x600701E")]
		[Address(RVA = "0xA15AB0", Offset = "0xA15AB0", VA = "0xA15AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
