using HutongGames.PlayMaker;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200043C")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593E68", Offset = "0x593E68")]
public class CheckZoomMonitor : FsmStateAction
{
	[Token(Token = "0x200043D")]
	public enum ZoomStateFilter
	{
		[Token(Token = "0x400176C")]
		None = 0,
		[Token(Token = "0x400176D")]
		Min = 1,
		[Token(Token = "0x400176E")]
		Max = 2
	}

	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5DD4", Offset = "0x5B5DD4")]
	public Range Range;

	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5E0C", Offset = "0x5B5E0C")]
	public FsmFloat MinRangeVar;

	[Token(Token = "0x4001764")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5E20", Offset = "0x5B5E20")]
	public FsmFloat MaxRangeVar;

	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0x68")]
	public ZoomStateFilter StateFilter;

	[Token(Token = "0x4001766")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent MetEvent;

	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent NotMetEvent;

	[Token(Token = "0x4001768")]
	[FieldOffset(Offset = "0x80")]
	private bool _isChecking;

	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0x81")]
	private bool _isInRange;

	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0x82")]
	private bool _satisfyFilter;

	[Token(Token = "0x1700041F")]
	public float MinRange
	{
		[Token(Token = "0x60019EA")]
		[Address(RVA = "0xAFFC8C", Offset = "0xAFFC8C", VA = "0xAFFC8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000420")]
	public float MaxRange
	{
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0xAFFCF8", Offset = "0xAFFCF8", VA = "0xAFFCF8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0xAFFD64", Offset = "0xAFFD64", VA = "0xAFFD64", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0xAFFD70", Offset = "0xAFFD70", VA = "0xAFFD70", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019EE")]
	[Address(RVA = "0xAFFFC0", Offset = "0xAFFFC0", VA = "0xAFFFC0", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60019EF")]
	[Address(RVA = "0xB000DC", Offset = "0xB000DC", VA = "0xB000DC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0xB0016C", Offset = "0xB0016C", VA = "0xB0016C")]
	private void OnZoom(object sender, PlayerScopeSystem.ZoomEvent e)
	{
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0xAFFF10", Offset = "0xAFFF10", VA = "0xAFFF10")]
	private void UpdateStatus(float currentZoom, float minZoom, float maxZoom)
	{
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0xB00188", Offset = "0xB00188", VA = "0xB00188")]
	public CheckZoomMonitor()
	{
	}
}
