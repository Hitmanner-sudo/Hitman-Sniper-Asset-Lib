using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000649")]
public class ContractAssignmentView : View
{
	[Token(Token = "0x200064A")]
	public class OnStarGainedArgs : EventArgs
	{
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x10")]
		public int StarAmount;

		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x14")]
		public bool BroadcastUnlockableObtainedMessage;

		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x8634C4", Offset = "0x8634C4", VA = "0x8634C4")]
		public OnStarGainedArgs()
		{
		}
	}

	[Token(Token = "0x200064B")]
	public class OnProgressFinishedArgs : EventArgs
	{
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x10")]
		public float FinalProgress;

		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x863410", Offset = "0x863410", VA = "0x863410")]
		public OnProgressFinishedArgs()
		{
		}
	}

	[Token(Token = "0x200064C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595738", Offset = "0x595738")]
	private sealed class _003CUpdateProgress_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x20")]
		public ContractAssignmentView _003C_003E4__this;

		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x28")]
		private float _003CtimeScale_003E5__2;

		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x30")]
		private ContinuousTimer _003Ctimer_003E5__3;

		[Token(Token = "0x1700054E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028C3")]
			[Address(RVA = "0x863474", Offset = "0x863474", VA = "0x863474", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028C5")]
			[Address(RVA = "0x8634BC", Offset = "0x8634BC", VA = "0x8634BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x862CF0", Offset = "0x862CF0", VA = "0x862CF0")]
		[DebuggerHidden]
		public _003CUpdateProgress_003Ed__56(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x862D1C", Offset = "0x862D1C", VA = "0x862D1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x862D20", Offset = "0x862D20", VA = "0x862D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x86347C", Offset = "0x86347C", VA = "0x86347C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40022AC")]
	[FieldOffset(Offset = "0x0")]
	public static EventHandler<OnStarGainedArgs> OnStarGained;

	[Token(Token = "0x40022AD")]
	[FieldOffset(Offset = "0x8")]
	public static EventHandler<OnProgressFinishedArgs> OnProgressFinished;

	[Token(Token = "0x40022AE")]
	[FieldOffset(Offset = "0x10")]
	public static EventHandler<EventArgs> OnAssignmentCompleted;

	[Token(Token = "0x40022AF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _goal1Label;

	[Token(Token = "0x40022B0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UILabel _goal2Label;

	[Token(Token = "0x40022B1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UILabel _goal3Label;

	[Token(Token = "0x40022B2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UILabel _restrictionLabel;

	[Token(Token = "0x40022B3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _missionSectionTitleLabel;

	[Token(Token = "0x40022B4")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UISprite _goal1Tick;

	[Token(Token = "0x40022B5")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UISprite _goal2Tick;

	[Token(Token = "0x40022B6")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UISprite _goal3Tick;

	[Token(Token = "0x40022B7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UISprite _restrictionTick;

	[Token(Token = "0x40022B8")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject _rewardsSection;

	[Token(Token = "0x40022B9")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UIAlignedList _missionObjectivesList;

	[Token(Token = "0x40022BA")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private bool _hideObjectivesWhenCompleted;

	[Token(Token = "0x40022BB")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UITexture _rogueTexture;

	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private bool _instantChange;

	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0xC9")]
	[SerializeField]
	private bool _alwaysShowProgress;

	[Token(Token = "0x40022BE")]
	[FieldOffset(Offset = "0xCA")]
	[SerializeField]
	private bool _canUpdateLastProgress;

	[Token(Token = "0x40022BF")]
	[FieldOffset(Offset = "0xCB")]
	[SerializeField]
	private bool _showTargetObjective;

	[Token(Token = "0x40022C0")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UIWidget _rewardHolder;

	[Token(Token = "0x40022C1")]
	[FieldOffset(Offset = "0xD8")]
	private bool _playingAnimations;

	[Token(Token = "0x40022C2")]
	[FieldOffset(Offset = "0xD9")]
	private bool _wantsNewAssignment;

	[Token(Token = "0x40022C3")]
	[FieldOffset(Offset = "0xDC")]
	private float _currentProgress;

	[Token(Token = "0x40022C4")]
	[FieldOffset(Offset = "0xE0")]
	private float _currentProgress2;

	[Token(Token = "0x40022C5")]
	[FieldOffset(Offset = "0xE4")]
	private bool _wantsUpdate;

	[Token(Token = "0x40022C6")]
	[FieldOffset(Offset = "0xE5")]
	private bool _isInGame;

	[Token(Token = "0x40022C7")]
	[FieldOffset(Offset = "0xE8")]
	private int _precalculatedWidth;

	[Token(Token = "0x40022C8")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject _rewardItem;

	[Token(Token = "0x40022C9")]
	private const float DURATION_PROGRESSION_ANIM = 0.3f;

	[Token(Token = "0x40022CA")]
	private const float DURATION_BEFORE_COMPLETED_TAG = 1.5f;

	[Token(Token = "0x40022CB")]
	private const float DURATION_COMPLETED_TAG = 0.5f;

	[Token(Token = "0x40022CC")]
	[FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8AAC", Offset = "0x5B8AAC")]
	private AssignmentData _003CAssignment_003Ek__BackingField;

	[Token(Token = "0x1700054B")]
	public UILabel MissionSectionTitleLabel
	{
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x8E34C8", Offset = "0x8E34C8", VA = "0x8E34C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054C")]
	public bool HasAnimations
	{
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x8E34D0", Offset = "0x8E34D0", VA = "0x8E34D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700054D")]
	public AssignmentData Assignment
	{
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x8E34F0", Offset = "0x8E34F0", VA = "0x8E34F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D888", Offset = "0x61D888")]
		get
		{
			return null;
		}
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x8E34F8", Offset = "0x8E34F8", VA = "0x8E34F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D898", Offset = "0x61D898")]
		private set
		{
		}
	}

	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x8E3500", Offset = "0x8E3500", VA = "0x8E3500", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x8E36F8", Offset = "0x8E36F8", VA = "0x8E36F8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x8E3F14", Offset = "0x8E3F14", VA = "0x8E3F14", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x8E4074", Offset = "0x8E4074", VA = "0x8E4074", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x8E38E0", Offset = "0x8E38E0", VA = "0x8E38E0")]
	private void OnAssignmentChanged(AssignmentData assignment)
	{
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x8E419C", Offset = "0x8E419C", VA = "0x8E419C")]
	private void SetRogueInfo(MissionData mission)
	{
	}

	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x8E4CA4", Offset = "0x8E4CA4", VA = "0x8E4CA4")]
	private void UpdateGoalText(bool isInGame)
	{
	}

	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x8E5864", Offset = "0x8E5864", VA = "0x8E5864")]
	private void UpdateAllTickBoxColor()
	{
	}

	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x8E58AC", Offset = "0x8E58AC", VA = "0x8E58AC")]
	private void UpdateTickBoxColor(UISprite tickSprite, UILabel label)
	{
	}

	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x8E4D80", Offset = "0x8E4D80", VA = "0x8E4D80")]
	private void SetGoal1(bool isInGame)
	{
	}

	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x8E503C", Offset = "0x8E503C", VA = "0x8E503C")]
	private void SetGoal2(bool isInGame)
	{
	}

	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x8E5398", Offset = "0x8E5398", VA = "0x8E5398")]
	private void SetGoal3(bool isInGame)
	{
	}

	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x8E5638", Offset = "0x8E5638", VA = "0x8E5638")]
	private void SetRestriction(bool isInGame)
	{
	}

	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x8E5AC8", Offset = "0x8E5AC8", VA = "0x8E5AC8")]
	public void PlayAnimations()
	{
	}

	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x8E3EA8", Offset = "0x8E3EA8", VA = "0x8E3EA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D8A8", Offset = "0x61D8A8")]
	private IEnumerator UpdateProgress()
	{
		return null;
	}

	[Token(Token = "0x60028B8")]
	[Address(RVA = "0x8E5B30", Offset = "0x8E5B30", VA = "0x8E5B30")]
	public static void RaiseStarGained(int starReward, bool broadcastUnlockableObtainedMessage = true)
	{
	}

	[Token(Token = "0x60028B9")]
	[Address(RVA = "0x8E5BEC", Offset = "0x8E5BEC", VA = "0x8E5BEC")]
	private void PlayScheduledAnimations(bool forceRefresh = false)
	{
	}

	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x8E4490", Offset = "0x8E4490", VA = "0x8E4490")]
	private void UpdateTick()
	{
	}

	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x8E4940", Offset = "0x8E4940", VA = "0x8E4940")]
	private void DisplayRewards(MissionData mission)
	{
	}

	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x8E5CB0", Offset = "0x8E5CB0", VA = "0x8E5CB0")]
	private void OnLanguageChanged(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x8E5CFC", Offset = "0x8E5CFC", VA = "0x8E5CFC")]
	public ContractAssignmentView()
	{
	}
}
