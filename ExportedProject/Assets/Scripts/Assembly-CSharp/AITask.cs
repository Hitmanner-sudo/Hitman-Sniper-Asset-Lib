using System;
using Il2CppDummyDll;

[Token(Token = "0x2000159")]
public abstract class AITask
{
	[Token(Token = "0x200015A")]
	[Flags]
	public enum TaskChannels
	{
		[Token(Token = "0x4000736")]
		None = 0,
		[Token(Token = "0x4000737")]
		Movement = 1,
		[Token(Token = "0x4000738")]
		UpperBody = 2
	}

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x10")]
	public string ID;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B09E4", Offset = "0x5B09E4")]
	private AIController _003CAI_003Ek__BackingField;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x20")]
	public bool IsExecuting;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x21")]
	private bool _paused;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B09F4", Offset = "0x5B09F4")]
	private TaskChannels _003CChannels_003Ek__BackingField;

	[Token(Token = "0x1700017B")]
	public AIController AI
	{
		[Token(Token = "0x6000932")]
		[Address(RVA = "0xA98C9C", Offset = "0xA98C9C", VA = "0xA98C9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612BD8", Offset = "0x612BD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000933")]
		[Address(RVA = "0xA98CA4", Offset = "0xA98CA4", VA = "0xA98CA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612BE8", Offset = "0x612BE8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700017C")]
	public bool IsPaused
	{
		[Token(Token = "0x6000935")]
		[Address(RVA = "0xA98CB8", Offset = "0xA98CB8", VA = "0xA98CB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700017D")]
	public TaskChannels Channels
	{
		[Token(Token = "0x6000936")]
		[Address(RVA = "0xA98CC0", Offset = "0xA98CC0", VA = "0xA98CC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612BF8", Offset = "0x612BF8")]
		get
		{
			return default(TaskChannels);
		}
		[Token(Token = "0x6000937")]
		[Address(RVA = "0xA98CC8", Offset = "0xA98CC8", VA = "0xA98CC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C08", Offset = "0x612C08")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000934")]
	[Address(RVA = "0xA98CAC", Offset = "0xA98CAC", VA = "0xA98CAC", Slot = "4")]
	public virtual void Paused(bool paused)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0xA98CD0", Offset = "0xA98CD0", VA = "0xA98CD0", Slot = "5")]
	public virtual void Start(AIController newAI)
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0xA98CE0", Offset = "0xA98CE0", VA = "0xA98CE0", Slot = "6")]
	public virtual void Stop()
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0xA98CE8", Offset = "0xA98CE8", VA = "0xA98CE8")]
	public bool IsBlocked(TaskChannels blockedChannels)
	{
		return default(bool);
	}

	[Token(Token = "0x600093B")]
	public abstract ExecutionStatus Execute();

	[Token(Token = "0x600093C")]
	[Address(RVA = "0xA98CF8", Offset = "0xA98CF8", VA = "0xA98CF8", Slot = "8")]
	public virtual void DisplaySelected()
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0xA98CFC", Offset = "0xA98CFC", VA = "0xA98CFC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0xA98D74", Offset = "0xA98D74", VA = "0xA98D74")]
	protected AITask()
	{
	}
}
