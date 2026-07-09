using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x591604", Offset = "0x591604")]
public class AnimatedColor : MonoBehaviour
{
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget mWidget;

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD448B0", Offset = "0xD448B0", VA = "0xD448B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD44904", Offset = "0xD44904", VA = "0xD44904")]
	private void Update()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xD44930", Offset = "0xD44930", VA = "0xD44930")]
	public AnimatedColor()
	{
	}
}
