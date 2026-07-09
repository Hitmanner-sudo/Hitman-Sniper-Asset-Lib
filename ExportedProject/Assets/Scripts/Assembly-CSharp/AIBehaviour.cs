using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000DC")]
public class AIBehaviour
{
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x10")]
	protected AIController m_AI;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B05F4", Offset = "0x5B05F4")]
	private BehaviourEvaluator _003CEvaluator_003Ek__BackingField;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x20")]
	public string Icon;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x28")]
	public bool ShowProgress;

	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x2C")]
	public float CurrentProgress;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x30")]
	public float TotalProgress;

	[Token(Token = "0x17000133")]
	public BehaviourEvaluator Evaluator
	{
		[Token(Token = "0x6000679")]
		[Address(RVA = "0xA91BC0", Offset = "0xA91BC0", VA = "0xA91BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121F0", Offset = "0x6121F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA91BC8", Offset = "0xA91BC8", VA = "0xA91BC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612200", Offset = "0x612200")]
		set
		{
		}
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xA91BD0", Offset = "0xA91BD0", VA = "0xA91BD0", Slot = "4")]
	public virtual bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xA91BD4", Offset = "0xA91BD4", VA = "0xA91BD4")]
	public bool IsSameType(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xA91C84", Offset = "0xA91C84", VA = "0xA91C84", Slot = "5")]
	public virtual void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xA91C8C", Offset = "0xA91C8C", VA = "0xA91C8C", Slot = "6")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xA91CEC", Offset = "0xA91CEC", VA = "0xA91CEC", Slot = "7")]
	public virtual bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xA91CF4", Offset = "0xA91CF4", VA = "0xA91CF4", Slot = "8")]
	public virtual bool HasIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xA91DA0", Offset = "0xA91DA0", VA = "0xA91DA0", Slot = "9")]
	public virtual void SetupTagIndicator(object sender, IndicatorView.SetupIndicatorEventArgs args)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xA920C8", Offset = "0xA920C8", VA = "0xA920C8", Slot = "10")]
	public virtual Vector3 GetEvaluationDisplayPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0xA920D8", Offset = "0xA920D8", VA = "0xA920D8", Slot = "11")]
	public virtual void OnTaskCompleted(AITask task, ExecutionStatus status)
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xA920DC", Offset = "0xA920DC", VA = "0xA920DC")]
	public AIBehaviour Instantiate()
	{
		return null;
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xA92164", Offset = "0xA92164", VA = "0xA92164", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xA9216C", Offset = "0xA9216C", VA = "0xA9216C", Slot = "12")]
	public virtual void OnMementoInvestigated(AIMemento memento)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0xA92170", Offset = "0xA92170", VA = "0xA92170")]
	public AIBehaviour()
	{
	}
}
