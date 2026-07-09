using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200031E")]
public class DropList : ScriptableObject
{
	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x18")]
	public LazyWeaponPart[] DroppableItemsPath;

	[Token(Token = "0x6001319")]
	[Address(RVA = "0xC204F4", Offset = "0xC204F4", VA = "0xC204F4")]
	public DropList()
	{
	}
}
