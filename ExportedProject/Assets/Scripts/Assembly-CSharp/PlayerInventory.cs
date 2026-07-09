using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000386")]
public class PlayerInventory : ScriptableObject
{
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x18")]
	public int Money;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x20")]
	public WeaponData Weapon;

	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x28")]
	public AttachmentInfo[] Attachments;

	[Token(Token = "0x6001575")]
	[Address(RVA = "0xB8B280", Offset = "0xB8B280", VA = "0xB8B280")]
	public PlayerInventory()
	{
	}
}
