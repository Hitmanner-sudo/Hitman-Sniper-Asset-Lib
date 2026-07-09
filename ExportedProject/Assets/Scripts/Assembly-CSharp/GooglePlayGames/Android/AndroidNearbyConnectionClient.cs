using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009A0")]
	public class AndroidNearbyConnectionClient : INearbyConnectionClient
	{
		[Token(Token = "0x20009A1")]
		private class AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
		{
			[Token(Token = "0x400339D")]
			[FieldOffset(Offset = "0x20")]
			private Action<AdvertisingResult> mResultCallback;

			[Token(Token = "0x400339E")]
			[FieldOffset(Offset = "0x28")]
			private Action<ConnectionRequest> mConnectionRequestCallback;

			[Token(Token = "0x400339F")]
			[FieldOffset(Offset = "0x30")]
			private AndroidNearbyConnectionClient mClient;

			[Token(Token = "0x40033A0")]
			[FieldOffset(Offset = "0x38")]
			private string mLocalEndpointName;

			[Token(Token = "0x6003D90")]
			[Address(RVA = "0x91AED4", Offset = "0x91AED4", VA = "0x91AED4")]
			public AdvertisingConnectionLifecycleCallbackProxy(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client)
			{
			}

			[Token(Token = "0x6003D91")]
			[Address(RVA = "0x91AF78", Offset = "0x91AF78", VA = "0x91AF78")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Token(Token = "0x6003D92")]
			[Address(RVA = "0x91B174", Offset = "0x91B174", VA = "0x91B174")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Token(Token = "0x6003D93")]
			[Address(RVA = "0x91B4CC", Offset = "0x91B4CC", VA = "0x91B4CC")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		[Token(Token = "0x20009A2")]
		private class PayloadCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40033A1")]
			[FieldOffset(Offset = "0x20")]
			private IMessageListener mListener;

			[Token(Token = "0x6003D94")]
			[Address(RVA = "0x91B9B0", Offset = "0x91B9B0", VA = "0x91B9B0")]
			public PayloadCallback(IMessageListener listener)
			{
			}

			[Token(Token = "0x6003D95")]
			[Address(RVA = "0x91C844", Offset = "0x91C844", VA = "0x91C844")]
			public void onPayloadReceived(string endpointId, AndroidJavaObject payload)
			{
			}
		}

		[Token(Token = "0x20009A3")]
		private class DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40033A2")]
			[FieldOffset(Offset = "0x20")]
			private Action<ConnectionResponse> mResponseCallback;

			[Token(Token = "0x40033A3")]
			[FieldOffset(Offset = "0x28")]
			private IMessageListener mListener;

			[Token(Token = "0x40033A4")]
			[FieldOffset(Offset = "0x30")]
			private AndroidJavaObject mClient;

			[Token(Token = "0x6003D96")]
			[Address(RVA = "0x91B5A4", Offset = "0x91B5A4", VA = "0x91B5A4")]
			public DiscoveringConnectionLifecycleCallback(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client)
			{
			}

			[Token(Token = "0x6003D97")]
			[Address(RVA = "0x91B648", Offset = "0x91B648", VA = "0x91B648")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Token(Token = "0x6003D98")]
			[Address(RVA = "0x91BA40", Offset = "0x91BA40", VA = "0x91BA40")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Token(Token = "0x6003D99")]
			[Address(RVA = "0x91BED0", Offset = "0x91BED0", VA = "0x91BED0")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		[Token(Token = "0x20009A4")]
		private class EndpointDiscoveryCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40033A5")]
			[FieldOffset(Offset = "0x20")]
			private IDiscoveryListener mListener;

			[Token(Token = "0x6003D9A")]
			[Address(RVA = "0x91BF90", Offset = "0x91BF90", VA = "0x91BF90")]
			public EndpointDiscoveryCallback(IDiscoveryListener listener)
			{
			}

			[Token(Token = "0x6003D9B")]
			[Address(RVA = "0x91C020", Offset = "0x91C020", VA = "0x91C020")]
			public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo)
			{
			}

			[Token(Token = "0x6003D9C")]
			[Address(RVA = "0x91C320", Offset = "0x91C320", VA = "0x91C320")]
			public void onEndpointLost(string endpointId)
			{
			}

			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x91C130", Offset = "0x91C130", VA = "0x91C130")]
			private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo)
			{
				return default(EndpointDetails);
			}
		}

		[Token(Token = "0x20009A5")]
		private class OnGameThreadMessageListener : IMessageListener
		{
			[Token(Token = "0x20009A6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5974EC", Offset = "0x5974EC")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x40033A7")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadMessageListener _003C_003E4__this;

				[Token(Token = "0x40033A8")]
				[FieldOffset(Offset = "0x18")]
				public string remoteEndpointId;

				[Token(Token = "0x40033A9")]
				[FieldOffset(Offset = "0x20")]
				public byte[] data;

				[Token(Token = "0x40033AA")]
				[FieldOffset(Offset = "0x28")]
				public bool isReliableMessage;

				[Token(Token = "0x6003DA1")]
				[Address(RVA = "0xA44E7C", Offset = "0xA44E7C", VA = "0xA44E7C")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x6003DA2")]
				[Address(RVA = "0xA44E84", Offset = "0xA44E84", VA = "0xA44E84")]
				internal void _003COnMessageReceived_003Eb__0()
				{
				}
			}

			[Token(Token = "0x20009A7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5974FC", Offset = "0x5974FC")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x40033AB")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadMessageListener _003C_003E4__this;

				[Token(Token = "0x40033AC")]
				[FieldOffset(Offset = "0x18")]
				public string remoteEndpointId;

				[Token(Token = "0x6003DA3")]
				[Address(RVA = "0xA44F58", Offset = "0xA44F58", VA = "0xA44F58")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x6003DA4")]
				[Address(RVA = "0xA44F60", Offset = "0xA44F60", VA = "0xA44F60")]
				internal void _003COnRemoteEndpointDisconnected_003Eb__0()
				{
				}
			}

			[Token(Token = "0x40033A6")]
			[FieldOffset(Offset = "0x10")]
			private readonly IMessageListener mListener;

			[Token(Token = "0x6003D9E")]
			[Address(RVA = "0x91C5EC", Offset = "0x91C5EC", VA = "0x91C5EC")]
			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			[Token(Token = "0x6003D9F")]
			[Address(RVA = "0x91C658", Offset = "0x91C658", VA = "0x91C658", Slot = "4")]
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			[Token(Token = "0x6003DA0")]
			[Address(RVA = "0x91C75C", Offset = "0x91C75C", VA = "0x91C75C", Slot = "5")]
			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}
		}

		[Token(Token = "0x20009A8")]
		private class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			[Token(Token = "0x20009A9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59750C", Offset = "0x59750C")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x40033AE")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadDiscoveryListener _003C_003E4__this;

				[Token(Token = "0x40033AF")]
				[FieldOffset(Offset = "0x18")]
				public EndpointDetails discoveredEndpoint;

				[Token(Token = "0x6003DA8")]
				[Address(RVA = "0xA44CB4", Offset = "0xA44CB4", VA = "0xA44CB4")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x6003DA9")]
				[Address(RVA = "0xA44CBC", Offset = "0xA44CBC", VA = "0xA44CBC")]
				internal void _003COnEndpointFound_003Eb__0()
				{
				}
			}

			[Token(Token = "0x20009AA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59751C", Offset = "0x59751C")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x40033B0")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadDiscoveryListener _003C_003E4__this;

				[Token(Token = "0x40033B1")]
				[FieldOffset(Offset = "0x18")]
				public string lostEndpointId;

				[Token(Token = "0x6003DAA")]
				[Address(RVA = "0xA44DB4", Offset = "0xA44DB4", VA = "0xA44DB4")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x6003DAB")]
				[Address(RVA = "0xA44DBC", Offset = "0xA44DBC", VA = "0xA44DBC")]
				internal void _003COnEndpointLost_003Eb__0()
				{
				}
			}

			[Token(Token = "0x40033AD")]
			[FieldOffset(Offset = "0x10")]
			private readonly IDiscoveryListener mListener;

			[Token(Token = "0x6003DA5")]
			[Address(RVA = "0x91C3E0", Offset = "0x91C3E0", VA = "0x91C3E0")]
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			[Token(Token = "0x6003DA6")]
			[Address(RVA = "0x91C40C", Offset = "0x91C40C", VA = "0x91C40C", Slot = "4")]
			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			[Token(Token = "0x6003DA7")]
			[Address(RVA = "0x91C504", Offset = "0x91C504", VA = "0x91C504", Slot = "5")]
			public void OnEndpointLost(string lostEndpointId)
			{
			}
		}

		[Token(Token = "0x20009AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59752C", Offset = "0x59752C")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40033B2")]
			[FieldOffset(Offset = "0x10")]
			public TimeSpan? advertisingDuration;

			[Token(Token = "0x6003DAC")]
			[Address(RVA = "0x91ADEC", Offset = "0x91ADEC", VA = "0x91ADEC")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6003DAD")]
			[Address(RVA = "0x91ADF4", Offset = "0x91ADF4", VA = "0x91ADF4")]
			internal void _003CStartAdvertising_003Eb__0(AndroidJavaObject v)
			{
			}
		}

		[Token(Token = "0x20009AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59753C", Offset = "0x59753C")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40033B3")]
			[FieldOffset(Offset = "0x10")]
			public TimeSpan? advertisingDuration;

			[Token(Token = "0x6003DAE")]
			[Address(RVA = "0x91AE60", Offset = "0x91AE60", VA = "0x91AE60")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x91AE68", Offset = "0x91AE68", VA = "0x91AE68")]
			internal void _003CStartDiscovery_003Eb__0(AndroidJavaObject v)
			{
			}
		}

		[Token(Token = "0x20009AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59754C", Offset = "0x59754C")]
		private sealed class _003C_003Ec__DisplayClass31_0<T>
		{
			[Token(Token = "0x40033B4")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> toConvert;

			[Token(Token = "0x6003DB0")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6003DB1")]
			internal void _003CToOnGameThread_003Eb__0(T val)
			{
			}
		}

		[Token(Token = "0x20009AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59755C", Offset = "0x59755C")]
		private sealed class _003C_003Ec__DisplayClass31_1<T>
		{
			[Token(Token = "0x40033B5")]
			[FieldOffset(Offset = "0x0")]
			public T val;

			[Token(Token = "0x40033B6")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass31_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003DB2")]
			public _003C_003Ec__DisplayClass31_1()
			{
			}

			[Token(Token = "0x6003DB3")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20009AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59756C", Offset = "0x59756C")]
		private sealed class _003C_003Ec__DisplayClass32_0<T1, T2>
		{
			[Token(Token = "0x40033B7")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toConvert;

			[Token(Token = "0x6003DB4")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6003DB5")]
			internal void _003CToOnGameThread_003Eb__0(T1 val1, T2 val2)
			{
			}
		}

		[Token(Token = "0x20009B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59757C", Offset = "0x59757C")]
		private sealed class _003C_003Ec__DisplayClass32_1<T1, T2>
		{
			[Token(Token = "0x40033B8")]
			[FieldOffset(Offset = "0x0")]
			public T1 val1;

			[Token(Token = "0x40033B9")]
			[FieldOffset(Offset = "0x0")]
			public T2 val2;

			[Token(Token = "0x40033BA")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass32_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003DB6")]
			public _003C_003Ec__DisplayClass32_1()
			{
			}

			[Token(Token = "0x6003DB7")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mClient;

		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long NearbyClientId;

		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int ApplicationInfoFlags;

		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string ServiceId;

		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x18")]
		protected IMessageListener mAdvertisingMessageListener;

		[Token(Token = "0x6003D79")]
		[Address(RVA = "0xD6FB00", Offset = "0xD6FB00", VA = "0xD6FB00")]
		public AndroidNearbyConnectionClient()
		{
		}

		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0xD6FD9C", Offset = "0xD6FD9C", VA = "0xD6FD9C", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0xD6FDA4", Offset = "0xD6FDA4", VA = "0xD6FDA4", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0xD6FDAC", Offset = "0xD6FDAC", VA = "0xD6FDAC", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0xD70234", Offset = "0xD70234", VA = "0xD70234", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0xD6FDB0", Offset = "0xD6FDB0", VA = "0xD6FDB0")]
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0xD70238", Offset = "0xD70238", VA = "0xD70238", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6003D80")]
		[Address(RVA = "0xD70990", Offset = "0xD70990", VA = "0xD70990")]
		private AndroidJavaObject CreateAdvertisingOptions()
		{
			return null;
		}

		[Token(Token = "0x6003D81")]
		[Address(RVA = "0xD70EE4", Offset = "0xD70EE4", VA = "0xD70EE4", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x6003D82")]
		[Address(RVA = "0xD70FEC", Offset = "0xD70FEC", VA = "0xD70FEC", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x6003D83")]
		[Address(RVA = "0xD7141C", Offset = "0xD7141C", VA = "0xD7141C", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x6003D84")]
		[Address(RVA = "0xD717F8", Offset = "0xD717F8", VA = "0xD717F8", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingDuration, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x6003D85")]
		[Address(RVA = "0xD71E70", Offset = "0xD71E70", VA = "0xD71E70")]
		private AndroidJavaObject CreateDiscoveryOptions()
		{
			return null;
		}

		[Token(Token = "0x6003D86")]
		[Address(RVA = "0xD723C4", Offset = "0xD723C4", VA = "0xD723C4", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x6003D87")]
		[Address(RVA = "0xD724C4", Offset = "0xD724C4", VA = "0xD724C4", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x6003D88")]
		[Address(RVA = "0xD72670", Offset = "0xD72670", VA = "0xD72670", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6003D89")]
		[Address(RVA = "0xD72744", Offset = "0xD72744", VA = "0xD72744", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0xD7284C", Offset = "0xD7284C", VA = "0xD7284C", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0xD72A54", Offset = "0xD72A54", VA = "0xD72A54", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0xD72AB8", Offset = "0xD72AB8", VA = "0xD72AB8")]
		private static string ReadServiceId()
		{
			return null;
		}

		[Token(Token = "0x6003D8D")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Token(Token = "0x6003D8E")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
