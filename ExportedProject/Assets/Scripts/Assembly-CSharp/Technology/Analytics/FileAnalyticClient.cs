using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E58")]
	public class FileAnalyticClient
	{
		[Token(Token = "0x40043D9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, FileAnalyticClient> _instances;

		[Token(Token = "0x40043DA")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Dictionary<string, object>> _metrics;

		[Token(Token = "0x40043DB")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _dbFilePath;

		[Token(Token = "0x6005860")]
		[Address(RVA = "0x951F34", Offset = "0x951F34", VA = "0x951F34")]
		public static FileAnalyticClient Get(Type t)
		{
			return null;
		}

		[Token(Token = "0x6005861")]
		[Address(RVA = "0x952044", Offset = "0x952044", VA = "0x952044")]
		private FileAnalyticClient(Type t)
		{
		}

		[Token(Token = "0x6005862")]
		[Address(RVA = "0x952134", Offset = "0x952134", VA = "0x952134")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62BA60", Offset = "0x62BA60")]
		private static void CreateImportScript()
		{
		}

		[Token(Token = "0x6005863")]
		[Address(RVA = "0x95249C", Offset = "0x95249C", VA = "0x95249C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62BA98", Offset = "0x62BA98")]
		public void OnFlush()
		{
		}

		[Token(Token = "0x6005864")]
		[Address(RVA = "0x95273C", Offset = "0x95273C", VA = "0x95273C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62BAD0", Offset = "0x62BAD0")]
		public void OnSendEvent(EventKey eventKey, Dictionary<string, object> attributes)
		{
		}
	}
}
