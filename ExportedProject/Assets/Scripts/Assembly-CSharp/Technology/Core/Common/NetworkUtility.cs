using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.Profiling;
using Technology.Core.ServiceOperations;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DF1")]
	public static class NetworkUtility
	{
		[Token(Token = "0x2000DF2")]
		public delegate void ConnectionState(bool state);

		[Token(Token = "0x2000DF3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598AEC", Offset = "0x598AEC")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x400422E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> subscriberAction;

			[Token(Token = "0x60055E0")]
			[Address(RVA = "0x8CA2EC", Offset = "0x8CA2EC", VA = "0x8CA2EC")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60055E1")]
			[Address(RVA = "0x8CA2F4", Offset = "0x8CA2F4", VA = "0x8CA2F4")]
			internal void _003CRunInternetReachableTest_003Eb__0(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x2000DF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598AFC", Offset = "0x598AFC")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400422F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> subscriberAction;

			[Token(Token = "0x60055E2")]
			[Address(RVA = "0x8CA3E4", Offset = "0x8CA3E4", VA = "0x8CA3E4")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60055E3")]
			[Address(RVA = "0x8CA3EC", Offset = "0x8CA3EC", VA = "0x8CA3EC")]
			internal void _003CRunWifiTest_003Eb__0(bool reachable)
			{
			}
		}

		[Token(Token = "0x2000DF5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598B0C", Offset = "0x598B0C")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4004230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NetworkRequest request;

			[Token(Token = "0x4004231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WWW www;

			[Token(Token = "0x4004232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<NetworkResponse> _003C_003E9__1;

			[Token(Token = "0x60055E4")]
			[Address(RVA = "0x8C9FBC", Offset = "0x8C9FBC", VA = "0x8C9FBC")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60055E5")]
			[Address(RVA = "0x8C9FC4", Offset = "0x8C9FC4", VA = "0x8C9FC4")]
			internal void _003CDownloadExecute_003Eb__0(bool isAvailable)
			{
			}

			[Token(Token = "0x60055E6")]
			[Address(RVA = "0x8CA248", Offset = "0x8CA248", VA = "0x8CA248")]
			internal void _003CDownloadExecute_003Eb__1(NetworkResponse r)
			{
			}
		}

		[Token(Token = "0x2000DF6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598B1C", Offset = "0x598B1C")]
		private sealed class _003CDownloadExecute_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4004233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4004234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4004235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NetworkRequest request;

			[Token(Token = "0x4004236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			[Token(Token = "0x4004237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ScopeProfiler _003Cp_003E5__2;

			[Token(Token = "0x17000B69")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60055EB")]
				[Address(RVA = "0x8CAC18", Offset = "0x8CAC18", VA = "0x8CAC18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B6A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60055ED")]
				[Address(RVA = "0x8CAC60", Offset = "0x8CAC60", VA = "0x8CAC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60055E7")]
			[Address(RVA = "0x8CA4F4", Offset = "0x8CA4F4", VA = "0x8CA4F4")]
			[DebuggerHidden]
			public _003CDownloadExecute_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055E8")]
			[Address(RVA = "0x8CA520", Offset = "0x8CA520", VA = "0x8CA520", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60055E9")]
			[Address(RVA = "0x8CA5F8", Offset = "0x8CA5F8", VA = "0x8CA5F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60055EA")]
			[Address(RVA = "0x8CA53C", Offset = "0x8CA53C", VA = "0x8CA53C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60055EC")]
			[Address(RVA = "0x8CAC20", Offset = "0x8CAC20", VA = "0x8CAC20", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400422B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int UpdateIntervalSeconds;

		[Token(Token = "0x1400016C")]
		public static event EventHandler<NetworkEvent> OnInternetReachable
		{
			[Token(Token = "0x60055D1")]
			[Address(RVA = "0xC5C6E8", Offset = "0xC5C6E8", VA = "0xC5C6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B010", Offset = "0x62B010")]
			add
			{
			}
			[Token(Token = "0x60055D2")]
			[Address(RVA = "0xC5C7E0", Offset = "0xC5C7E0", VA = "0xC5C7E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B020", Offset = "0x62B020")]
			remove
			{
			}
		}

		[Token(Token = "0x1400016D")]
		public static event EventHandler<NetworkEvent> OnInternetWifiReachable
		{
			[Token(Token = "0x60055D3")]
			[Address(RVA = "0xC5C8D8", Offset = "0xC5C8D8", VA = "0xC5C8D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B030", Offset = "0x62B030")]
			add
			{
			}
			[Token(Token = "0x60055D4")]
			[Address(RVA = "0xC5C9D0", Offset = "0xC5C9D0", VA = "0xC5C9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B040", Offset = "0x62B040")]
			remove
			{
			}
		}

		[Token(Token = "0x60055D5")]
		[Address(RVA = "0xC5CAC8", Offset = "0xC5CAC8", VA = "0xC5CAC8")]
		public static void RunInternetReachableTest([Optional] Action<bool> subscriberAction)
		{
		}

		[Token(Token = "0x60055D6")]
		[Address(RVA = "0xC5CC58", Offset = "0xC5CC58", VA = "0xC5CC58")]
		public static void RunWifiTest([Optional] Action<bool> subscriberAction)
		{
		}

		[Token(Token = "0x60055D7")]
		[Address(RVA = "0xC5CD44", Offset = "0xC5CD44", VA = "0xC5CD44")]
		public static void Download(NetworkRequest request)
		{
		}

		[Token(Token = "0x60055D8")]
		[Address(RVA = "0xC5CE0C", Offset = "0xC5CE0C", VA = "0xC5CE0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62B050", Offset = "0x62B050")]
		private static IEnumerator DownloadExecute(NetworkRequest request)
		{
			return null;
		}

		[Token(Token = "0x60055D9")]
		[Address(RVA = "0xC5CE78", Offset = "0xC5CE78", VA = "0xC5CE78")]
		private static void WriteToCache(NetworkResponse r)
		{
		}

		[Token(Token = "0x60055DA")]
		[Address(RVA = "0xC5D104", Offset = "0xC5D104", VA = "0xC5D104")]
		private static string ReadFromCache(NetworkRequest r)
		{
			return null;
		}
	}
}
