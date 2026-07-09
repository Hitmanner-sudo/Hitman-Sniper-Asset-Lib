using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E4B")]
	public class AnalyticEvent
	{
		[Token(Token = "0x40043AF")]
		private const string NAME = "s__Name";

		[Token(Token = "0x40043B0")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type[] _allowedModuleTypes;

		[Token(Token = "0x40043B1")]
		[FieldOffset(Offset = "0x18")]
		private readonly EventKey _key;

		[Token(Token = "0x40043B2")]
		[FieldOffset(Offset = "0x20")]
		private readonly EventAttribute[] _attributes;

		[Token(Token = "0x17000BD1")]
		public EventKey Key
		{
			[Token(Token = "0x60057FB")]
			[Address(RVA = "0xD5FDB0", Offset = "0xD5FDB0", VA = "0xD5FDB0")]
			get
			{
				return default(EventKey);
			}
		}

		[Token(Token = "0x17000BD2")]
		public int Count
		{
			[Token(Token = "0x60057FC")]
			[Address(RVA = "0xD5FDB8", Offset = "0xD5FDB8", VA = "0xD5FDB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60057FD")]
		[Address(RVA = "0xD5FDD4", Offset = "0xD5FDD4", VA = "0xD5FDD4")]
		private AnalyticEvent(EventKey key, EventAttribute[] attributes, Type[] allowedModuleTypes)
		{
		}

		[Token(Token = "0x60057FE")]
		public static AnalyticEvent Instantiate<T1>(EventKey key, EventAttribute[] attributes) where T1 : AnalyticModule
		{
			return null;
		}

		[Token(Token = "0x60057FF")]
		public static AnalyticEvent Instantiate<T1, T2>(EventKey key, EventAttribute[] attributes) where T1 : AnalyticModule where T2 : AnalyticModule
		{
			return null;
		}

		[Token(Token = "0x6005800")]
		public static AnalyticEvent Instantiate<T1, T2, T3>(EventKey key, EventAttribute[] attributes) where T1 : AnalyticModule where T2 : AnalyticModule where T3 : AnalyticModule
		{
			return null;
		}

		[Token(Token = "0x6005801")]
		[Address(RVA = "0xD5FE14", Offset = "0xD5FE14", VA = "0xD5FE14")]
		public void FillValues(Dictionary<string, object> attributeValues, Type forModuleOfType)
		{
		}
	}
}
