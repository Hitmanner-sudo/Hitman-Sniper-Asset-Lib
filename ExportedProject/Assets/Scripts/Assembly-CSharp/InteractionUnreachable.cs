using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000160")]
public class InteractionUnreachable : AIMemento
{
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x68")]
	public Interaction Interaction;

	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 UnreachablePosition;

	[Token(Token = "0x6000957")]
	[Address(RVA = "0xB17580", Offset = "0xB17580", VA = "0xB17580")]
	public InteractionUnreachable(Interaction interaction)
	{
	}
}
