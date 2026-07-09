using System;
using Il2CppDummyDll;

namespace Technology.Achievement
{
	[Token(Token = "0x2000E73")]
	public class AchievementEvent : EventArgs
	{
		[Token(Token = "0x4004404")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDD4", Offset = "0x5BFDD4")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x17000BF7")]
		public string Id
		{
			[Token(Token = "0x6005916")]
			[Address(RVA = "0xAA83E0", Offset = "0xAA83E0", VA = "0xAA83E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD88", Offset = "0x62BD88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005917")]
			[Address(RVA = "0xAA83E8", Offset = "0xAA83E8", VA = "0xAA83E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD98", Offset = "0x62BD98")]
			private set
			{
			}
		}

		[Token(Token = "0x6005918")]
		[Address(RVA = "0xAA83F0", Offset = "0xAA83F0", VA = "0xAA83F0")]
		public AchievementEvent()
		{
		}

		[Token(Token = "0x6005919")]
		[Address(RVA = "0xAA847C", Offset = "0xAA847C", VA = "0xAA847C")]
		public AchievementEvent(string id)
		{
		}
	}
}
