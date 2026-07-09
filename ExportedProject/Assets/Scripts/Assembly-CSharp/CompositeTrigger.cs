using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000874")]
public class CompositeTrigger : ColoredTrigger
{
	[NonSerialized]
	[Token(Token = "0x4002F6D")]
	[FieldOffset(Offset = "0x58")]
	public BoxCollider[] Colliders;

	[Token(Token = "0x600374D")]
	[Address(RVA = "0x8DF768", Offset = "0x8DF768", VA = "0x8DF768", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0x8DFA24", Offset = "0x8DFA24", VA = "0x8DFA24")]
	public CompositeTrigger()
	{
	}
}
