using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000798")]
public class UIAlignChildOnPanelEdges : MonoBehaviour
{
	[Token(Token = "0x4002AC6")]
	[FieldOffset(Offset = "0x18")]
	public float springStrength;

	[Token(Token = "0x4002AC7")]
	[FieldOffset(Offset = "0x1C")]
	public float TopEdgeOffset;

	[Token(Token = "0x4002AC8")]
	[FieldOffset(Offset = "0x20")]
	public float BottomEdgeOffset;

	[Token(Token = "0x4002AC9")]
	[FieldOffset(Offset = "0x28")]
	public SpringPanel.OnFinished onFinished;

	[Token(Token = "0x4002ACA")]
	[FieldOffset(Offset = "0x30")]
	private UIDraggablePanel mDrag;

	[Token(Token = "0x4002ACB")]
	[FieldOffset(Offset = "0x38")]
	private UIGrid mGrid;

	[Token(Token = "0x6003246")]
	[Address(RVA = "0x1575EA4", Offset = "0x1575EA4", VA = "0x1575EA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003247")]
	[Address(RVA = "0x15768D8", Offset = "0x15768D8", VA = "0x15768D8")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x6003248")]
	[Address(RVA = "0x1575EA8", Offset = "0x1575EA8", VA = "0x1575EA8")]
	public void Realign()
	{
	}

	[Token(Token = "0x6003249")]
	[Address(RVA = "0x1576910", Offset = "0x1576910", VA = "0x1576910")]
	public UIAlignChildOnPanelEdges()
	{
	}
}
