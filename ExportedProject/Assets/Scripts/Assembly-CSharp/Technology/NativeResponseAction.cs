using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology
{
	[Token(Token = "0x2000AC6")]
	public class NativeResponseAction
	{
		[Token(Token = "0x400372D")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC068", Offset = "0x5BC068")]
		private Action<JSONNode> _003CResponseAction_003Ek__BackingField;

		[Token(Token = "0x1700088B")]
		public Action<JSONNode> ResponseAction
		{
			[Token(Token = "0x6004344")]
			[Address(RVA = "0xC57C60", Offset = "0xC57C60", VA = "0xC57C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E18", Offset = "0x625E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004345")]
			[Address(RVA = "0xC57C68", Offset = "0xC57C68", VA = "0xC57C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E28", Offset = "0x625E28")]
			private set
			{
			}
		}

		[Token(Token = "0x6004346")]
		[Address(RVA = "0xC57C70", Offset = "0xC57C70", VA = "0xC57C70")]
		public NativeResponseAction(Action<JSONNode> responseAction)
		{
		}
	}
}
