using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BB7")]
	public class PlayerProfile
	{
		[Token(Token = "0x4003AF3")]
		[FieldOffset(Offset = "0x10")]
		public long PlayerId;

		[Token(Token = "0x4003AF4")]
		[FieldOffset(Offset = "0x18")]
		public string PlayerName;

		[Token(Token = "0x4003AF5")]
		[FieldOffset(Offset = "0x20")]
		public string Alias;

		[Token(Token = "0x4003AF6")]
		[FieldOffset(Offset = "0x28")]
		public int Age;

		[Token(Token = "0x4003AF7")]
		[FieldOffset(Offset = "0x2C")]
		public Gender Gender;

		[Token(Token = "0x4003AF8")]
		[FieldOffset(Offset = "0x30")]
		public Demographic Demographic;

		[Token(Token = "0x4003AF9")]
		[FieldOffset(Offset = "0x38")]
		public Territory Territory;

		[Token(Token = "0x4003AFA")]
		[FieldOffset(Offset = "0x40")]
		public Platform Platform;

		[Token(Token = "0x4003AFB")]
		[FieldOffset(Offset = "0x48")]
		public bool IsNewPlayer;

		[Token(Token = "0x4003AFC")]
		[FieldOffset(Offset = "0x4C")]
		public int TimeOnSeed;

		[Token(Token = "0x6004A62")]
		[Address(RVA = "0xAAD68C", Offset = "0xAAD68C", VA = "0xAAD68C")]
		public PlayerProfile()
		{
		}
	}
}
