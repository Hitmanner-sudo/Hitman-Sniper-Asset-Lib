using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001305")]
	internal class EngageRequest
	{
		[Token(Token = "0x4005B29")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611160", Offset = "0x611160")]
		private string _003CDecisionPoint_003Ek__BackingField;

		[Token(Token = "0x4005B2A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611170", Offset = "0x611170")]
		private string _003CFlavour_003Ek__BackingField;

		[Token(Token = "0x4005B2B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611180", Offset = "0x611180")]
		private Dictionary<string, object> _003CParameters_003Ek__BackingField;

		[Token(Token = "0x17000CB2")]
		public string DecisionPoint
		{
			[Token(Token = "0x6006FB2")]
			[Address(RVA = "0xE14B98", Offset = "0xE14B98", VA = "0xE14B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB70", Offset = "0x62CB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FB3")]
			[Address(RVA = "0xE14BA0", Offset = "0xE14BA0", VA = "0xE14BA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB80", Offset = "0x62CB80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB3")]
		public string Flavour
		{
			[Token(Token = "0x6006FB4")]
			[Address(RVA = "0xE14BA8", Offset = "0xE14BA8", VA = "0xE14BA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB90", Offset = "0x62CB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FB5")]
			[Address(RVA = "0xE14BB0", Offset = "0xE14BB0", VA = "0xE14BB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CBA0", Offset = "0x62CBA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000CB4")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x6006FB6")]
			[Address(RVA = "0xE14BB8", Offset = "0xE14BB8", VA = "0xE14BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CBB0", Offset = "0x62CBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FB7")]
			[Address(RVA = "0xE14BC0", Offset = "0xE14BC0", VA = "0xE14BC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CBC0", Offset = "0x62CBC0")]
			set
			{
			}
		}

		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0xE14AF0", Offset = "0xE14AF0", VA = "0xE14AF0")]
		public EngageRequest(string decisionPoint)
		{
		}

		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xE14BC8", Offset = "0xE14BC8", VA = "0xE14BC8")]
		public string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0xE15190", Offset = "0xE15190", VA = "0xE15190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
