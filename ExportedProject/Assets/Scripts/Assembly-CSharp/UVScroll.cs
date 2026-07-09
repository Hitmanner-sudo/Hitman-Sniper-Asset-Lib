using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007E2")]
[Attribute(Name = "RequireComponent", RVA = "0x5963F0", Offset = "0x5963F0")]
[Attribute(Name = "GameUpdateOrderAttribute", RVA = "0x5963F0", Offset = "0x5963F0")]
public class UVScroll : GameMonoBehaviour
{
	[Token(Token = "0x4002BF4")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 velocity;

	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 precisionLoop;

	[Token(Token = "0x4002BF6")]
	[FieldOffset(Offset = "0x58")]
	private Material _material;

	[Token(Token = "0x600339D")]
	[Address(RVA = "0x1176848", Offset = "0x1176848", VA = "0x1176848", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0x1176A98", Offset = "0x1176A98", VA = "0x1176A98")]
	public UVScroll()
	{
	}
}
