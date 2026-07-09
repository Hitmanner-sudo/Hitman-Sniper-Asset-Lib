using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006BC")]
public class PerksView : MainMenuPageView
{
	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _perkItemPrefab;

	[Token(Token = "0x40025B7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UIGrid _perkItemsUIGrid;

	[Token(Token = "0x40025B8")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UIAlignChildOnPanelEdges _perkItemsUIAlignChildOnPanelEdges;

	[Token(Token = "0x40025B9")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Vector2 _minPaddingBetweenElements;

	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private LazyWeaponUnlockable _zombieWeaponIAPLazyWeaponUnlockable;

	[Token(Token = "0x40025BB")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UIPanel _uiPanel;

	[Token(Token = "0x40025BC")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private UISprite _bannerUISprite;

	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UILabel _bannerUILabel;

	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Transform _perkItemPanelTransform;

	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private UIAlignChildOnPanelEdges _uiAlignChildOnPanelEdges;

	[Token(Token = "0x40025C0")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private GameObject _bannerButtonGO;

	[Token(Token = "0x40025C1")]
	[FieldOffset(Offset = "0xF0")]
	private readonly List<PerkItemView> _perkItemViews;

	[Token(Token = "0x40025C2")]
	[FieldOffset(Offset = "0xF8")]
	private float _cacheHeightUIPanel;

	[Token(Token = "0x6002C47")]
	[Address(RVA = "0x9027E4", Offset = "0x9027E4", VA = "0x9027E4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002C48")]
	[Address(RVA = "0x902C2C", Offset = "0x902C2C", VA = "0x902C2C", Slot = "16")]
	public override void LoadView()
	{
	}

	[Token(Token = "0x6002C49")]
	[Address(RVA = "0x902D28", Offset = "0x902D28", VA = "0x902D28", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C4A")]
	[Address(RVA = "0x903258", Offset = "0x903258", VA = "0x903258", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002C4B")]
	[Address(RVA = "0x903340", Offset = "0x903340", VA = "0x903340")]
	private void OnPageCentered(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002C4C")]
	[Address(RVA = "0x903174", Offset = "0x903174", VA = "0x903174")]
	private void FixUIPanel()
	{
	}

	[Token(Token = "0x6002C4D")]
	[Address(RVA = "0x902C30", Offset = "0x902C30", VA = "0x902C30")]
	public void SetNewFeedback()
	{
	}

	[Token(Token = "0x6002C4E")]
	[Address(RVA = "0x903344", Offset = "0x903344", VA = "0x903344")]
	private void SetNewFeedbackSeen()
	{
	}

	[Token(Token = "0x6002C4F")]
	[Address(RVA = "0x902814", Offset = "0x902814", VA = "0x902814")]
	private void CreateElements()
	{
	}

	[Token(Token = "0x6002C50")]
	[Address(RVA = "0x903430", Offset = "0x903430", VA = "0x903430")]
	private bool IsHalfPriceWeaponOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C51")]
	[Address(RVA = "0x902DE0", Offset = "0x902DE0", VA = "0x902DE0")]
	private void SetPerksPrice()
	{
	}

	[Token(Token = "0x6002C52")]
	[Address(RVA = "0x902F2C", Offset = "0x902F2C", VA = "0x902F2C")]
	private void SetBanner()
	{
	}

	[Token(Token = "0x6002C53")]
	[Address(RVA = "0x902994", Offset = "0x902994", VA = "0x902994")]
	private void PositionGrid()
	{
	}

	[Token(Token = "0x6002C54")]
	[Address(RVA = "0x903508", Offset = "0x903508", VA = "0x903508", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C55")]
	[Address(RVA = "0x9036FC", Offset = "0x9036FC", VA = "0x9036FC")]
	public PerksView()
	{
	}
}
