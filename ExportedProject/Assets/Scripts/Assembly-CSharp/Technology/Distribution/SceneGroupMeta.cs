using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BDA")]
	public class SceneGroupMeta
	{
		[Token(Token = "0x4003B6F")]
		[FieldOffset(Offset = "0x10")]
		public string Group;

		[Token(Token = "0x4003B70")]
		[FieldOffset(Offset = "0x18")]
		public string AdditivesGroup;

		[Token(Token = "0x6004B21")]
		[Address(RVA = "0xBB2B28", Offset = "0xBB2B28", VA = "0xBB2B28")]
		public SceneGroupMeta(string l_group, string l_additiveGroup)
		{
		}
	}
}
