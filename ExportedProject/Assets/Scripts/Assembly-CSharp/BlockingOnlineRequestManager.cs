using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200021B")]
[Scope]
public class BlockingOnlineRequestManager : GameSingleton<BlockingOnlineRequestManager>
{
	[Token(Token = "0x200021C")]
	public class ReqHandle : IDisposable
	{
		[Token(Token = "0x200021D")]
		public enum Completion
		{
			[Token(Token = "0x4000C0D")]
			Pending = 0,
			[Token(Token = "0x4000C0E")]
			Started = 1,
			[Token(Token = "0x4000C0F")]
			Failed = 2,
			[Token(Token = "0x4000C10")]
			Succeeded = 3,
			[Token(Token = "0x4000C11")]
			Discarded = 4
		}

		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x10")]
		public Action<ReqHandle> OnOnlineConfirmed;

		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x18")]
		public Action<ReqHandle> OnOnlineFailed;

		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x20")]
		public Action OnCompleted;

		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x28")]
		public Completion Status;

		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x2C")]
		public bool DisplayWaitPopup;

		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x2D")]
		public bool ForceRetryOnSuspend;

		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x2E")]
		public bool DoOnlineTest;

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x926C50", Offset = "0x926C50", VA = "0x926C50")]
		public ReqHandle(bool displayWaitPopup, bool forceRetryOnSuspend, bool doOnlineTest, Action<ReqHandle> onOnlineConfirmed, Action<ReqHandle> onOnlineFailed)
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x926A9C", Offset = "0x926A9C", VA = "0x926A9C")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x926AF4", Offset = "0x926AF4", VA = "0x926AF4", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x200021E")]
	private enum OnlineRequestState
	{
		[Token(Token = "0x4000C13")]
		None = 0,
		[Token(Token = "0x4000C14")]
		ConnectivityCheck = 1,
		[Token(Token = "0x4000C15")]
		CallbacksProcessing = 2,
		[Token(Token = "0x4000C16")]
		AutoRetry = 3
	}

	[Token(Token = "0x200021F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B50", Offset = "0x592B50")]
	private sealed class _003COnlineSuiteInit_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x20")]
		public BlockingOnlineRequestManager _003C_003E4__this;

		[Token(Token = "0x170001FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x9267AC", Offset = "0x9267AC", VA = "0x9267AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000200")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x9267F4", Offset = "0x9267F4", VA = "0x9267F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x9264F8", Offset = "0x9264F8", VA = "0x9264F8")]
		[DebuggerHidden]
		public _003COnlineSuiteInit_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x926524", Offset = "0x926524", VA = "0x926524", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x926528", Offset = "0x926528", VA = "0x926528", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x9267B4", Offset = "0x9267B4", VA = "0x9267B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B60", Offset = "0x592B60")]
	private sealed class _003CTryExecuteRequest_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x20")]
		public bool isOnline;

		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x28")]
		public BlockingOnlineRequestManager _003C_003E4__this;

		[Token(Token = "0x17000201")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x926B08", Offset = "0x926B08", VA = "0x926B08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x926B50", Offset = "0x926B50", VA = "0x926B50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x9268F8", Offset = "0x9268F8", VA = "0x9268F8")]
		[DebuggerHidden]
		public _003CTryExecuteRequest_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x926924", Offset = "0x926924", VA = "0x926924", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x926928", Offset = "0x926928", VA = "0x926928", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x926B10", Offset = "0x926B10", VA = "0x926B10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000221")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B70", Offset = "0x592B70")]
	private sealed class _003CDoWaitPopup_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x20")]
		public BlockingOnlineRequestManager _003C_003E4__this;

		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x28")]
		public bool createPopupImmediately;

		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Cstart_003E5__2;

		[Token(Token = "0x17000203")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x9264A8", Offset = "0x9264A8", VA = "0x9264A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000204")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x9264F0", Offset = "0x9264F0", VA = "0x9264F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x9261D8", Offset = "0x9261D8", VA = "0x9261D8")]
		[DebuggerHidden]
		public _003CDoWaitPopup_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x926204", Offset = "0x926204", VA = "0x926204", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x926208", Offset = "0x926208", VA = "0x926208", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x9264B0", Offset = "0x9264B0", VA = "0x9264B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000222")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B80", Offset = "0x592B80")]
	private sealed class _003CStopWaitPopup_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x20")]
		public BlockingOnlineRequestManager _003C_003E4__this;

		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x28")]
		public Action onDone;

		[Token(Token = "0x17000205")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x9268A8", Offset = "0x9268A8", VA = "0x9268A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000206")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x9268F0", Offset = "0x9268F0", VA = "0x9268F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x9267FC", Offset = "0x9267FC", VA = "0x9267FC")]
		[DebuggerHidden]
		public _003CStopWaitPopup_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x926828", Offset = "0x926828", VA = "0x926828", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x92682C", Offset = "0x92682C", VA = "0x92682C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x9268B0", Offset = "0x9268B0", VA = "0x9268B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000223")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B90", Offset = "0x592B90")]
	private sealed class _003CWaitForRealSeconds_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x24")]
		private float _003Cstart_003E5__2;

		[Token(Token = "0x17000207")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x926C00", Offset = "0x926C00", VA = "0x926C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x926C48", Offset = "0x926C48", VA = "0x926C48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x926B58", Offset = "0x926B58", VA = "0x926B58")]
		[DebuggerHidden]
		public _003CWaitForRealSeconds_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x926B84", Offset = "0x926B84", VA = "0x926B84", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x926B88", Offset = "0x926B88", VA = "0x926B88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x926C08", Offset = "0x926C08", VA = "0x926C08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<ReqHandle> _requests;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x50")]
	private OnlineRequestState _onlineRequestState;

	[Token(Token = "0x4000BFB")]
	private const float WAIT_POPUP_MIN_DURATION = 0.5f;

	[Token(Token = "0x4000BFC")]
	private const float WAIT_POPUP_FORCE_AFTER_DURATION = 20f;

	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x54")]
	private float _savedTimeScale;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x58")]
	private bool _applicationWentToBackground;

	[Token(Token = "0x4000BFF")]
	private const int MAX_AUTORETRY_ONLINESUITE = 3;

	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x5C")]
	private int _autoretryOnlineSuiteInitAttempts;

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PopupWaitPrefab;

	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x68")]
	private GameObject _popupWait;

	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x70")]
	private bool _stopWaitASAP;

	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x71")]
	private bool _doingWaitPopup;

	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0xC69218", Offset = "0xC69218", VA = "0xC69218")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0xC69228", Offset = "0xC69228", VA = "0xC69228")]
	public bool IsShowingPopups()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0xC69294", Offset = "0xC69294", VA = "0xC69294")]
	protected void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0xC692A0", Offset = "0xC692A0", VA = "0xC692A0")]
	public ReqHandle StartOnlineRequest(bool displayWaitPopup, Action<ReqHandle> onOnlineConfirmed, Action<ReqHandle> onOnlineFailed, bool forceRetryOnSuspend = true, bool doOnlineTest = true)
	{
		return null;
	}

	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0xC69390", Offset = "0xC69390", VA = "0xC69390")]
	public void CompleteOnlineRequest(ReqHandle handle, Action onCompleted)
	{
	}

	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0xC69538", Offset = "0xC69538", VA = "0xC69538")]
	public void FailOnlineRequest(ReqHandle handle, Action onCompleted)
	{
	}

	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0xC6958C", Offset = "0xC6958C", VA = "0xC6958C")]
	public void ContinueOnlineRequest(ReqHandle handle, Action nextAction)
	{
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0xC692C0", Offset = "0xC692C0", VA = "0xC692C0")]
	private ReqHandle EnqueueRequest(bool displayWaitPopup, bool forceRetryOnSuspend, bool doOnlineTest, Action<ReqHandle> onOnlineConfirmed, Action<ReqHandle> onOnlineFailed)
	{
		return null;
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0xC69608", Offset = "0xC69608", VA = "0xC69608")]
	private void ProcessNextRequest()
	{
	}

	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0xC696B0", Offset = "0xC696B0", VA = "0xC696B0")]
	private void StartConnectivityChecks(ReqHandle handle, bool forceDisplayWaitPopup = false)
	{
	}

	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0xC69910", Offset = "0xC69910", VA = "0xC69910")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614394", Offset = "0x614394")]
	private IEnumerator OnlineSuiteInit()
	{
		return null;
	}

	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0xC6997C", Offset = "0xC6997C", VA = "0xC6997C")]
	private void OnCheckOnlineDone(object sender, CheckIsOnlineArgs e)
	{
	}

	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0xC69890", Offset = "0xC69890", VA = "0xC69890")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6143F4", Offset = "0x6143F4")]
	private IEnumerator TryExecuteRequest(bool isOnline)
	{
		return null;
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0xC69810", Offset = "0xC69810", VA = "0xC69810")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614454", Offset = "0x614454")]
	private IEnumerator DoWaitPopup(bool createPopupImmediately)
	{
		return null;
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0xC69738", Offset = "0xC69738", VA = "0xC69738")]
	private void DestroyWaitPopup()
	{
	}

	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0xC693E4", Offset = "0xC693E4", VA = "0xC693E4")]
	private void ProcessRequestResult(ReqHandle handle, bool success)
	{
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0xC69A68", Offset = "0xC69A68", VA = "0xC69A68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6144B4", Offset = "0x6144B4")]
	private IEnumerator StopWaitPopup(Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0xC69AE0", Offset = "0xC69AE0", VA = "0xC69AE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614514", Offset = "0x614514")]
	public static IEnumerator WaitForRealSeconds(float time)
	{
		return null;
	}

	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0xC69B54", Offset = "0xC69B54", VA = "0xC69B54")]
	public BlockingOnlineRequestManager()
	{
	}

	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0xC69C10", Offset = "0xC69C10", VA = "0xC69C10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614574", Offset = "0x614574")]
	private void _003CProcessRequestResult_003Eb__29_0()
	{
	}
}
