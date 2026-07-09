using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005E")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591580", Offset = "0x591580")]
public class UIEventListener : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x2000060")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x2000061")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x2000062")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x2000063")]
	public delegate void StringDelegate(GameObject go, string text);

	[Token(Token = "0x2000064")]
	public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);

	[Token(Token = "0x2000065")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x18")]
	public object parameter;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x20")]
	public VoidDelegate onSubmit;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x28")]
	public VoidDelegate onClick;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x30")]
	public VoidDelegate onDoubleClick;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x38")]
	public BoolDelegate onHover;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x40")]
	public BoolDelegate onPress;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x48")]
	public BoolDelegate onSelect;

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x50")]
	public FloatDelegate onScroll;

	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x58")]
	public VectorDelegate onDrag;

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x60")]
	public ObjectDelegate onDrop;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x68")]
	public StringDelegate onInput;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x70")]
	public KeyCodeDelegate onKey;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x179C104", Offset = "0x179C104", VA = "0x179C104")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x179C144", Offset = "0x179C144", VA = "0x179C144")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x179C184", Offset = "0x179C184", VA = "0x179C184")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x179C1C4", Offset = "0x179C1C4", VA = "0x179C1C4")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x179C20C", Offset = "0x179C20C", VA = "0x179C20C")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x179C254", Offset = "0x179C254", VA = "0x179C254")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x179C29C", Offset = "0x179C29C", VA = "0x179C29C")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x179C2F0", Offset = "0x179C2F0", VA = "0x179C2F0")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x179C34C", Offset = "0x179C34C", VA = "0x179C34C")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x179C394", Offset = "0x179C394", VA = "0x179C394")]
	private void OnInput(string text)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x179C3DC", Offset = "0x179C3DC", VA = "0x179C3DC")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x179C424", Offset = "0x179C424", VA = "0x179C424")]
	public static UIEventListener Get(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x179C4F0", Offset = "0x179C4F0", VA = "0x179C4F0")]
	public UIEventListener()
	{
	}
}
