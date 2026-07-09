using System;
using Il2CppDummyDll;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A72")]
	public class Tuple<T, U>
	{
		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBF38", Offset = "0x5BBF38")]
		private T _003CItem1_003Ek__BackingField;

		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBF48", Offset = "0x5BBF48")]
		private U _003CItem2_003Ek__BackingField;

		[Token(Token = "0x17000873")]
		public T Item1
		{
			[Token(Token = "0x60041EF")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625AF8", Offset = "0x625AF8")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60041F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B08", Offset = "0x625B08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000874")]
		public U Item2
		{
			[Token(Token = "0x60041F1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B18", Offset = "0x625B18")]
			get
			{
				return (U)null;
			}
			[Token(Token = "0x60041F2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B28", Offset = "0x625B28")]
			private set
			{
			}
		}

		[Token(Token = "0x60041F3")]
		public Tuple(T item1, U item2)
		{
		}
	}
}
