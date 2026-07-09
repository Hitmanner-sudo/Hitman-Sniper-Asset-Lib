using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012FB")]
	public class GameEvent<T> where T : GameEvent<T>
	{
		[Token(Token = "0x4005B06")]
		[FieldOffset(Offset = "0x0")]
		internal readonly Params parameters;

		[Token(Token = "0x4005B07")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611118", Offset = "0x611118")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x17000CA5")]
		public string Name
		{
			[Token(Token = "0x6006F77")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB50", Offset = "0x62CB50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CB60", Offset = "0x62CB60")]
			private set
			{
			}
		}

		[Token(Token = "0x6006F76")]
		public GameEvent(string name)
		{
		}

		[Token(Token = "0x6006F79")]
		public T AddParam(string key, object value)
		{
			return null;
		}

		[Token(Token = "0x6006F7A")]
		public Dictionary<string, object> AsDictionary()
		{
			return null;
		}
	}
	[Token(Token = "0x20012FC")]
	public class GameEvent : GameEvent<GameEvent>
	{
		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0xD95790", Offset = "0xD95790", VA = "0xD95790")]
		public GameEvent(string name)
		{
		}
	}
}
