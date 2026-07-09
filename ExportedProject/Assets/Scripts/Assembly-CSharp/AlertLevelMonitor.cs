using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000431")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593C10", Offset = "0x593C10")]
public class AlertLevelMonitor : FsmStateAction
{
	[Token(Token = "0x2000432")]
	public enum MonitorMode
	{
		[Token(Token = "0x4001739")]
		Global = 0,
		[Token(Token = "0x400173A")]
		Personal = 1
	}

	[Token(Token = "0x400172C")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter Filter;

	[Token(Token = "0x400172D")]
	[FieldOffset(Offset = "0x58")]
	public bool TriggerOnAllClear;

	[Token(Token = "0x400172E")]
	[FieldOffset(Offset = "0x59")]
	public bool TriggerOnCurious;

	[Token(Token = "0x400172F")]
	[FieldOffset(Offset = "0x5A")]
	public bool TriggerOnSuspicious;

	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x5B")]
	public bool TriggerOnAlerted;

	[Token(Token = "0x4001731")]
	[FieldOffset(Offset = "0x5C")]
	public bool TriggerOnAlarmRaised;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x5D")]
	public bool CheckOnEnter;

	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x60")]
	public MonitorMode Mode;

	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent AlertChanged;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent AlertLoweredDeath;

	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent AlertLoweredInvestigate;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5C1C", Offset = "0x5B5C1C")]
	public FsmInt NewAlertLevel;

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0xD5E168", Offset = "0xD5E168", VA = "0xD5E168", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0xD5E1DC", Offset = "0xD5E1DC", VA = "0xD5E1DC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0xD5E3A4", Offset = "0xD5E3A4", VA = "0xD5E3A4", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019B5")]
	[Address(RVA = "0xD5E34C", Offset = "0xD5E34C", VA = "0xD5E34C")]
	private bool TriggerOn(AlertLevel level)
	{
		return default(bool);
	}

	[Token(Token = "0x60019B6")]
	[Address(RVA = "0xD5E498", Offset = "0xD5E498", VA = "0xD5E498")]
	private void OnAlertLevelChanged(object sender, AISensorManager.AlertLevelChangedArgs args)
	{
	}

	[Token(Token = "0x60019B7")]
	[Address(RVA = "0xD5E5BC", Offset = "0xD5E5BC", VA = "0xD5E5BC")]
	public AlertLevelMonitor()
	{
	}
}
