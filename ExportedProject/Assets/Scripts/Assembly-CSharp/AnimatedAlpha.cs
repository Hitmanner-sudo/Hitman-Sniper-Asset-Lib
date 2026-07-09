using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006A")]
public class AnimatedAlpha : MonoBehaviour
{
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x18")]
	public float alpha;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget mWidget;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x28")]
	private UIPanel mPanel;

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xD44740", Offset = "0xD44740", VA = "0xD44740")]
	private void Awake()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xD447BC", Offset = "0xD447BC", VA = "0xD447BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD448A0", Offset = "0xD448A0", VA = "0xD448A0")]
	public AnimatedAlpha()
	{
	}
}
