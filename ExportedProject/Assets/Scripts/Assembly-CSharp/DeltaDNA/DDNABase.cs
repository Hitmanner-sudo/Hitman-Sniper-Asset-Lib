using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x20012E9")]
	internal abstract class DDNABase
	{
		[Serializable]
		[Token(Token = "0x20012EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE6E4", Offset = "0x5AE6E4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005AB9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005ABA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<DateTime?> _003C_003E9__65_0;

			[Token(Token = "0x6006EE7")]
			[Address(RVA = "0x865908", Offset = "0x865908", VA = "0x865908")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6006EE8")]
			[Address(RVA = "0x865910", Offset = "0x865910", VA = "0x865910")]
			internal DateTime? _003CUseCollectTimestamp_003Eb__65_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4005AB4")]
		[FieldOffset(Offset = "0x0")]
		protected static Func<DateTime?> TimestampFunc;

		[Token(Token = "0x4005AB5")]
		[FieldOffset(Offset = "0x10")]
		protected readonly DDNA ddna;

		[Token(Token = "0x4005AB6")]
		[FieldOffset(Offset = "0x18")]
		protected readonly GameObject gameObject;

		[Token(Token = "0x4005AB7")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611078", Offset = "0x611078")]
		private ImageMessageStore _003CImageMessageStore_003Ek__BackingField;

		[Token(Token = "0x4005AB8")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611088", Offset = "0x611088")]
		private EngageFactory _003CEngageFactory_003Ek__BackingField;

		[Token(Token = "0x17000C7D")]
		internal ImageMessageStore ImageMessageStore
		{
			[Token(Token = "0x6006EC6")]
			[Address(RVA = "0xBC0854", Offset = "0xBC0854", VA = "0xBC0854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C700", Offset = "0x62C700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EC7")]
			[Address(RVA = "0xBC085C", Offset = "0xBC085C", VA = "0xBC085C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C710", Offset = "0x62C710")]
			set
			{
			}
		}

		[Token(Token = "0x17000C7E")]
		internal EngageFactory EngageFactory
		{
			[Token(Token = "0x6006EC8")]
			[Address(RVA = "0xBC0864", Offset = "0xBC0864", VA = "0xBC0864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C720", Offset = "0x62C720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EC9")]
			[Address(RVA = "0xBC086C", Offset = "0xBC086C", VA = "0xBC086C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C730", Offset = "0x62C730")]
			set
			{
			}
		}

		[Token(Token = "0x17000C7F")]
		protected string EnvironmentKey
		{
			[Token(Token = "0x6006ECA")]
			[Address(RVA = "0xBC0874", Offset = "0xBC0874", VA = "0xBC0874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C80")]
		protected string CollectURL
		{
			[Token(Token = "0x6006ECB")]
			[Address(RVA = "0xBC0890", Offset = "0xBC0890", VA = "0xBC0890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C81")]
		protected string EngageURL
		{
			[Token(Token = "0x6006ECC")]
			[Address(RVA = "0xBC08AC", Offset = "0xBC08AC", VA = "0xBC08AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C82")]
		protected string Platform
		{
			[Token(Token = "0x6006ECD")]
			[Address(RVA = "0xBC08C8", Offset = "0xBC08C8", VA = "0xBC08C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C83")]
		protected string HashSecret
		{
			[Token(Token = "0x6006ECE")]
			[Address(RVA = "0xBC08E4", Offset = "0xBC08E4", VA = "0xBC08E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C84")]
		protected string ClientVersion
		{
			[Token(Token = "0x6006ECF")]
			[Address(RVA = "0xBC0900", Offset = "0xBC0900", VA = "0xBC0900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C85")]
		protected Settings Settings
		{
			[Token(Token = "0x6006ED0")]
			[Address(RVA = "0xBC091C", Offset = "0xBC091C", VA = "0xBC091C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C86")]
		protected string UserID
		{
			[Token(Token = "0x6006ED1")]
			[Address(RVA = "0xBC0938", Offset = "0xBC0938", VA = "0xBC0938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C87")]
		protected string SessionID
		{
			[Token(Token = "0x6006ED2")]
			[Address(RVA = "0xBC0950", Offset = "0xBC0950", VA = "0xBC0950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C88")]
		internal abstract bool HasStarted
		{
			[Token(Token = "0x6006ED3")]
			get;
		}

		[Token(Token = "0x17000C89")]
		internal abstract bool IsUploading
		{
			[Token(Token = "0x6006ED4")]
			get;
		}

		[Token(Token = "0x17000C8A")]
		internal abstract string CrossGameUserID
		{
			[Token(Token = "0x6006ED5")]
			get;
			[Token(Token = "0x6006ED6")]
			set;
		}

		[Token(Token = "0x17000C8B")]
		internal abstract string AndroidRegistrationID
		{
			[Token(Token = "0x6006ED7")]
			get;
			[Token(Token = "0x6006ED8")]
			set;
		}

		[Token(Token = "0x17000C8C")]
		internal abstract string PushNotificationToken
		{
			[Token(Token = "0x6006ED9")]
			get;
			[Token(Token = "0x6006EDA")]
			set;
		}

		[Token(Token = "0x6006EB4")]
		[Address(RVA = "0xBC0810", Offset = "0xBC0810", VA = "0xBC0810")]
		internal DDNABase(DDNA ddna)
		{
		}

		[Token(Token = "0x6006EB5")]
		internal abstract void OnApplicationPause(bool pauseStatus);

		[Token(Token = "0x6006EB6")]
		internal abstract void OnDestroy();

		[Token(Token = "0x6006EB7")]
		internal abstract void ClearAllEvents();

		[Token(Token = "0x6006EB8")]
		internal abstract void StartSDK(bool newPlayer);

		[Token(Token = "0x6006EB9")]
		internal abstract void StopSDK();

		[Token(Token = "0x6006EBA")]
		internal abstract EventAction RecordEvent<T>(T gameEvent) where T : GameEvent<T>;

		[Token(Token = "0x6006EBB")]
		internal abstract EventAction RecordEvent(string eventName);

		[Token(Token = "0x6006EBC")]
		internal abstract EventAction RecordEvent(string eventName, Dictionary<string, object> eventParams);

		[Token(Token = "0x6006EBD")]
		internal abstract void RequestEngagement(Engagement engagement, Action<Dictionary<string, object>> callback);

		[Token(Token = "0x6006EBE")]
		internal abstract void RequestEngagement(Engagement engagement, Action<Engagement> onCompleted, Action<Exception> onError);

		[Token(Token = "0x6006EBF")]
		internal abstract void RecordPushNotification(Dictionary<string, object> payload);

		[Token(Token = "0x6006EC0")]
		internal abstract void RequestSessionConfiguration();

		[Token(Token = "0x6006EC1")]
		internal abstract void Upload();

		[Token(Token = "0x6006EC2")]
		internal abstract void DownloadImageAssets();

		[Token(Token = "0x6006EC3")]
		internal abstract void ClearPersistentData();

		[Token(Token = "0x6006EC4")]
		internal abstract void ForgetMe();

		[Token(Token = "0x6006EC5")]
		internal abstract void StopTrackingMe();

		[Token(Token = "0x6006EDB")]
		[Address(RVA = "0xBC096C", Offset = "0xBC096C", VA = "0xBC096C")]
		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6006EDC")]
		[Address(RVA = "0xBC0988", Offset = "0xBC0988", VA = "0xBC0988")]
		protected void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		[Token(Token = "0x6006EDD")]
		[Address(RVA = "0xBC09A4", Offset = "0xBC09A4", VA = "0xBC09A4")]
		protected bool IsInvoking(string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6006EDE")]
		[Address(RVA = "0xBC09C0", Offset = "0xBC09C0", VA = "0xBC09C0")]
		protected void CancelInvoke()
		{
		}

		[Token(Token = "0x6006EDF")]
		[Address(RVA = "0xBC09DC", Offset = "0xBC09DC", VA = "0xBC09DC")]
		protected void NewSession()
		{
		}

		[Token(Token = "0x6006EE0")]
		[Address(RVA = "0xBBE854", Offset = "0xBBE854", VA = "0xBBE854")]
		internal void UseCollectTimestamp(bool useCollect)
		{
		}

		[Token(Token = "0x6006EE1")]
		[Address(RVA = "0xBBE9C0", Offset = "0xBBE9C0", VA = "0xBBE9C0")]
		internal void SetTimestampFunc(Func<DateTime?> TimestampFunc)
		{
		}

		[Token(Token = "0x6006EE2")]
		[Address(RVA = "0xBC09F4", Offset = "0xBC09F4", VA = "0xBC09F4")]
		protected static string GetCurrentTimestamp()
		{
			return null;
		}

		[Token(Token = "0x6006EE3")]
		[Address(RVA = "0xBC0BB0", Offset = "0xBC0BB0", VA = "0xBC0BB0")]
		private static DateTime? DefaultTimestampFunc()
		{
			return null;
		}

		[Token(Token = "0x6006EE4")]
		[Address(RVA = "0xBC0C44", Offset = "0xBC0C44", VA = "0xBC0C44")]
		public void RecordGameRunningEvent()
		{
		}
	}
}
