using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Frankfort.Threading.Internal;
using Il2CppDummyDll;
using Technology;
using Technology.Core.Common;

namespace Frankfort.Threading
{
	[Token(Token = "0x2000A2D")]
	[Scope]
	[AutoInstantiate]
	public class ThreadPoolScheduler : GameSingleton<ThreadPoolScheduler>
	{
		[Token(Token = "0x2000A2E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5978F0", Offset = "0x5978F0")]
		private sealed class _003CWaitAndExecuteWorkerObjects_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IThreadWorkerObject[] workerObjects;

			[Token(Token = "0x4003558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ThreadPoolScheduler _003C_003E4__this;

			[Token(Token = "0x1700084A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60040BD")]
				[Address(RVA = "0xA36FD0", Offset = "0xA36FD0", VA = "0xA36FD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700084B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60040BF")]
				[Address(RVA = "0xA37018", Offset = "0xA37018", VA = "0xA37018", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60040BA")]
			[Address(RVA = "0xA36DF4", Offset = "0xA36DF4", VA = "0xA36DF4")]
			[DebuggerHidden]
			public _003CWaitAndExecuteWorkerObjects_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60040BB")]
			[Address(RVA = "0xA36E20", Offset = "0xA36E20", VA = "0xA36E20", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60040BC")]
			[Address(RVA = "0xA36E24", Offset = "0xA36E24", VA = "0xA36E24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60040BE")]
			[Address(RVA = "0xA36FD8", Offset = "0xA36FD8", VA = "0xA36FD8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000A2F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597900", Offset = "0x597900")]
		private sealed class _003CWaitForCompletion_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400355A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400355B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThreadPoolScheduler _003C_003E4__this;

			[Token(Token = "0x1700084C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60040C3")]
				[Address(RVA = "0xA37210", Offset = "0xA37210", VA = "0xA37210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700084D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60040C5")]
				[Address(RVA = "0xA37258", Offset = "0xA37258", VA = "0xA37258", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60040C0")]
			[Address(RVA = "0xA37020", Offset = "0xA37020", VA = "0xA37020")]
			[DebuggerHidden]
			public _003CWaitForCompletion_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60040C1")]
			[Address(RVA = "0xA3704C", Offset = "0xA3704C", VA = "0xA3704C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60040C2")]
			[Address(RVA = "0xA37050", Offset = "0xA37050", VA = "0xA37050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60040C4")]
			[Address(RVA = "0xA37218", Offset = "0xA37218", VA = "0xA37218", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400354A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool DebugMode;

		[Token(Token = "0x400354B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool ForceToMainThread;

		[Token(Token = "0x400354C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float WaitForSecondsTime;

		[Token(Token = "0x400354D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _providerThreadBusy;

		[Token(Token = "0x400354E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _shedularBusy;

		[Token(Token = "0x400354F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool _isAborted;

		[Token(Token = "0x4003550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ASyncThreadWorkData workData;

		[Token(Token = "0x4003551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private WinRTThread providerThread;

		[Token(Token = "0x4003552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int workObjectIndex;

		[Token(Token = "0x4003553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ThreadPoolSchedulerEvent onCompleteCallBack;

		[Token(Token = "0x4003554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ThreadedWorkCompleteEvent onWorkerObjectDoneCallBack;

		[Token(Token = "0x17000848")]
		public bool isBusy
		{
			[Token(Token = "0x60040AB")]
			[Address(RVA = "0xACD808", Offset = "0xACD808", VA = "0xACD808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000849")]
		public float Progress
		{
			[Token(Token = "0x60040AC")]
			[Address(RVA = "0xACD810", Offset = "0xACD810", VA = "0xACD810")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60040AD")]
		[Address(RVA = "0xACD890", Offset = "0xACD890", VA = "0xACD890", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60040AE")]
		[Address(RVA = "0xACD954", Offset = "0xACD954", VA = "0xACD954", Slot = "15")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60040AF")]
		[Address(RVA = "0xACDC04", Offset = "0xACDC04", VA = "0xACDC04", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60040B0")]
		[Address(RVA = "0xACDCAC", Offset = "0xACDCAC", VA = "0xACDCAC")]
		public void StartASyncThreads(IThreadWorkerObject[] workerObjects, ThreadPoolSchedulerEvent onCompleteCallBack, [Optional] ThreadedWorkCompleteEvent onPackageExecuted, int maxThreads = -1, bool safeMode = true)
		{
		}

		[Token(Token = "0x60040B1")]
		[Address(RVA = "0xACDE5C", Offset = "0xACDE5C", VA = "0xACDE5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6252B8", Offset = "0x6252B8")]
		private IEnumerator WaitAndExecuteWorkerObjects(IThreadWorkerObject[] workerObjects)
		{
			return null;
		}

		[Token(Token = "0x60040B2")]
		[Address(RVA = "0xACDED4", Offset = "0xACDED4", VA = "0xACDED4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625318", Offset = "0x625318")]
		private IEnumerator WaitForCompletion()
		{
			return null;
		}

		[Token(Token = "0x60040B3")]
		[Address(RVA = "0xACD9AC", Offset = "0xACD9AC", VA = "0xACD9AC")]
		public void AbortASyncThreads(bool sleepTillAborted = false)
		{
		}

		[Token(Token = "0x60040B4")]
		[Address(RVA = "0xACDF40", Offset = "0xACDF40", VA = "0xACDF40")]
		public void InvokeASyncThreadPoolWork()
		{
		}

		[Token(Token = "0x60040B5")]
		[Address(RVA = "0xACE2B8", Offset = "0xACE2B8", VA = "0xACE2B8")]
		private AutoResetEvent[] GetStartedPackageEvents()
		{
			return null;
		}

		[Token(Token = "0x60040B6")]
		[Address(RVA = "0xACE3D4", Offset = "0xACE3D4", VA = "0xACE3D4")]
		private IThreadWorkerObject[] GetWorkerObjectsFromPackages()
		{
			return null;
		}

		[Token(Token = "0x60040B7")]
		[Address(RVA = "0xACE504", Offset = "0xACE504", VA = "0xACE504")]
		public int GetFinishedPackagesCount()
		{
			return default(int);
		}

		[Token(Token = "0x60040B8")]
		[Address(RVA = "0xACE570", Offset = "0xACE570", VA = "0xACE570")]
		public int GetUnhandledFinishedPackagesCount()
		{
			return default(int);
		}

		[Token(Token = "0x60040B9")]
		[Address(RVA = "0xACE5E8", Offset = "0xACE5E8", VA = "0xACE5E8")]
		public ThreadPoolScheduler()
		{
		}
	}
}
