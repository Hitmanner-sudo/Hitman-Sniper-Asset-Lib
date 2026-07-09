using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000B8")]
[Scope]
public class VoiceManager : GameSingleton<VoiceManager>
{
	[Token(Token = "0x20000B9")]
	public class PlayingBark
	{
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x10")]
		public int Priority;

		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x18")]
		public PlayingSoundContainer PlayingContainer;

		[Token(Token = "0x17000116")]
		public bool IsFinished
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xA4105C", Offset = "0xA4105C", VA = "0xA4105C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public float TotalLength
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xA41078", Offset = "0xA41078", VA = "0xA41078")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA41080", Offset = "0xA41080", VA = "0xA41080")]
		public PlayingBark()
		{
		}
	}

	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5922F0", Offset = "0x5922F0")]
	private sealed class _003CChangeVolume_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x24")]
		public bool up;

		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x28")]
		public VoiceManager _003C_003E4__this;

		[Token(Token = "0x17000118")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xA40DF8", Offset = "0xA40DF8", VA = "0xA40DF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xA40E40", Offset = "0xA40E40", VA = "0xA40E40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA40AB0", Offset = "0xA40AB0", VA = "0xA40AB0")]
		[DebuggerHidden]
		public _003CChangeVolume_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA40ADC", Offset = "0xA40ADC", VA = "0xA40ADC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA40AE0", Offset = "0xA40AE0", VA = "0xA40AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA40E00", Offset = "0xA40E00", VA = "0xA40E00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592300", Offset = "0x592300")]
	private sealed class _003CVolumeLerp_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x20")]
		public float deltaTime;

		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x24")]
		public float startVol;

		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x28")]
		public float endVol;

		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x30")]
		public VoiceManager _003C_003E4__this;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x38")]
		private AudioBus _003CmusicBus_003E5__2;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x40")]
		private float _003CstartTime_003E5__3;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x44")]
		private float _003Cpercent_003E5__4;

		[Token(Token = "0x1700011A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xA4100C", Offset = "0xA4100C", VA = "0xA4100C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xA41054", Offset = "0xA41054", VA = "0xA41054", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA40E48", Offset = "0xA40E48", VA = "0xA40E48")]
		[DebuggerHidden]
		public _003CVolumeLerp_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA40E74", Offset = "0xA40E74", VA = "0xA40E74", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA40E78", Offset = "0xA40E78", VA = "0xA40E78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA41014", Offset = "0xA41014", VA = "0xA41014", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x48")]
	public int KillCommentFrequency;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x50")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x58")]
	private bool _firstKill;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x59")]
	private bool _firstAlertWarning;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x5C")]
	private int _killCountTowardComment;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x60")]
	private PlayingBark _currentVoice;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x68")]
	private readonly Queue<Bark> _voiceQueue;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x70")]
	private readonly GameTimer _subtitleTimer;

	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine _currentChangeVolume;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x80")]
	private PlayingSoundContainer _beepPlayingSoundContainer;

	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x88")]
	private bool _volumeIsDown;

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x89")]
	private bool _primaryTargetDead;

	[Token(Token = "0x17000115")]
	public PlayingBark CurrentBark
	{
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9792F4", Offset = "0x9792F4", VA = "0x9792F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x9792FC", Offset = "0x9792FC", VA = "0x9792FC")]
	public void OnVOStopped(Sound sound, string clipName)
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x979414", Offset = "0x979414", VA = "0x979414", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x97978C", Offset = "0x97978C", VA = "0x97978C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x979B50", Offset = "0x979B50", VA = "0x979B50", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x979C04", Offset = "0x979C04", VA = "0x979C04")]
	public static bool Play(Bark bark)
	{
		return default(bool);
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x979C88", Offset = "0x979C88", VA = "0x979C88")]
	private bool PlayInternal(Bark voice)
	{
		return default(bool);
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x97A16C", Offset = "0x97A16C", VA = "0x97A16C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x97A0DC", Offset = "0x97A0DC", VA = "0x97A0DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611D70", Offset = "0x611D70")]
	private IEnumerator ChangeVolume(bool up, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x97A2CC", Offset = "0x97A2CC", VA = "0x97A2CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611DD0", Offset = "0x611DD0")]
	private IEnumerator VolumeLerp(float startVol, float endVol, float deltaTime)
	{
		return null;
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x97A35C", Offset = "0x97A35C", VA = "0x97A35C")]
	private void OnLoadingViewDisable(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x97A4F8", Offset = "0x97A4F8", VA = "0x97A4F8")]
	private void OnLoadingViewEnable(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x97A588", Offset = "0x97A588", VA = "0x97A588")]
	private void OnGlobalAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs e)
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x97A720", Offset = "0x97A720", VA = "0x97A720")]
	private void OnDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x97ABF0", Offset = "0x97ABF0", VA = "0x97ABF0")]
	private void AssignmentCompleted(object sender, MissionManager.AssignmentUpdateEventArgs e)
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x97AE2C", Offset = "0x97AE2C", VA = "0x97AE2C")]
	private void OnContractTimingDown(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x97AECC", Offset = "0x97AECC", VA = "0x97AECC")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x97AF34", Offset = "0x97AF34", VA = "0x97AF34")]
	private static void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x97AFF4", Offset = "0x97AFF4", VA = "0x97AFF4")]
	private static void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo args)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x97B220", Offset = "0x97B220", VA = "0x97B220")]
	public VoiceManager()
	{
	}
}
