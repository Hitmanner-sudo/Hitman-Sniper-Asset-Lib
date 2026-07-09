using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000647")]
public class ChallengesView : MainMenuPageView
{
	[Token(Token = "0x2000648")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595728", Offset = "0x595728")]
	private sealed class _003CUpdateVisual_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x20")]
		public ChallengesView _003C_003E4__this;

		[Token(Token = "0x17000549")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028A2")]
			[Address(RVA = "0x8616C0", Offset = "0x8616C0", VA = "0x8616C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x861708", Offset = "0x861708", VA = "0x861708", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600289F")]
		[Address(RVA = "0x861624", Offset = "0x861624", VA = "0x861624")]
		[DebuggerHidden]
		public _003CUpdateVisual_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x861650", Offset = "0x861650", VA = "0x861650", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x861654", Offset = "0x861654", VA = "0x861654", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x8616C8", Offset = "0x8616C8", VA = "0x8616C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400229A")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _challengePrefab;

	[Token(Token = "0x400229B")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject _challengesParent;

	[Token(Token = "0x400229C")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject _leaderboardPrefab;

	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject _leaderboardParent;

	[Token(Token = "0x400229E")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Transform _challengesUIDraggablePanelTransform;

	[Token(Token = "0x400229F")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UIDraggablePanel _challengesUIDraggablePanel;

	[Token(Token = "0x40022A0")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private SpringPanel _challengesSpringPanel;

	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UIGrid _challengesUIGrid;

	[Token(Token = "0x40022A2")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UICenterOnChild _challengesUICenterOnChild;

	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private DailyRewardButtonView _dailyRewardButtonView;

	[Token(Token = "0x40022A4")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject _leaderboardGO;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0xF0")]
	private readonly List<ChallengeView> _challengeViews;

	[Token(Token = "0x40022A6")]
	[FieldOffset(Offset = "0xF8")]
	private bool _centerOnPreviousChallengeDone;

	[Token(Token = "0x40022A7")]
	[FieldOffset(Offset = "0xFC")]
	private int _selectedChallengeContractIndex;

	[Token(Token = "0x40022A8")]
	[FieldOffset(Offset = "0x100")]
	private CheckInboxItems _checkInboxItems;

	[Token(Token = "0x6002892")]
	[Address(RVA = "0xAF7870", Offset = "0xAF7870", VA = "0xAF7870", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0xAF7F18", Offset = "0xAF7F18", VA = "0xAF7F18", Slot = "16")]
	public override void LoadView()
	{
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0xAF80CC", Offset = "0xAF80CC", VA = "0xAF80CC", Slot = "15")]
	protected override void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0xAF8214", Offset = "0xAF8214", VA = "0xAF8214")]
	private void CheckForMessages()
	{
	}

	[Token(Token = "0x6002896")]
	[Address(RVA = "0xAF79DC", Offset = "0xAF79DC", VA = "0xAF79DC")]
	private void CreateChallenges()
	{
	}

	[Token(Token = "0x6002897")]
	[Address(RVA = "0xAF7DF8", Offset = "0xAF7DF8", VA = "0xAF7DF8")]
	private void CreateLeaderboard()
	{
	}

	[Token(Token = "0x6002898")]
	[Address(RVA = "0xAF83E0", Offset = "0xAF83E0", VA = "0xAF83E0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002899")]
	[Address(RVA = "0xAF8628", Offset = "0xAF8628", VA = "0xAF8628")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D7D8", Offset = "0x61D7D8")]
	private IEnumerator UpdateVisual()
	{
		return null;
	}

	[Token(Token = "0x600289A")]
	[Address(RVA = "0xAF8694", Offset = "0xAF8694", VA = "0xAF8694", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0xAF8894", Offset = "0xAF8894", VA = "0xAF8894")]
	private void OnCenteredOnChildFinished()
	{
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0xAF8898", Offset = "0xAF8898", VA = "0xAF8898")]
	private void RefreshLeaderboard()
	{
	}

	[Token(Token = "0x600289D")]
	[Address(RVA = "0xAF8A10", Offset = "0xAF8A10", VA = "0xAF8A10")]
	private void CenterOnPreviousChallenge()
	{
	}

	[Token(Token = "0x600289E")]
	[Address(RVA = "0xAF8BBC", Offset = "0xAF8BBC", VA = "0xAF8BBC")]
	public ChallengesView()
	{
	}
}
