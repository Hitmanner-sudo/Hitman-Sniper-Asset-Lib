using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x200007B")]
	public class TestDevicesList
	{
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<string> adMobDevices;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<string> facebookDevices;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x18BB544", Offset = "0x18BB544", VA = "0x18BB544")]
		public TestDevicesList(List<TestDevice> devices, TestDeviceType deviceType)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x18BB764", Offset = "0x18BB764", VA = "0x18BB764", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x18BB76C", Offset = "0x18BB76C", VA = "0x18BB76C")]
		public string GetAdMobListJson()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x18BB778", Offset = "0x18BB778", VA = "0x18BB778")]
		public string GetFacebookListJson()
		{
			return null;
		}
	}
}
