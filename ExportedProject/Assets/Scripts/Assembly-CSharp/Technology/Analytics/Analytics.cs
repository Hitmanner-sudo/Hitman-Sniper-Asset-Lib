using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using Technology.Security;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E50")]
	public abstract class Analytics<T> : Singleton<T> where T : Analytics<T>, new()
	{
		[Token(Token = "0x40043BE")]
		private const double PAUSE_DURATION_BEFORE_RESET = 300.0;

		[Token(Token = "0x40043BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool IsEnabled;

		[Token(Token = "0x40043C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFCB4", Offset = "0x5BFCB4")]
		private float _003CTimerInterval_003Ek__BackingField;

		[Token(Token = "0x40043C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<AnalyticModule> _modules;

		[Token(Token = "0x40043C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _pauseState;

		[Token(Token = "0x40043C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DateTime _startPauseTime;

		[Token(Token = "0x40043C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected DateTime SessionStartTime;

		[Token(Token = "0x40043C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DisableAnalytics;

		[Token(Token = "0x17000BD6")]
		protected float TimerInterval
		{
			[Token(Token = "0x6005821")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA20", Offset = "0x62BA20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6005822")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA30", Offset = "0x62BA30")]
			set
			{
			}
		}

		[Token(Token = "0x6005823")]
		protected Analytics()
		{
		}

		[Token(Token = "0x6005824")]
		protected abstract EventAttribute[] GetDefaultAttributes();

		[Token(Token = "0x6005825")]
		protected abstract void SetTerminationMeasures();

		[Token(Token = "0x6005826")]
		protected abstract void OnApplicationPaused();

		[Token(Token = "0x6005827")]
		protected abstract void OnApplicationReset();

		[Token(Token = "0x6005828")]
		protected abstract void OnApplicationResumed();

		[Token(Token = "0x6005829")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600582A")]
		private void OnValidateInstall(InstallValidationEventArgs e)
		{
		}

		[Token(Token = "0x600582B")]
		public void RegisterModule(Type moduleType, IFlushPermissionProvider flushPermissionProvider)
		{
		}

		[Token(Token = "0x600582C")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x600582D")]
		public virtual void OnApplicationPause(bool pauseState)
		{
		}

		[Token(Token = "0x600582E")]
		public virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600582F")]
		public virtual void Flush([Optional] Action<OSRequestState> response, bool isAsync = true)
		{
		}

		[Token(Token = "0x6005830")]
		public virtual void ForceFlush(HashSet<string> eventNameFilter)
		{
		}

		[Token(Token = "0x6005831")]
		public void SendEvent(AnalyticEvent analyticEvent, bool outputToLog = false)
		{
		}

		[Token(Token = "0x6005832")]
		public EventAttribute[] AddDefaultAttributes(params EventAttribute[] specificAttributes)
		{
			return null;
		}

		[Token(Token = "0x6005833")]
		protected virtual void Destroy()
		{
		}
	}
}
