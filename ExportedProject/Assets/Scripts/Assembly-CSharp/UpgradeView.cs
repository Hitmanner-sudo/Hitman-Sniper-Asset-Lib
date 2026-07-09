using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000774")]
public class UpgradeView : View
{
	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _rogueArrivalTimerGO;

	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _mainRogueAnchor;

	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISprite _healButtonBackground;

	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BlinkButtonHandler _healButtonHandler;

	[Token(Token = "0x4002A32")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _statsBackground;

	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIGrid _statBars;

	[Token(Token = "0x4002A34")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject _statBarPrefab;

	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private PowerUpsUpgradeView _powerUpsUpgradeView;

	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ToggledModsView _toggledModsView;

	[Token(Token = "0x4002A37")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UILabel _currentCost;

	[Token(Token = "0x4002A38")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private PointyTooltip _tutorialCreditsTooltip;

	[Token(Token = "0x4002A39")]
	[FieldOffset(Offset = "0xB8")]
	private List<UpgradeStatView> _statViews;

	[Token(Token = "0x600318E")]
	[Address(RVA = "0xB9FF48", Offset = "0xB9FF48", VA = "0xB9FF48", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600318F")]
	[Address(RVA = "0xBA0C70", Offset = "0xBA0C70", VA = "0xBA0C70", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003190")]
	[Address(RVA = "0xBA0880", Offset = "0xBA0880", VA = "0xBA0880")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6003191")]
	[Address(RVA = "0xBA0E50", Offset = "0xBA0E50", VA = "0xBA0E50")]
	private void OnSurvivorDataChanged(RogueData rogue)
	{
	}

	[Token(Token = "0x6003192")]
	[Address(RVA = "0xBA0EF4", Offset = "0xBA0EF4", VA = "0xBA0EF4")]
	private void InstantiateRogueIcon(RogueData rogueData, ContractData.RogueArrivalTimerData rogueArrivalTimerData)
	{
	}

	[Token(Token = "0x6003193")]
	[Address(RVA = "0xBA05D4", Offset = "0xBA05D4", VA = "0xBA05D4")]
	private void CreateStatBar(int currentLevel, int maxLevel, string title, string tooltipDescription, string statFormat, string nonLocalizedID, Action<WeaponData, GameplayConfig, int> setter, Func<int, float> upgradePercentageFunc)
	{
	}

	[Token(Token = "0x6003194")]
	[Address(RVA = "0xBA0FC0", Offset = "0xBA0FC0", VA = "0xBA0FC0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6003195")]
	[Address(RVA = "0xBA11AC", Offset = "0xBA11AC", VA = "0xBA11AC")]
	private void OnIGCChanged(bool changed)
	{
	}

	[Token(Token = "0x6003196")]
	[Address(RVA = "0xBA12E8", Offset = "0xBA12E8", VA = "0xBA12E8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003197")]
	[Address(RVA = "0xBA1464", Offset = "0xBA1464", VA = "0xBA1464")]
	public UpgradeView()
	{
	}
}
