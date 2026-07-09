using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000097")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x591C5C", Offset = "0x591C5C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591C5C", Offset = "0x591C5C")]
public class UILocalize : MonoBehaviour
{
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _toUpper;

	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x28")]
	private object[] _formatParams;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x30")]
	private UILabel _uiLabel;

	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x38")]
	private UISprite _uiSprite;

	[Token(Token = "0x170000EB")]
	public string value
	{
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1423AE8", Offset = "0x1423AE8", VA = "0x1423AE8")]
		set
		{
		}
	}

	[Token(Token = "0x170000EC")]
	public bool ToUpper
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1423F3C", Offset = "0x1423F3C", VA = "0x1423F3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x1423D50", Offset = "0x1423D50", VA = "0x1423D50")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x1423F44", Offset = "0x1423F44", VA = "0x1423F44")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x14240C8", Offset = "0x14240C8", VA = "0x14240C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x14241B8", Offset = "0x14241B8", VA = "0x14241B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x1423FF4", Offset = "0x1423FF4", VA = "0x1423FF4")]
	private void OnLocalize(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x1424228", Offset = "0x1424228", VA = "0x1424228")]
	public void SetText(string key, bool toUpper, params object[] formatParams)
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x142423C", Offset = "0x142423C", VA = "0x142423C")]
	public static void SetLabelLocalization(UILabel label, string key, params object[] args)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x14243B8", Offset = "0x14243B8", VA = "0x14243B8")]
	public UILocalize()
	{
	}
}
