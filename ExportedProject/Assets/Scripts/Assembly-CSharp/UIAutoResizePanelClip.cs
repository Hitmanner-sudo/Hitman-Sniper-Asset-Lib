using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079D")]
[Attribute(Name = "RequireComponent", RVA = "0x596108", Offset = "0x596108")]
public class UIAutoResizePanelClip : MonoBehaviour
{
	[Token(Token = "0x4002AE3")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BAAB4", Offset = "0x5BAAB4")]
	public UIWidget Target;

	[Token(Token = "0x4002AE4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 _border;

	[Token(Token = "0x4002AE5")]
	[FieldOffset(Offset = "0x28")]
	private UIPanel _panel;

	[Token(Token = "0x600325E")]
	[Address(RVA = "0x157A7B0", Offset = "0x157A7B0", VA = "0x157A7B0")]
	protected void Start()
	{
	}

	[Token(Token = "0x600325F")]
	[Address(RVA = "0x157A808", Offset = "0x157A808", VA = "0x157A808")]
	protected void Update()
	{
	}

	[Token(Token = "0x6003260")]
	[Address(RVA = "0x157A850", Offset = "0x157A850", VA = "0x157A850")]
	public UIAutoResizePanelClip()
	{
	}
}
