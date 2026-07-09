using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000019")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x10D77F4", Offset = "0x10D77F4", VA = "0x10D77F4")]
	public void Start()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x10D79E0", Offset = "0x10D79E0", VA = "0x10D79E0", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x10D7CD8", Offset = "0x10D7CD8", VA = "0x10D7CD8")]
	public AlphaButtonClickMask()
	{
	}
}
