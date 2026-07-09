using System;
using Il2CppDummyDll;

[Token(Token = "0x200015B")]
public class TaskCallFromCover : AITask
{
	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59266C", Offset = "0x59266C")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x10")]
		public AIMemento m;

		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<AIMemento> _003C_003E9__0;

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xA55680", Offset = "0xA55680", VA = "0xA55680")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xA55688", Offset = "0xA55688", VA = "0xA55688")]
		internal bool _003CExecute_003Eb__0(AIMemento x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x28")]
	private AnimationConfig.IdleOptions _callInOptions;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x30")]
	private float _callInBreakerIndex;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x34")]
	private float _breakerTime;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x38")]
	private GameTimer _callInTimer;

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x40")]
	private bool _parametersSet;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x41")]
	private bool _mementoAdded;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x48")]
	private string _radioIcon;

	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x50")]
	private bool _isCommunicating;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x58")]
	public AIMemento MementoToBeReported;

	[Token(Token = "0x600093F")]
	[Address(RVA = "0xB55284", Offset = "0xB55284", VA = "0xB55284")]
	public TaskCallFromCover()
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0xB554AC", Offset = "0xB554AC", VA = "0xB554AC", Slot = "7")]
	public override ExecutionStatus Execute()
	{
		return default(ExecutionStatus);
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0xB55948", Offset = "0xB55948", VA = "0xB55948", Slot = "5")]
	public override void Start(AIController newAI)
	{
	}

	[Token(Token = "0x6000942")]
	[Address(RVA = "0xB55988", Offset = "0xB55988", VA = "0xB55988", Slot = "6")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0xB55DEC", Offset = "0xB55DEC", VA = "0xB55DEC")]
	private void OnCommunicationsJammed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0xB55EC4", Offset = "0xB55EC4", VA = "0xB55EC4")]
	private void OnCommunicationsUnjammed(object sender, EventArgs args)
	{
	}
}
