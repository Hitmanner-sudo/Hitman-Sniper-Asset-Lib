using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace HSMiniJSON
{
	[Token(Token = "0x20012CA")]
	public static class Json
	{
		[Token(Token = "0x20012CB")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20012CC")]
			private enum TOKEN
			{
				[Token(Token = "0x4005A13")]
				NONE = 0,
				[Token(Token = "0x4005A14")]
				CURLY_OPEN = 1,
				[Token(Token = "0x4005A15")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x4005A16")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x4005A17")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x4005A18")]
				COLON = 5,
				[Token(Token = "0x4005A19")]
				COMMA = 6,
				[Token(Token = "0x4005A1A")]
				STRING = 7,
				[Token(Token = "0x4005A1B")]
				NUMBER = 8,
				[Token(Token = "0x4005A1C")]
				TRUE = 9,
				[Token(Token = "0x4005A1D")]
				FALSE = 10,
				[Token(Token = "0x4005A1E")]
				NULL = 11
			}

			[Token(Token = "0x4005A10")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4005A11")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000C51")]
			private char PeekChar
			{
				[Token(Token = "0x6006D9B")]
				[Address(RVA = "0xB2D268", Offset = "0xB2D268", VA = "0xB2D268")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000C52")]
			private char NextChar
			{
				[Token(Token = "0x6006D9C")]
				[Address(RVA = "0xB2D07C", Offset = "0xB2D07C", VA = "0xB2D07C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000C53")]
			private string NextWord
			{
				[Token(Token = "0x6006D9D")]
				[Address(RVA = "0xB2D100", Offset = "0xB2D100", VA = "0xB2D100")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C54")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6006D9E")]
				[Address(RVA = "0xB2C980", Offset = "0xB2C980", VA = "0xB2C980")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6006D90")]
			[Address(RVA = "0xB2C56C", Offset = "0xB2C56C", VA = "0xB2C56C")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6006D91")]
			[Address(RVA = "0xB2C614", Offset = "0xB2C614", VA = "0xB2C614")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6006D92")]
			[Address(RVA = "0xB2C68C", Offset = "0xB2C68C", VA = "0xB2C68C")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6006D93")]
			[Address(RVA = "0xB2C824", Offset = "0xB2C824", VA = "0xB2C824", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6006D94")]
			[Address(RVA = "0xB2C858", Offset = "0xB2C858", VA = "0xB2C858")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6006D95")]
			[Address(RVA = "0xB2CDD8", Offset = "0xB2CDD8", VA = "0xB2CDD8")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6006D96")]
			[Address(RVA = "0xB2C7FC", Offset = "0xB2C7FC", VA = "0xB2C7FC")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6006D97")]
			[Address(RVA = "0xB2CEC0", Offset = "0xB2CEC0", VA = "0xB2CEC0")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6006D98")]
			[Address(RVA = "0xB2CB44", Offset = "0xB2CB44", VA = "0xB2CB44")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6006D99")]
			[Address(RVA = "0xB2CF98", Offset = "0xB2CF98", VA = "0xB2CF98")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6006D9A")]
			[Address(RVA = "0xB2D1B8", Offset = "0xB2D1B8", VA = "0xB2D1B8")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x20012CD")]
		private sealed class Serializer
		{
			[Token(Token = "0x4005A1F")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6006D9F")]
			[Address(RVA = "0xB2D2EC", Offset = "0xB2D2EC", VA = "0xB2D2EC")]
			private Serializer()
			{
			}

			[Token(Token = "0x6006DA0")]
			[Address(RVA = "0xB2D354", Offset = "0xB2D354", VA = "0xB2D354")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6006DA1")]
			[Address(RVA = "0xB2D3CC", Offset = "0xB2D3CC", VA = "0xB2D3CC")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6006DA2")]
			[Address(RVA = "0xB2DB88", Offset = "0xB2DB88", VA = "0xB2DB88")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6006DA3")]
			[Address(RVA = "0xB2D880", Offset = "0xB2D880", VA = "0xB2D880")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6006DA4")]
			[Address(RVA = "0xB2D5B8", Offset = "0xB2D5B8", VA = "0xB2D5B8")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6006DA5")]
			[Address(RVA = "0xB2DFC8", Offset = "0xB2DFC8", VA = "0xB2DFC8")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x6006D8E")]
		[Address(RVA = "0x990D98", Offset = "0x990D98", VA = "0x990D98")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x990DA8", Offset = "0x990DA8", VA = "0x990DA8")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
