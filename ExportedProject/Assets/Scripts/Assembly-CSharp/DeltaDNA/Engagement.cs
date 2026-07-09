using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012F9")]
	public class Engagement<T> where T : Engagement<T>
	{
		[Token(Token = "0x4005AFF")]
		[FieldOffset(Offset = "0x0")]
		private readonly Params parameters;

		[Token(Token = "0x4005B00")]
		[FieldOffset(Offset = "0x0")]
		private string response;

		[Token(Token = "0x4005B01")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110C8", Offset = "0x6110C8")]
		private string _003CDecisionPoint_003Ek__BackingField;

		[Token(Token = "0x4005B02")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110D8", Offset = "0x6110D8")]
		private string _003CFlavour_003Ek__BackingField;

		[Token(Token = "0x4005B03")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110E8", Offset = "0x6110E8")]
		private int _003CStatusCode_003Ek__BackingField;

		[Token(Token = "0x4005B04")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110F8", Offset = "0x6110F8")]
		private string _003CError_003Ek__BackingField;

		[Token(Token = "0x4005B05")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611108", Offset = "0x611108")]
		private Dictionary<string, object> _003CJSON_003Ek__BackingField;

		[Token(Token = "0x17000C9F")]
		public string DecisionPoint
		{
			[Token(Token = "0x6006F64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CAB0", Offset = "0x62CAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F65")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CAC0", Offset = "0x62CAC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA0")]
		public string Flavour
		{
			[Token(Token = "0x6006F66")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CAD0", Offset = "0x62CAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F67")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CAE0", Offset = "0x62CAE0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000CA1")]
		public string Raw
		{
			[Token(Token = "0x6006F6A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F6B")]
			set
			{
			}
		}

		[Token(Token = "0x17000CA2")]
		public int StatusCode
		{
			[Token(Token = "0x6006F6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CAF0", Offset = "0x62CAF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6006F6D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB00", Offset = "0x62CB00")]
			set
			{
			}
		}

		[Token(Token = "0x17000CA3")]
		public string Error
		{
			[Token(Token = "0x6006F6E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB10", Offset = "0x62CB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F6F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB20", Offset = "0x62CB20")]
			set
			{
			}
		}

		[Token(Token = "0x17000CA4")]
		public Dictionary<string, object> JSON
		{
			[Token(Token = "0x6006F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB30", Offset = "0x62CB30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F71")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB40", Offset = "0x62CB40")]
			internal set
			{
			}
		}

		[Token(Token = "0x6006F62")]
		public Engagement(string decisionPoint)
		{
		}

		[Token(Token = "0x6006F63")]
		internal Engagement(string decisionPoint, Params parameters)
		{
		}

		[Token(Token = "0x6006F68")]
		public T AddParam(string key, object value)
		{
			return null;
		}

		[Token(Token = "0x6006F69")]
		public Dictionary<string, object> AsDictionary()
		{
			return null;
		}

		[Token(Token = "0x6006F72")]
		internal string GetDecisionPointAndFlavour()
		{
			return null;
		}

		[Token(Token = "0x6006F73")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20012FA")]
	public class Engagement : Engagement<Engagement>
	{
		[Token(Token = "0x6006F74")]
		[Address(RVA = "0xE14A94", Offset = "0xE14A94", VA = "0xE14A94")]
		public Engagement(string decisionPoint)
		{
		}

		[Token(Token = "0x6006F75")]
		[Address(RVA = "0xE14A30", Offset = "0xE14A30", VA = "0xE14A30")]
		internal Engagement(string decisionPoint, Params parameters)
		{
		}
	}
}
