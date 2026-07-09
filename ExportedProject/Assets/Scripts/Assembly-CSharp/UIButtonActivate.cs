using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001B")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590A84", Offset = "0x590A84")]
public class UIButtonActivate : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x20")]
	public bool state;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x157B318", Offset = "0x157B318", VA = "0x157B318")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x157B3DC", Offset = "0x157B3DC", VA = "0x157B3DC")]
	public UIButtonActivate()
	{
	}
}
