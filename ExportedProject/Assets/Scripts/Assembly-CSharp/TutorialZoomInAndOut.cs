using Il2CppDummyDll;

[Token(Token = "0x20002DC")]
public class TutorialZoomInAndOut : TutorialToLearnLogic
{
	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x28")]
	private float _zoomAmountToComplete;

	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x2C")]
	private float _lastZoomValue;

	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x30")]
	private float _zoomAmountAccumulated;

	[Token(Token = "0x6001197")]
	[Address(RVA = "0xCAAF20", Offset = "0xCAAF20", VA = "0xCAAF20")]
	public TutorialZoomInAndOut(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0xCAB11C", Offset = "0xCAB11C", VA = "0xCAB11C", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0xCAB23C", Offset = "0xCAB23C", VA = "0xCAB23C", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0xCAB2E0", Offset = "0xCAB2E0", VA = "0xCAB2E0", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x600119B")]
	[Address(RVA = "0xCAB49C", Offset = "0xCAB49C", VA = "0xCAB49C", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x600119C")]
	[Address(RVA = "0xCAB5DC", Offset = "0xCAB5DC", VA = "0xCAB5DC", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x600119D")]
	[Address(RVA = "0xCAB690", Offset = "0xCAB690", VA = "0xCAB690")]
	private void OnZoom(object sender, PlayerScopeSystem.ZoomEvent e)
	{
	}
}
