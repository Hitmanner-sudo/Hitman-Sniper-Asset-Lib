using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200026D")]
public class RewardActionBase
{
	[Token(Token = "0x200026E")]
	public class RewardCompletedEvent : EventArgs
	{
		[Token(Token = "0x4000D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RewardActionBase Reward;

		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x8B465C", Offset = "0x8B465C", VA = "0x8B465C")]
		public RewardCompletedEvent()
		{
		}
	}

	[Token(Token = "0x200026F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E7C", Offset = "0x592E7C")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x4000D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string reward;

		[Token(Token = "0x4000D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<RewardActionBase> _003C_003E9__0;

		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x8B4628", Offset = "0x8B4628", VA = "0x8B4628")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x8B4630", Offset = "0x8B4630", VA = "0x8B4630")]
		internal bool _003CInitSuppressIfBitfield_003Eb__0(RewardActionBase x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4000D7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Enabled;

	[Token(Token = "0x4000D7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Counter;

	[Token(Token = "0x4000D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool ShouldAffectTallyCount;

	[Token(Token = "0x4000D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Reward ActionReward;

	[Token(Token = "0x4000D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool ResetAfterComplete;

	[Token(Token = "0x4000D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool ResetProgressOnInvalidKills;

	[Token(Token = "0x4000D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool ResetProgressOnShotMiss;

	[Token(Token = "0x4000D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B37D4", Offset = "0x5B37D4")]
	private int _003CProgressCounter_003Ek__BackingField;

	[Token(Token = "0x4000D86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ScoreTallyView.TallyItem[] Tally;

	[Token(Token = "0x4000D87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] SuppressIf;

	[Token(Token = "0x4000D88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public int DisplayIndex;

	[Token(Token = "0x4000D89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int INVALID_DISPLAY_ID;

	[Token(Token = "0x4000D8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<RewardActionBase> RewardActionList;

	[NonSerialized]
	[Token(Token = "0x4000D8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BitArray SuppressIfBitfield;

	[Token(Token = "0x1700024F")]
	public int ProgressCounter
	{
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x968FE4", Offset = "0x968FE4", VA = "0x968FE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615184", Offset = "0x615184")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x968FEC", Offset = "0x968FEC", VA = "0x968FEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615194", Offset = "0x615194")]
		private set
		{
		}
	}

	[Token(Token = "0x17000250")]
	public bool Completed
	{
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x968FF4", Offset = "0x968FF4", VA = "0x968FF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000251")]
	public bool HasReward
	{
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x969018", Offset = "0x969018", VA = "0x969018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000252")]
	public bool HasCurrency
	{
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x969058", Offset = "0x969058", VA = "0x969058")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000253")]
	public bool IsScaredKill
	{
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x969098", Offset = "0x969098", VA = "0x969098")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000254")]
	public virtual string DebugInfo
	{
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x9696EC", Offset = "0x9696EC", VA = "0x9696EC", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000038")]
	public event EventHandler<RewardCompletedEvent> OnComplete
	{
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x9690B4", Offset = "0x9690B4", VA = "0x9690B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151A4", Offset = "0x6151A4")]
		add
		{
		}
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x969154", Offset = "0x969154", VA = "0x969154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151B4", Offset = "0x6151B4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000039")]
	public event EventHandler<RewardCompletedEvent> OnProgress
	{
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x9691F4", Offset = "0x9691F4", VA = "0x9691F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151C4", Offset = "0x6151C4")]
		add
		{
		}
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x969294", Offset = "0x969294", VA = "0x969294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151D4", Offset = "0x6151D4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x969334", Offset = "0x969334", VA = "0x969334", Slot = "4")]
	public virtual void OnGameStarted()
	{
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x969474", Offset = "0x969474", VA = "0x969474", Slot = "5")]
	public virtual void OnGameEnded()
	{
	}

	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x969500", Offset = "0x969500", VA = "0x969500")]
	protected bool Progress([Optional] RogueData rogueDataObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x9695CC", Offset = "0x9695CC", VA = "0x9695CC")]
	protected void Complete([Optional] RogueData rogueDataObject)
	{
	}

	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x9693DC", Offset = "0x9693DC", VA = "0x9693DC")]
	protected void Reset()
	{
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x9697A0", Offset = "0x9697A0", VA = "0x9697A0")]
	public void InitSuppressIfBitfield(List<RewardActionBase> actions)
	{
	}

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x969A88", Offset = "0x969A88", VA = "0x969A88")]
	public RewardActionBase()
	{
	}
}
