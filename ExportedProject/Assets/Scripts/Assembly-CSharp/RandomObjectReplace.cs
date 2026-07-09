using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C5")]
public class RandomObjectReplace : MonoBehaviour
{
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> Objects;

	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ReplaceWith;

	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x28")]
	public int NumberToReplace;

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0xB3EC7C", Offset = "0xB3EC7C", VA = "0xB3EC7C", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0xB3EEB8", Offset = "0xB3EEB8", VA = "0xB3EEB8")]
	public RandomObjectReplace()
	{
	}
}
