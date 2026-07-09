using System;
using Il2CppDummyDll;

[Token(Token = "0x20000E6")]
public class CommunicateBehaviour : AIBehaviour, TaskIdle.IListener
{
	[Token(Token = "0x20000E7")]
	public class RadioCommunicateArgs : EventArgs
	{
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x10")]
		public AIController AI;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x862818", Offset = "0x862818", VA = "0x862818")]
		public RadioCommunicateArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592418", Offset = "0x592418")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AIMemento> _003C_003E9__33_0;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x8627F4", Offset = "0x8627F4", VA = "0x8627F4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x8627FC", Offset = "0x8627FC", VA = "0x8627FC")]
		internal void _003CCommunicate_003Eb__33_0(AIMemento m)
		{
		}
	}

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x38")]
	public AIMemento Memento;

	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x40")]
	private SuspiciousActivityReport _mementoToShare;

	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x0")]
	public static float JamTime;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly GameTimer JamTimer;

	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string JammedIcon;

	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x48")]
	public Memory CommunicateTarget;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x50")]
	public float TargetDistanceSqr;

	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x58")]
	private TaskIdle _task;

	[Token(Token = "0x4000533")]
	private const string TASK_ID = "CommunicateTask";

	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x60")]
	private ThirdPersonCharacter _communicationCharacter;

	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0x68")]
	private float _refreshTargetFrequency;

	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x70")]
	private readonly GameTimer _refreshTargetTimer;

	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x78")]
	private float _defaultReachRadius;

	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x80")]
	private readonly GameTimer _communicateTimer;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x88")]
	private bool _destinationReached;

	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x89")]
	private bool _isCommunicating;

	[Token(Token = "0x17000134")]
	public static bool CommunicationsJammed
	{
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x8DBE28", Offset = "0x8DBE28", VA = "0x8DBE28")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x8DBEF0", Offset = "0x8DBEF0", VA = "0x8DBEF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000135")]
	private new CommunicateEvaluator Evaluator
	{
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x8DC3F0", Offset = "0x8DC3F0", VA = "0x8DC3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400000D")]
	public static event EventHandler OnCommunicationsJammed
	{
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x8DC010", Offset = "0x8DC010", VA = "0x8DC010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612210", Offset = "0x612210")]
		add
		{
		}
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x8DC108", Offset = "0x8DC108", VA = "0x8DC108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612220", Offset = "0x612220")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event EventHandler OnCommunicationsUnjammed
	{
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x8DC200", Offset = "0x8DC200", VA = "0x8DC200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612230", Offset = "0x612230")]
		add
		{
		}
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x8DC2F8", Offset = "0x8DC2F8", VA = "0x8DC2F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612240", Offset = "0x612240")]
		remove
		{
		}
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x8DC46C", Offset = "0x8DC46C", VA = "0x8DC46C", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x8DCBC0", Offset = "0x8DCBC0", VA = "0x8DCBC0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x8DD2C4", Offset = "0x8DD2C4", VA = "0x8DD2C4", Slot = "13")]
	private void TaskIdle_002EIListener_002EOnDestinationReached()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x8DD460", Offset = "0x8DD460", VA = "0x8DD460", Slot = "14")]
	private void TaskIdle_002EIListener_002EOnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x8DD628", Offset = "0x8DD628", VA = "0x8DD628", Slot = "15")]
	private void TaskIdle_002EIListener_002EOnIdleComplete()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x8DCEEC", Offset = "0x8DCEEC", VA = "0x8DCEEC")]
	private void Communicate()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x8DD6A0", Offset = "0x8DD6A0", VA = "0x8DD6A0", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x8DDA2C", Offset = "0x8DDA2C", VA = "0x8DDA2C")]
	private void OnJammed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x8DDAE8", Offset = "0x8DDAE8", VA = "0x8DDAE8")]
	private void OnUnjammed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x8DDB34", Offset = "0x8DDB34", VA = "0x8DDB34", Slot = "12")]
	public override void OnMementoInvestigated(AIMemento memento)
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x8DDB54", Offset = "0x8DDB54", VA = "0x8DDB54")]
	private void CommunicateTargetHealthTakeDamage(object sender, Health.TakeDamageEventArgs e)
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x8DDC50", Offset = "0x8DDC50", VA = "0x8DDC50", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x8DCA68", Offset = "0x8DCA68", VA = "0x8DCA68")]
	private void PlayBark()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x8DC984", Offset = "0x8DC984", VA = "0x8DC984")]
	private bool CommunicateToEveryone()
	{
		return default(bool);
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x8DDD00", Offset = "0x8DDD00", VA = "0x8DDD00")]
	public CommunicateBehaviour()
	{
	}
}
