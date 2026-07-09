using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012F3")]
	internal class DDNANonTracking : DDNABase
	{
		[Token(Token = "0x20012F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE764", Offset = "0x5AE764")]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x4005AF2")]
			[FieldOffset(Offset = "0x10")]
			public bool succeeded;

			[Token(Token = "0x4005AF3")]
			[FieldOffset(Offset = "0x18")]
			public Action onSuccess;

			[Token(Token = "0x6006F4E")]
			[Address(RVA = "0x868CC4", Offset = "0x868CC4", VA = "0x868CC4")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6006F4F")]
			[Address(RVA = "0x868CCC", Offset = "0x868CCC", VA = "0x868CCC")]
			internal void _003CSend_003Eb__0(int statusCode, string data, string error)
			{
			}
		}

		[Token(Token = "0x20012F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE774", Offset = "0x5AE774")]
		private sealed class _003CSend_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AF4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005AF5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005AF6")]
			[FieldOffset(Offset = "0x20")]
			public Action onSuccess;

			[Token(Token = "0x4005AF7")]
			[FieldOffset(Offset = "0x28")]
			public DDNANonTracking _003C_003E4__this;

			[Token(Token = "0x4005AF8")]
			[FieldOffset(Offset = "0x30")]
			public HttpRequest request;

			[Token(Token = "0x4005AF9")]
			[FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

			[Token(Token = "0x4005AFA")]
			[FieldOffset(Offset = "0x40")]
			private int _003Cattempts_003E5__2;

			[Token(Token = "0x4005AFB")]
			[FieldOffset(Offset = "0x48")]
			private Action<int, string, string> _003ConCompletion_003E5__3;

			[Token(Token = "0x17000C9D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006F53")]
				[Address(RVA = "0x869028", Offset = "0x869028", VA = "0x869028", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006F55")]
				[Address(RVA = "0x869070", Offset = "0x869070", VA = "0x869070", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006F50")]
			[Address(RVA = "0x868DCC", Offset = "0x868DCC", VA = "0x868DCC")]
			[DebuggerHidden]
			public _003CSend_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006F51")]
			[Address(RVA = "0x868DF8", Offset = "0x868DF8", VA = "0x868DF8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006F52")]
			[Address(RVA = "0x868DFC", Offset = "0x868DFC", VA = "0x868DFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006F54")]
			[Address(RVA = "0x869030", Offset = "0x869030", VA = "0x869030", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005AED")]
		[FieldOffset(Offset = "0x30")]
		private bool started;

		[Token(Token = "0x4005AEE")]
		[FieldOffset(Offset = "0x31")]
		private bool uploading;

		[Token(Token = "0x4005AEF")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611098", Offset = "0x611098")]
		private string _003CCrossGameUserID_003Ek__BackingField;

		[Token(Token = "0x4005AF0")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110A8", Offset = "0x6110A8")]
		private string _003CPushNotificationToken_003Ek__BackingField;

		[Token(Token = "0x4005AF1")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6110B8", Offset = "0x6110B8")]
		private string _003CAndroidRegistrationID_003Ek__BackingField;

		[Token(Token = "0x17000C98")]
		internal override bool HasStarted
		{
			[Token(Token = "0x6006F44")]
			[Address(RVA = "0xBD537C", Offset = "0xBD537C", VA = "0xBD537C", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C99")]
		internal override bool IsUploading
		{
			[Token(Token = "0x6006F45")]
			[Address(RVA = "0xBD5384", Offset = "0xBD5384", VA = "0xBD5384", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C9A")]
		internal override string CrossGameUserID
		{
			[Token(Token = "0x6006F46")]
			[Address(RVA = "0xBD538C", Offset = "0xBD538C", VA = "0xBD538C", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C990", Offset = "0x62C990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F47")]
			[Address(RVA = "0xBD5394", Offset = "0xBD5394", VA = "0xBD5394", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C9A0", Offset = "0x62C9A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000C9B")]
		internal override string PushNotificationToken
		{
			[Token(Token = "0x6006F48")]
			[Address(RVA = "0xBD539C", Offset = "0xBD539C", VA = "0xBD539C", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C9B0", Offset = "0x62C9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F49")]
			[Address(RVA = "0xBD53A4", Offset = "0xBD53A4", VA = "0xBD53A4", Slot = "28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C9C0", Offset = "0x62C9C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000C9C")]
		internal override string AndroidRegistrationID
		{
			[Token(Token = "0x6006F4A")]
			[Address(RVA = "0xBD53AC", Offset = "0xBD53AC", VA = "0xBD53AC", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C9D0", Offset = "0x62C9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F4B")]
			[Address(RVA = "0xBD53B4", Offset = "0xBD53B4", VA = "0xBD53B4", Slot = "26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C9E0", Offset = "0x62C9E0")]
			set
			{
			}
		}

		[Token(Token = "0x6006F32")]
		[Address(RVA = "0xBBC3E4", Offset = "0xBBC3E4", VA = "0xBBC3E4")]
		internal DDNANonTracking(DDNA ddna)
		{
		}

		[Token(Token = "0x6006F33")]
		[Address(RVA = "0xBD4570", Offset = "0xBD4570", VA = "0xBD4570", Slot = "4")]
		internal override void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6006F34")]
		[Address(RVA = "0xBD4574", Offset = "0xBD4574", VA = "0xBD4574", Slot = "5")]
		internal override void OnDestroy()
		{
		}

		[Token(Token = "0x6006F35")]
		[Address(RVA = "0xBD4578", Offset = "0xBD4578", VA = "0xBD4578", Slot = "6")]
		internal override void ClearAllEvents()
		{
		}

		[Token(Token = "0x6006F36")]
		[Address(RVA = "0xBD457C", Offset = "0xBD457C", VA = "0xBD457C", Slot = "7")]
		internal override void StartSDK(bool newPlayer)
		{
		}

		[Token(Token = "0x6006F37")]
		[Address(RVA = "0xBD4628", Offset = "0xBD4628", VA = "0xBD4628", Slot = "8")]
		internal override void StopSDK()
		{
		}

		[Token(Token = "0x6006F38")]
		internal override EventAction RecordEvent<T>(T gameEvent)
		{
			return null;
		}

		[Token(Token = "0x6006F39")]
		[Address(RVA = "0xBD4630", Offset = "0xBD4630", VA = "0xBD4630", Slot = "10")]
		internal override EventAction RecordEvent(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0xBD46D4", Offset = "0xBD46D4", VA = "0xBD46D4", Slot = "11")]
		internal override EventAction RecordEvent(string eventName, Dictionary<string, object> eventParams)
		{
			return null;
		}

		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0xBD4778", Offset = "0xBD4778", VA = "0xBD4778", Slot = "12")]
		internal override void RequestEngagement(Engagement engagement, Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0xBD480C", Offset = "0xBD480C", VA = "0xBD480C", Slot = "13")]
		internal override void RequestEngagement(Engagement engagement, Action<Engagement> onCompleted, Action<Exception> onError)
		{
		}

		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0xBD48D0", Offset = "0xBD48D0", VA = "0xBD48D0", Slot = "14")]
		internal override void RecordPushNotification(Dictionary<string, object> payload)
		{
		}

		[Token(Token = "0x6006F3E")]
		[Address(RVA = "0xBD48D4", Offset = "0xBD48D4", VA = "0xBD48D4", Slot = "15")]
		internal override void RequestSessionConfiguration()
		{
		}

		[Token(Token = "0x6006F3F")]
		[Address(RVA = "0xBD48F0", Offset = "0xBD48F0", VA = "0xBD48F0", Slot = "16")]
		internal override void Upload()
		{
		}

		[Token(Token = "0x6006F40")]
		[Address(RVA = "0xBD48F4", Offset = "0xBD48F4", VA = "0xBD48F4", Slot = "17")]
		internal override void DownloadImageAssets()
		{
		}

		[Token(Token = "0x6006F41")]
		[Address(RVA = "0xBD491C", Offset = "0xBD491C", VA = "0xBD491C", Slot = "18")]
		internal override void ClearPersistentData()
		{
		}

		[Token(Token = "0x6006F42")]
		[Address(RVA = "0xBD4920", Offset = "0xBD4920", VA = "0xBD4920", Slot = "19")]
		internal override void ForgetMe()
		{
		}

		[Token(Token = "0x6006F43")]
		[Address(RVA = "0xBD51F4", Offset = "0xBD51F4", VA = "0xBD51F4", Slot = "20")]
		internal override void StopTrackingMe()
		{
		}

		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0xBD5174", Offset = "0xBD5174", VA = "0xBD5174")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C9F0", Offset = "0x62C9F0")]
		private IEnumerator Send(HttpRequest request, Action onSuccess)
		{
			return null;
		}

		[Token(Token = "0x6006F4D")]
		[Address(RVA = "0xBD53BC", Offset = "0xBD53BC", VA = "0xBD53BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CA50", Offset = "0x62CA50")]
		private void _003CForgetMe_003Eb__18_0()
		{
		}
	}
}
