using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E5C")]
	public struct EventAttribute
	{
		[Token(Token = "0x40043DC")]
		[FieldOffset(Offset = "0x0")]
		private object _value;

		[Token(Token = "0x40043DD")]
		[FieldOffset(Offset = "0x8")]
		private readonly Schema _attribute;

		[Token(Token = "0x40043DE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type[] _allowedModuleTypes;

		[Token(Token = "0x17000BDD")]
		public string Name
		{
			[Token(Token = "0x6005875")]
			[Address(RVA = "0xE17274", Offset = "0xE17274", VA = "0xE17274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDE")]
		public Schema Attribute
		{
			[Token(Token = "0x6005876")]
			[Address(RVA = "0xE1727C", Offset = "0xE1727C", VA = "0xE1727C")]
			get
			{
				return default(Schema);
			}
		}

		[Token(Token = "0x17000BDF")]
		public object Value
		{
			[Token(Token = "0x6005877")]
			[Address(RVA = "0xE17284", Offset = "0xE17284", VA = "0xE17284")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005878")]
			[Address(RVA = "0xE1728C", Offset = "0xE1728C", VA = "0xE1728C")]
			set
			{
			}
		}

		[Token(Token = "0x17000BE0")]
		public Type[] AllowedModules
		{
			[Token(Token = "0x6005879")]
			[Address(RVA = "0xE17294", Offset = "0xE17294", VA = "0xE17294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600587A")]
		public static EventAttribute Instantiate<T>(Schema attribute, object value) where T : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x600587B")]
		public static EventAttribute Instantiate<T, U>(Schema attribute, object value) where T : AnalyticModule where U : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x600587C")]
		public static EventAttribute Instantiate<T1, T2, T3>(Schema attribute, object value) where T1 : AnalyticModule where T2 : AnalyticModule where T3 : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x600587D")]
		[Address(RVA = "0xE1729C", Offset = "0xE1729C", VA = "0xE1729C")]
		private EventAttribute(Schema attribute, object value, params Type[] allowedModuleTypes)
		{
		}

		[Token(Token = "0x600587E")]
		public static EventAttribute Instantiate<T>(Schema attribute) where T : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x600587F")]
		public static EventAttribute Instantiate<T, U>(Schema attribute) where T : AnalyticModule where U : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x6005880")]
		public static EventAttribute Instantiate<T1, T2, T3>(Schema attribute) where T1 : AnalyticModule where T2 : AnalyticModule where T3 : AnalyticModule
		{
			return default(EventAttribute);
		}

		[Token(Token = "0x6005881")]
		[Address(RVA = "0xE172A8", Offset = "0xE172A8", VA = "0xE172A8")]
		private EventAttribute(Schema attribute, params Type[] allowedModuleTypes)
		{
		}

		[Token(Token = "0x6005882")]
		[Address(RVA = "0xE172B4", Offset = "0xE172B4", VA = "0xE172B4")]
		public void FillValues(Dictionary<string, object> attributeValues, Type forModuleOfType)
		{
		}
	}
}
