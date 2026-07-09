using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000029")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590D4C", Offset = "0x590D4C")]
[ExecuteInEditMode]
public class UIDragPanelContents : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x18")]
	public UIDraggablePanel draggablePanel;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1797118", Offset = "0x1797118", VA = "0x1797118")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x17971F0", Offset = "0x17971F0", VA = "0x17971F0")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x17975A0", Offset = "0x17975A0", VA = "0x17975A0")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1797B14", Offset = "0x1797B14", VA = "0x1797B14")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1797D18", Offset = "0x1797D18", VA = "0x1797D18")]
	public UIDragPanelContents()
	{
	}
}
