using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009C9")]
	internal class AndroidVideoClient : IVideoClient
	{
		[Token(Token = "0x20009CA")]
		private class OnCaptureOverlayStateListenerProxy : AndroidJavaProxy
		{
			[Token(Token = "0x20009CB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59767C", Offset = "0x59767C")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x4003407")]
				[FieldOffset(Offset = "0x10")]
				public OnCaptureOverlayStateListenerProxy _003C_003E4__this;

				[Token(Token = "0x4003408")]
				[FieldOffset(Offset = "0x18")]
				public int overlayState;

				[Token(Token = "0x6003E2E")]
				[Address(RVA = "0xA45020", Offset = "0xA45020", VA = "0xA45020")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x6003E2F")]
				[Address(RVA = "0xA45028", Offset = "0xA45028", VA = "0xA45028")]
				internal void _003ConCaptureOverlayStateChanged_003Eb__0()
				{
				}
			}

			[Token(Token = "0x4003406")]
			[FieldOffset(Offset = "0x20")]
			private CaptureOverlayStateListener mListener;

			[Token(Token = "0x6003E2B")]
			[Address(RVA = "0x920FA4", Offset = "0x920FA4", VA = "0x920FA4")]
			public OnCaptureOverlayStateListenerProxy(CaptureOverlayStateListener listener)
			{
			}

			[Token(Token = "0x6003E2C")]
			[Address(RVA = "0x921034", Offset = "0x921034", VA = "0x921034")]
			public void onCaptureOverlayStateChanged(int overlayState)
			{
			}

			[Token(Token = "0x6003E2D")]
			[Address(RVA = "0x921120", Offset = "0x921120", VA = "0x921120")]
			private static VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState)
			{
				return default(VideoCaptureOverlayState);
			}
		}

		[Token(Token = "0x20009CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59768C", Offset = "0x59768C")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4003409")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, VideoCapabilities> callback;

			[Token(Token = "0x6003E30")]
			[Address(RVA = "0x920D20", Offset = "0x920D20", VA = "0x920D20")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6003E31")]
			[Address(RVA = "0x920D28", Offset = "0x920D28", VA = "0x920D28")]
			internal void _003CGetCaptureCapabilities_003Eb__0(AndroidJavaObject videoCapabilities)
			{
			}

			[Token(Token = "0x6003E32")]
			[Address(RVA = "0x920DA0", Offset = "0x920DA0", VA = "0x920DA0")]
			internal void _003CGetCaptureCapabilities_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59769C", Offset = "0x59769C")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x400340A")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, VideoCaptureState> callback;

			[Token(Token = "0x6003E33")]
			[Address(RVA = "0x920DFC", Offset = "0x920DFC", VA = "0x920DFC")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6003E34")]
			[Address(RVA = "0x920E04", Offset = "0x920E04", VA = "0x920E04")]
			internal void _003CGetCaptureState_003Eb__0(AndroidJavaObject captureState)
			{
			}

			[Token(Token = "0x6003E35")]
			[Address(RVA = "0x920E7C", Offset = "0x920E7C", VA = "0x920E7C")]
			internal void _003CGetCaptureState_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5976AC", Offset = "0x5976AC")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x400340B")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, bool> callback;

			[Token(Token = "0x6003E36")]
			[Address(RVA = "0x920ED8", Offset = "0x920ED8", VA = "0x920ED8")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6003E37")]
			[Address(RVA = "0x920EE0", Offset = "0x920EE0", VA = "0x920EE0")]
			internal void _003CIsCaptureAvailable_003Eb__0(bool isCaptureAvailable)
			{
			}

			[Token(Token = "0x6003E38")]
			[Address(RVA = "0x920F48", Offset = "0x920F48", VA = "0x920F48")]
			internal void _003CIsCaptureAvailable_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5976BC", Offset = "0x5976BC")]
		private sealed class _003C_003Ec__DisplayClass12_0<T1, T2>
		{
			[Token(Token = "0x400340C")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toConvert;

			[Token(Token = "0x6003E39")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6003E3A")]
			internal void _003CToOnGameThread_003Eb__0(T1 val1, T2 val2)
			{
			}
		}

		[Token(Token = "0x20009D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5976CC", Offset = "0x5976CC")]
		private sealed class _003C_003Ec__DisplayClass12_1<T1, T2>
		{
			[Token(Token = "0x400340D")]
			[FieldOffset(Offset = "0x0")]
			public T1 val1;

			[Token(Token = "0x400340E")]
			[FieldOffset(Offset = "0x0")]
			public T2 val2;

			[Token(Token = "0x400340F")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass12_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003E3B")]
			public _003C_003Ec__DisplayClass12_1()
			{
			}

			[Token(Token = "0x6003E3C")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mVideosClient;

		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x18")]
		private bool mIsCaptureSupported;

		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x20")]
		private OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;

		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0xD40740", Offset = "0xD40740", VA = "0xD40740")]
		public AndroidVideoClient(bool isCaptureSupported, AndroidJavaObject account)
		{
		}

		[Token(Token = "0x6003E1E")]
		[Address(RVA = "0xD409C8", Offset = "0xD409C8", VA = "0xD409C8", Slot = "4")]
		public void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback)
		{
		}

		[Token(Token = "0x6003E1F")]
		[Address(RVA = "0xD40CE8", Offset = "0xD40CE8", VA = "0xD40CE8", Slot = "5")]
		public void ShowCaptureOverlay()
		{
		}

		[Token(Token = "0x6003E20")]
		[Address(RVA = "0xD40CF0", Offset = "0xD40CF0", VA = "0xD40CF0", Slot = "6")]
		public void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback)
		{
		}

		[Token(Token = "0x6003E21")]
		[Address(RVA = "0xD41010", Offset = "0xD41010", VA = "0xD41010", Slot = "7")]
		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback)
		{
		}

		[Token(Token = "0x6003E22")]
		[Address(RVA = "0xD41374", Offset = "0xD41374", VA = "0xD41374", Slot = "8")]
		public bool IsCaptureSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6003E23")]
		[Address(RVA = "0xD4137C", Offset = "0xD4137C", VA = "0xD4137C", Slot = "9")]
		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener)
		{
		}

		[Token(Token = "0x6003E24")]
		[Address(RVA = "0xD41534", Offset = "0xD41534", VA = "0xD41534", Slot = "10")]
		public void UnregisterCaptureOverlayStateChangedListener()
		{
		}

		[Token(Token = "0x6003E25")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Token(Token = "0x6003E26")]
		[Address(RVA = "0xD416A8", Offset = "0xD416A8", VA = "0xD416A8")]
		private static VideoQualityLevel FromVideoQualityLevel(int captureQualityJava)
		{
			return default(VideoQualityLevel);
		}

		[Token(Token = "0x6003E27")]
		[Address(RVA = "0xD416B4", Offset = "0xD416B4", VA = "0xD416B4")]
		private static VideoCaptureMode FromVideoCaptureMode(int captureMode)
		{
			return default(VideoCaptureMode);
		}

		[Token(Token = "0x6003E28")]
		[Address(RVA = "0xD41364", Offset = "0xD41364", VA = "0xD41364")]
		private static int ToVideoCaptureMode(VideoCaptureMode captureMode)
		{
			return default(int);
		}

		[Token(Token = "0x6003E29")]
		[Address(RVA = "0xD416C4", Offset = "0xD416C4", VA = "0xD416C4")]
		private static VideoCaptureState CreateVideoCaptureState(AndroidJavaObject videoCaptureState)
		{
			return null;
		}

		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0xD41B00", Offset = "0xD41B00", VA = "0xD41B00")]
		private static VideoCapabilities CreateVideoCapabilities(AndroidJavaObject videoCapabilities)
		{
			return null;
		}
	}
}
