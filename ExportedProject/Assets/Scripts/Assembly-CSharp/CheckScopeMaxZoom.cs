using HutongGames.PlayMaker;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200043B")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593E30", Offset = "0x593E30")]
public class CheckScopeMaxZoom : FsmStateAction
{
	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent _AlreadyAtMaxZoomEvent;

	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent _OnMaxZoomEvent;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent _AlreadyAtMinZoomEvent;

	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent _OnMinZoomEvent;

	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5D74", Offset = "0x5B5D74")]
	public Range Range;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5DAC", Offset = "0x5B5DAC")]
	public FsmFloat MinRangeVar;

	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5DC0", Offset = "0x5B5DC0")]
	public FsmFloat MaxRangeVar;

	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x88")]
	public FsmEvent ZoomInsideRange;

	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0x90")]
	public FsmEvent ZoomTooLow;

	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0x98")]
	public FsmEvent ZoomTooHigh;

	[Token(Token = "0x1700041D")]
	public float MinRange
	{
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0xAFF474", Offset = "0xAFF474", VA = "0xAFF474")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700041E")]
	public float MaxRange
	{
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0xAFF4E0", Offset = "0xAFF4E0", VA = "0xAFF4E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0xAFF54C", Offset = "0xAFF54C", VA = "0xAFF54C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0xAFF558", Offset = "0xAFF558", VA = "0xAFF558", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019E6")]
	[Address(RVA = "0xAFF7E4", Offset = "0xAFF7E4", VA = "0xAFF7E4")]
	private void OnZoom(object sender, PlayerScopeSystem.ZoomEvent e)
	{
	}

	[Token(Token = "0x60019E7")]
	[Address(RVA = "0xAFF770", Offset = "0xAFF770", VA = "0xAFF770")]
	private void RaiseRangeEvents(float zoomLevel)
	{
	}

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0xAFF868", Offset = "0xAFF868", VA = "0xAFF868", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0xAFF8F8", Offset = "0xAFF8F8", VA = "0xAFF8F8")]
	public CheckScopeMaxZoom()
	{
	}
}
