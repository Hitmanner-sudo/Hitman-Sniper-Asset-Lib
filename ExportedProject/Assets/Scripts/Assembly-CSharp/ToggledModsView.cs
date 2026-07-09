using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000768")]
public class ToggledModsView : View
{
	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid ModsGrid;

	[Token(Token = "0x40029EE")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ModItemViewPrefab;

	[Token(Token = "0x40029EF")]
	[FieldOffset(Offset = "0x70")]
	private List<ToggledModItemSlotView> _modsView;

	[Token(Token = "0x6003146")]
	[Address(RVA = "0xAD1E78", Offset = "0xAD1E78", VA = "0xAD1E78", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6003147")]
	[Address(RVA = "0xAD2344", Offset = "0xAD2344", VA = "0xAD2344")]
	public void UpdatePowerUps()
	{
	}

	[Token(Token = "0x6003148")]
	[Address(RVA = "0xAD2458", Offset = "0xAD2458", VA = "0xAD2458")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6003149")]
	[Address(RVA = "0xAD2258", Offset = "0xAD2258", VA = "0xAD2258")]
	private void PositionGrid()
	{
	}

	[Token(Token = "0x600314A")]
	[Address(RVA = "0xAD256C", Offset = "0xAD256C", VA = "0xAD256C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600314B")]
	[Address(RVA = "0xAD26E8", Offset = "0xAD26E8", VA = "0xAD26E8")]
	public ToggledModsView()
	{
	}
}
