using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000754")]
public class WeaponTierView : View
{
	[Token(Token = "0x4002965")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _visualContainer;

	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISprite _tierIcon;

	[Token(Token = "0x4002967")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _filledStar;

	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _percentageBanner;

	[Token(Token = "0x4002969")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _tierScoreMuliplierLabel;

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x879618", Offset = "0x879618", VA = "0x879618")]
	public void RefreshVisual()
	{
	}

	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x87982C", Offset = "0x87982C", VA = "0x87982C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x879928", Offset = "0x879928", VA = "0x879928")]
	public WeaponTierView()
	{
	}
}
