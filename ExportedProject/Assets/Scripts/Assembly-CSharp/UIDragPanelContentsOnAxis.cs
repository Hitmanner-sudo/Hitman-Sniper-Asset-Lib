using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x596188", Offset = "0x596188")]
[ExecuteInEditMode]
public class UIDragPanelContentsOnAxis : MonoBehaviour
{
	[Token(Token = "0x20007A2")]
	public enum AxisType
	{
		[Token(Token = "0x4002AFC")]
		Horizontal = 0,
		[Token(Token = "0x4002AFD")]
		Vertical = 1
	}

	[Token(Token = "0x4002AF9")]
	[FieldOffset(Offset = "0x18")]
	public AxisType Axis;

	[Token(Token = "0x4002AFA")]
	[FieldOffset(Offset = "0x20")]
	public UIDraggablePanel draggablePanel;

	[Token(Token = "0x6003278")]
	[Address(RVA = "0x1797D20", Offset = "0x1797D20", VA = "0x1797D20")]
	private void Start()
	{
	}

	[Token(Token = "0x6003279")]
	[Address(RVA = "0x1797DF8", Offset = "0x1797DF8", VA = "0x1797DF8")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x600327A")]
	[Address(RVA = "0x1797EF8", Offset = "0x1797EF8", VA = "0x1797EF8")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600327B")]
	[Address(RVA = "0x1798028", Offset = "0x1798028", VA = "0x1798028")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x600327C")]
	[Address(RVA = "0x1798128", Offset = "0x1798128", VA = "0x1798128")]
	public UIDragPanelContentsOnAxis()
	{
	}
}
