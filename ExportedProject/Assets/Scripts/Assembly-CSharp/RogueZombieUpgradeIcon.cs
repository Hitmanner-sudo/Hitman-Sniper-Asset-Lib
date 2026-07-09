using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000546")]
public class RogueZombieUpgradeIcon : View
{
	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x60")]
	public UISprite RogueIconUISprite;

	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x68")]
	public UISprite RogueHealthUISprite;

	[Token(Token = "0x4001C00")]
	[FieldOffset(Offset = "0x70")]
	public UISprite ContourUISprite;

	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x78")]
	public PointyTooltip Tooltip;

	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ButtonHandler TooltipHandler;

	[Token(Token = "0x4001C03")]
	[FieldOffset(Offset = "0x88")]
	private RogueData _rogueData;

	[Token(Token = "0x6002118")]
	[Address(RVA = "0x973500", Offset = "0x973500", VA = "0x973500")]
	public void SetParameters(RogueData rogueData, ContractData.RogueArrivalTimerData rogueArrivalTimerData)
	{
	}

	[Token(Token = "0x6002119")]
	[Address(RVA = "0x973578", Offset = "0x973578", VA = "0x973578", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600211A")]
	[Address(RVA = "0x973774", Offset = "0x973774", VA = "0x973774", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600211B")]
	[Address(RVA = "0x97386C", Offset = "0x97386C", VA = "0x97386C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600211C")]
	[Address(RVA = "0x97395C", Offset = "0x97395C", VA = "0x97395C")]
	private void ShowTooltipButtonPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600211D")]
	[Address(RVA = "0x97397C", Offset = "0x97397C", VA = "0x97397C")]
	private void DisplayTooltip()
	{
	}

	[Token(Token = "0x600211E")]
	[Address(RVA = "0x973670", Offset = "0x973670", VA = "0x973670")]
	public void UpdateIconHealth(float healthRatio)
	{
	}

	[Token(Token = "0x600211F")]
	[Address(RVA = "0x973AEC", Offset = "0x973AEC", VA = "0x973AEC")]
	public RogueZombieUpgradeIcon()
	{
	}
}
