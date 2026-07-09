using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace DeltaDNA.MiniJSON
{
	[Token(Token = "0x2001344")]
	public static class Json
	{
		[Token(Token = "0x2001345")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2001346")]
			private enum TOKEN
			{
				[Token(Token = "0x4005C42")]
				NONE = 0,
				[Token(Token = "0x4005C43")]
				CURLY_OPEN = 1,
				[Token(Token = "0x4005C44")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x4005C45")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x4005C46")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x4005C47")]
				COLON = 5,
				[Token(Token = "0x4005C48")]
				COMMA = 6,
				[Token(Token = "0x4005C49")]
				STRING = 7,
				[Token(Token = "0x4005C4A")]
				NUMBER = 8,
				[Token(Token = "0x4005C4B")]
				TRUE = 9,
				[Token(Token = "0x4005C4C")]
				FALSE = 10,
				[Token(Token = "0x4005C4D")]
				NULL = 11
			}

			[Token(Token = "0x4005C3F")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4005C40")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000CEF")]
			private char PeekChar
			{
				[Token(Token = "0x6007177")]
				[Address(RVA = "0xB2B66C", Offset = "0xB2B66C", VA = "0xB2B66C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000CF0")]
			private char NextChar
			{
				[Token(Token = "0x6007178")]
				[Address(RVA = "0xB2B480", Offset = "0xB2B480", VA = "0xB2B480")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000CF1")]
			private string NextWord
			{
				[Token(Token = "0x6007179")]
				[Address(RVA = "0xB2B504", Offset = "0xB2B504", VA = "0xB2B504")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF2")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600717A")]
				[Address(RVA = "0xB2ACD4", Offset = "0xB2ACD4", VA = "0xB2ACD4")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600716C")]
			[Address(RVA = "0xB2A8C0", Offset = "0xB2A8C0", VA = "0xB2A8C0")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600716D")]
			[Address(RVA = "0xB2A968", Offset = "0xB2A968", VA = "0xB2A968")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600716E")]
			[Address(RVA = "0xB2A9E0", Offset = "0xB2A9E0", VA = "0xB2A9E0")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x600716F")]
			[Address(RVA = "0xB2AB78", Offset = "0xB2AB78", VA = "0xB2AB78", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6007170")]
			[Address(RVA = "0xB2ABAC", Offset = "0xB2ABAC", VA = "0xB2ABAC")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6007171")]
			[Address(RVA = "0xB2B12C", Offset = "0xB2B12C", VA = "0xB2B12C")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6007172")]
			[Address(RVA = "0xB2AB50", Offset = "0xB2AB50", VA = "0xB2AB50")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6007173")]
			[Address(RVA = "0xB2B214", Offset = "0xB2B214", VA = "0xB2B214")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6007174")]
			[Address(RVA = "0xB2AE98", Offset = "0xB2AE98", VA = "0xB2AE98")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6007175")]
			[Address(RVA = "0xB2B2EC", Offset = "0xB2B2EC", VA = "0xB2B2EC")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6007176")]
			[Address(RVA = "0xB2B5BC", Offset = "0xB2B5BC", VA = "0xB2B5BC")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2001347")]
		private sealed class Serializer
		{
			[Token(Token = "0x4005C4E")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x600717B")]
			[Address(RVA = "0xB2B6F0", Offset = "0xB2B6F0", VA = "0xB2B6F0")]
			private Serializer()
			{
			}

			[Token(Token = "0x600717C")]
			[Address(RVA = "0xB2B758", Offset = "0xB2B758", VA = "0xB2B758")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600717D")]
			[Address(RVA = "0xB2B7D0", Offset = "0xB2B7D0", VA = "0xB2B7D0")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600717E")]
			[Address(RVA = "0xB2BE30", Offset = "0xB2BE30", VA = "0xB2BE30")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x600717F")]
			[Address(RVA = "0xB2BC84", Offset = "0xB2BC84", VA = "0xB2BC84")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6007180")]
			[Address(RVA = "0xB2B9BC", Offset = "0xB2B9BC", VA = "0xB2B9BC")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6007181")]
			[Address(RVA = "0xB2C270", Offset = "0xB2C270", VA = "0xB2C270")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600716A")]
		[Address(RVA = "0x990D80", Offset = "0x990D80", VA = "0x990D80")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600716B")]
		[Address(RVA = "0x990D90", Offset = "0x990D90", VA = "0x990D90")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
