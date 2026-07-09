using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007E3")]
[Attribute(Name = "GameUpdateOrderAttribute", RVA = "0x596464", Offset = "0x596464")]
[Attribute(Name = "RequireComponent", RVA = "0x596464", Offset = "0x596464")]
public class UVSet : GameMonoBehaviour
{
	[Token(Token = "0x4002BF7")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 UV;

	[Token(Token = "0x4002BF8")]
	[FieldOffset(Offset = "0x50")]
	private Material _material;

	[Token(Token = "0x600339F")]
	[Address(RVA = "0x1176AA8", Offset = "0x1176AA8", VA = "0x1176AA8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x1176C10", Offset = "0x1176C10", VA = "0x1176C10", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x1176CCC", Offset = "0x1176CCC", VA = "0x1176CCC")]
	public UVSet()
	{
	}
}
