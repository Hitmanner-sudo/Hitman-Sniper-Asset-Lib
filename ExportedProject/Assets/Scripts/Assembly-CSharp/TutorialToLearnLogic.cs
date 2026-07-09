using Il2CppDummyDll;

[Token(Token = "0x20002DA")]
public class TutorialToLearnLogic
{
	[Token(Token = "0x20002DB")]
	public enum State
	{
		[Token(Token = "0x4000FD7")]
		NotValid = 0,
		[Token(Token = "0x4000FD8")]
		WaitingTimer = 1,
		[Token(Token = "0x4000FD9")]
		InProgress = 2,
		[Token(Token = "0x4000FDA")]
		Completed = 3
	}

	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x10")]
	protected TutorialToLearnData _data;

	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x18")]
	private State _state;

	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x20")]
	private GameTimer _waitingTimer;

	[Token(Token = "0x600118A")]
	[Address(RVA = "0xC9F9B4", Offset = "0xC9F9B4", VA = "0xC9F9B4")]
	public TutorialToLearnLogic(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0xCAAFA0", Offset = "0xCAAFA0", VA = "0xCAAFA0", Slot = "4")]
	public virtual bool IsInProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0xC9FBE8", Offset = "0xC9FBE8", VA = "0xC9FBE8", Slot = "5")]
	public virtual bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600118D")]
	[Address(RVA = "0xCAAFB0", Offset = "0xCAAFB0", VA = "0xCAAFB0", Slot = "6")]
	public virtual bool CanUseAction()
	{
		return default(bool);
	}

	[Token(Token = "0x600118E")]
	[Address(RVA = "0xCAAD28", Offset = "0xCAAD28", VA = "0xCAAD28")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0xCAAEC4", Offset = "0xCAAEC4", VA = "0xCAAEC4")]
	public bool CheckCompletion()
	{
		return default(bool);
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0xC9FB00", Offset = "0xC9FB00", VA = "0xC9FB00", Slot = "7")]
	protected virtual bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0xCAB10C", Offset = "0xCAB10C", VA = "0xCAB10C", Slot = "8")]
	protected virtual void DoStart()
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0xCAB110", Offset = "0xCAB110", VA = "0xCAB110", Slot = "9")]
	protected virtual void DoUpdate()
	{
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0xCAB114", Offset = "0xCAB114", VA = "0xCAB114", Slot = "10")]
	protected virtual void DoStop()
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0xCAB118", Offset = "0xCAB118", VA = "0xCAB118", Slot = "11")]
	protected virtual void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0xCAB01C", Offset = "0xCAB01C", VA = "0xCAB01C")]
	private bool IsCurrentContractAndMissionValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0xCAAF58", Offset = "0xCAAF58", VA = "0xCAAF58")]
	public void ForceCompletedTo(bool completed)
	{
	}
}
