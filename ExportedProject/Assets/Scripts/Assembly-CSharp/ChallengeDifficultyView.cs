using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000643")]
public class ChallengeDifficultyView : View
{
	[Token(Token = "0x4002276")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SurvivorImageUISprite;

	[Token(Token = "0x4002277")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SurvivorImageBackgroundUISprite;

	[Token(Token = "0x4002278")]
	[FieldOffset(Offset = "0x70")]
	public GameObject LockedIconGameObject;

	[Token(Token = "0x4002279")]
	[FieldOffset(Offset = "0x78")]
	public UISprite DifficultyBackgroundUILabel;

	[Token(Token = "0x400227A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DifficultyTextUILabel;

	[Token(Token = "0x400227B")]
	[FieldOffset(Offset = "0x88")]
	public ButtonHandler ButtonHandler;

	[Token(Token = "0x400227C")]
	[FieldOffset(Offset = "0x90")]
	public BoxCollider ButtonBoxCollider;

	[Token(Token = "0x400227D")]
	[FieldOffset(Offset = "0x98")]
	public PointyTooltip Tooltip;

	[Token(Token = "0x400227E")]
	[FieldOffset(Offset = "0xA0")]
	public Color LockedColor;

	[Token(Token = "0x400227F")]
	[FieldOffset(Offset = "0xB0")]
	public Color BackgroundSelectedColor;

	[Token(Token = "0x4002280")]
	[FieldOffset(Offset = "0xC0")]
	public Color BackgroundNotSelectedColor;

	[Token(Token = "0x4002281")]
	[FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public ContractDataModel.DifficultyType Difficulty;

	[Token(Token = "0x4002282")]
	[FieldOffset(Offset = "0xD4")]
	[HideInInspector]
	public bool IsUnlocked;

	[Token(Token = "0x4002283")]
	[FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public int BackgroundWidth;

	[Token(Token = "0x600286C")]
	[Address(RVA = "0xAF38BC", Offset = "0xAF38BC", VA = "0xAF38BC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600286D")]
	[Address(RVA = "0xAF3EC4", Offset = "0xAF3EC4", VA = "0xAF3EC4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600286E")]
	[Address(RVA = "0xAF3D80", Offset = "0xAF3D80", VA = "0xAF3D80")]
	private void AdjustBackgroundWidth()
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0xAF3FBC", Offset = "0xAF3FBC", VA = "0xAF3FBC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002870")]
	[Address(RVA = "0xAF39D4", Offset = "0xAF39D4", VA = "0xAF39D4")]
	private void OnActiveDifficultyTypeChanged(ContractDataModel.DifficultyType difficultyType)
	{
	}

	[Token(Token = "0x6002871")]
	[Address(RVA = "0xAF40BC", Offset = "0xAF40BC", VA = "0xAF40BC")]
	public void ButtonpHandlerPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002872")]
	[Address(RVA = "0xAF40E8", Offset = "0xAF40E8", VA = "0xAF40E8")]
	private void Selected()
	{
	}

	[Token(Token = "0x6002873")]
	[Address(RVA = "0xAF4218", Offset = "0xAF4218", VA = "0xAF4218")]
	private void ShowTooltip()
	{
	}

	[Token(Token = "0x6002874")]
	[Address(RVA = "0xAF4368", Offset = "0xAF4368", VA = "0xAF4368")]
	public ChallengeDifficultyView()
	{
	}
}
