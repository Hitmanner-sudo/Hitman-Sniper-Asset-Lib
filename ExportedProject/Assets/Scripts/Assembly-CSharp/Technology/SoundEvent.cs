using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A61")]
	public class SoundEvent : ScriptableObject
	{
		[Token(Token = "0x2000A62")]
		public enum SoundType
		{
			[Token(Token = "0x400363C")]
			ReloadStage1 = 0,
			[Token(Token = "0x400363D")]
			ReloadStage2 = 1,
			[Token(Token = "0x400363E")]
			ReloadStage3_Fail = 2,
			[Token(Token = "0x400363F")]
			ReloadStage3_Success = 3,
			[Token(Token = "0x4003640")]
			ReloadStage4_Fail = 4,
			[Token(Token = "0x4003641")]
			ReloadStage4_Success = 5
		}

		[Token(Token = "0x400363A")]
		[FieldOffset(Offset = "0x18")]
		public SoundType PlaylistType;

		[Token(Token = "0x60041AF")]
		[Address(RVA = "0xA6F17C", Offset = "0xA6F17C", VA = "0xA6F17C")]
		public SoundEvent()
		{
		}
	}
}
