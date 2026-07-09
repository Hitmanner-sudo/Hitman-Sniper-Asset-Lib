using System;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B4A")]
	public class ResultListPopupEvent : EventArgs
	{
		[Token(Token = "0x400398D")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x600477C")]
		[Address(RVA = "0x9677A8", Offset = "0x9677A8", VA = "0x9677A8")]
		public ResultListPopupEvent(int id)
		{
		}
	}
}
