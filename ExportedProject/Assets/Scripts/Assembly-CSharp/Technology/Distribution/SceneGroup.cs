using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Common;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BFA")]
	public class SceneGroup : NamedObject
	{
		[Token(Token = "0x4003BEA")]
		[FieldOffset(Offset = "0x18")]
		public string Parent;

		[Token(Token = "0x4003BEB")]
		[FieldOffset(Offset = "0x20")]
		public List<Scene> Scenes;

		[Token(Token = "0x4003BEC")]
		[FieldOffset(Offset = "0x28")]
		public Scene Root;

		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0xBB2A7C", Offset = "0xBB2A7C", VA = "0xBB2A7C")]
		public SceneGroup(string name)
		{
		}
	}
}
