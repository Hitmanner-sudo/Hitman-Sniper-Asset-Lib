using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B16")]
	public class PromotedIAPChangedArgs : EventArgs
	{
		[Token(Token = "0x4003890")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _newId;

		[Token(Token = "0x170008B1")]
		public string NewId
		{
			[Token(Token = "0x6004555")]
			[Address(RVA = "0xB39E64", Offset = "0xB39E64", VA = "0xB39E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004556")]
		[Address(RVA = "0xB39E6C", Offset = "0xB39E6C", VA = "0xB39E6C")]
		public PromotedIAPChangedArgs(string newId)
		{
		}
	}
}
