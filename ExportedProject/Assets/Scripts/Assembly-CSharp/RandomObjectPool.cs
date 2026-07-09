using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C4")]
public class RandomObjectPool : MonoBehaviour
{
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> Objects;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x20")]
	public int NumberToKeep;

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0xB3EAA4", Offset = "0xB3EAA4", VA = "0xB3EAA4", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0xB3EBFC", Offset = "0xB3EBFC", VA = "0xB3EBFC")]
	public RandomObjectPool()
	{
	}
}
