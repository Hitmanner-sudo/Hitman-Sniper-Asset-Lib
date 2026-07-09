using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200031D")]
public class AttachmentsUnlockableSaveData : UnlockableSaveData
{
	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x28")]
	public WeaponUnlockableSaveData WeaponForPart;

	[Token(Token = "0x6001318")]
	[Address(RVA = "0xC05AD0", Offset = "0xC05AD0", VA = "0xC05AD0")]
	public AttachmentsUnlockableSaveData()
	{
	}
}
