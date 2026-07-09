using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000642")]
public class BlueprintNavDotView : View
{
	[Token(Token = "0x4002272")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UISprite _unlocked;

	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _locked;

	[Token(Token = "0x4002274")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _onSale;

	[Token(Token = "0x4002275")]
	[FieldOffset(Offset = "0x78")]
	private UISprite[] _lockedSprites;

	[Token(Token = "0x6002865")]
	[Address(RVA = "0xC7A20C", Offset = "0xC7A20C", VA = "0xC7A20C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0xC7A278", Offset = "0xC7A278", VA = "0xC7A278", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002867")]
	[Address(RVA = "0xC7A7E0", Offset = "0xC7A7E0", VA = "0xC7A7E0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0xC7A358", Offset = "0xC7A358", VA = "0xC7A358")]
	private void OnUnlockedStateChanged(bool unlocked)
	{
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0xC7A3E0", Offset = "0xC7A3E0", VA = "0xC7A3E0")]
	private void OnSelectedStateChanged(bool selected)
	{
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0xC7A7C0", Offset = "0xC7A7C0", VA = "0xC7A7C0")]
	private void OnOnSaleStateChanged(bool onSale)
	{
	}

	[Token(Token = "0x600286B")]
	[Address(RVA = "0xC7AA14", Offset = "0xC7AA14", VA = "0xC7AA14")]
	public BlueprintNavDotView()
	{
	}
}
