using System;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x200007A")]
	public class TestDevice
	{
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x18")]
		public TestDeviceType type;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x20")]
		public string adMobId;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		public string facebookId;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x18BB508", Offset = "0x18BB508", VA = "0x18BB508")]
		public TestDevice(string deviceName, TestDeviceType deviceType)
		{
		}
	}
}
