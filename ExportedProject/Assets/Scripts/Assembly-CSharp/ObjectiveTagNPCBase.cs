using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000264")]
public class ObjectiveTagNPCBase : ObjectiveTagBase
{
	[Token(Token = "0x2000265")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E3C", Offset = "0x592E3C")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x10")]
		public AISensorManager.AlertLevelChangedArgs alertLevelChangedArgs;

		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x8CDB94", Offset = "0x8CDB94", VA = "0x8CDB94")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x8CDB9C", Offset = "0x8CDB9C", VA = "0x8CDB9C")]
		internal bool _003COnAlertChanged_003Eb__0(AIController r)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000266")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E4C", Offset = "0x592E4C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AIController> _003C_003E9__17_0;

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x8CDB24", Offset = "0x8CDB24", VA = "0x8CDB24")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x8CDB2C", Offset = "0x8CDB2C", VA = "0x8CDB2C")]
		internal bool _003CRefreshNPCRegistered_003Eb__17_0(AIController r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000267")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E5C", Offset = "0x592E5C")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x10")]
		public Health health;

		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x8CDC28", Offset = "0x8CDC28", VA = "0x8CDC28")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x8CDC30", Offset = "0x8CDC30", VA = "0x8CDC30")]
		internal bool _003COnCharacterDied_003Eb__0(AIController r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E6C", Offset = "0x592E6C")]
	private sealed class _003CUnregisterAfterDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x28")]
		public ObjectiveTagNPCBase _003C_003E4__this;

		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x30")]
		private float _003CendTime_003E5__2;

		[Token(Token = "0x17000247")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x8CDEF4", Offset = "0x8CDEF4", VA = "0x8CDEF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000248")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x8CDF3C", Offset = "0x8CDF3C", VA = "0x8CDF3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x8CDD2C", Offset = "0x8CDD2C", VA = "0x8CDD2C")]
		[DebuggerHidden]
		public _003CUnregisterAfterDelay_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x8CDD58", Offset = "0x8CDD58", VA = "0x8CDD58", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x8CDD5C", Offset = "0x8CDD5C", VA = "0x8CDD5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x8CDEFC", Offset = "0x8CDEFC", VA = "0x8CDEFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x80")]
	public AlertLevel MaxAlertLevel;

	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x84")]
	public float ActiveTime;

	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x88")]
	protected List<AIController> _validNPCList;

	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x90")]
	private bool _isNPCListDirty;

	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x9EC4C4", Offset = "0x9EC4C4", VA = "0x9EC4C4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x9EC5F8", Offset = "0x9EC5F8", VA = "0x9EC5F8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x9EC768", Offset = "0x9EC768", VA = "0x9EC768")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x9EC930", Offset = "0x9EC930", VA = "0x9EC930", Slot = "15")]
	protected override void ObjectiveTagDie()
	{
	}

	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x9ECA84", Offset = "0x9ECA84", VA = "0x9ECA84", Slot = "17")]
	protected virtual bool CanAssignNPC(AIController controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x9ECB78", Offset = "0x9ECB78", VA = "0x9ECB78")]
	protected void AssignNPC(AIController controller)
	{
	}

	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x9EC954", Offset = "0x9EC954", VA = "0x9EC954")]
	protected void UnassignNPC()
	{
	}

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x9ECCAC", Offset = "0x9ECCAC", VA = "0x9ECCAC")]
	protected void AddToNPCList(AIController controller)
	{
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x9ECD3C", Offset = "0x9ECD3C", VA = "0x9ECD3C")]
	protected void RemoveFromNPCList(AIController controller)
	{
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x9ECDAC", Offset = "0x9ECDAC", VA = "0x9ECDAC")]
	private void OnAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs alertLevelChangedArgs)
	{
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x9ECF30", Offset = "0x9ECF30", VA = "0x9ECF30", Slot = "18")]
	protected virtual bool HaveHPNeeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x9ECFC4", Offset = "0x9ECFC4", VA = "0x9ECFC4", Slot = "19")]
	protected virtual bool ShouldRegisterNPC()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x9ECD30", Offset = "0x9ECD30", VA = "0x9ECD30")]
	protected void SetNPCListDirty()
	{
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x9EC76C", Offset = "0x9EC76C", VA = "0x9EC76C")]
	private void RefreshNPCRegistered()
	{
	}

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x9ED038", Offset = "0x9ED038", VA = "0x9ED038", Slot = "14")]
	protected override void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x9ED060", Offset = "0x9ED060", VA = "0x9ED060")]
	private void OnCharacterDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x9ED1C8", Offset = "0x9ED1C8", VA = "0x9ED1C8", Slot = "16")]
	protected override void DoActivate()
	{
	}

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x9ED214", Offset = "0x9ED214", VA = "0x9ED214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615074", Offset = "0x615074")]
	private IEnumerator UnregisterAfterDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x9EB678", Offset = "0x9EB678", VA = "0x9EB678")]
	public ObjectiveTagNPCBase()
	{
	}
}
