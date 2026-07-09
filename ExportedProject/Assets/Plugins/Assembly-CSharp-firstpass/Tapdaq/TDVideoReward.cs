using System;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x200007D")]
	public class TDVideoReward
	{
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x10")]
		public string EventId;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x18")]
		public string RewardName;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x20")]
		public int RewardAmount;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x28")]
		public string Location;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x30")]
		public string Tag;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x38")]
		public bool RewardValid;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x40")]
		public object RewardJson;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x18BB500", Offset = "0x18BB500", VA = "0x18BB500")]
		public TDVideoReward()
		{
		}
	}
}
