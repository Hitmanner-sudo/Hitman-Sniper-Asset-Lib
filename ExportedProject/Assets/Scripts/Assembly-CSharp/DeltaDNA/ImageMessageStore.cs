using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace DeltaDNA
{
	[Token(Token = "0x200130C")]
	internal class ImageMessageStore
	{
		[Token(Token = "0x200130D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE82C", Offset = "0x5AE82C")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4005B4E")]
			[FieldOffset(Offset = "0x10")]
			public ImageMessageStore _003C_003E4__this;

			[Token(Token = "0x4005B4F")]
			[FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x4005B50")]
			[FieldOffset(Offset = "0x20")]
			public Action<Texture2D> onSuccess;

			[Token(Token = "0x6006FED")]
			[Address(RVA = "0xB2461C", Offset = "0xB2461C", VA = "0xB2461C")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6006FEE")]
			[Address(RVA = "0xB24624", Offset = "0xB24624", VA = "0xB24624")]
			internal void _003CGet_003Eb__0(string fileTempPath)
			{
			}
		}

		[Token(Token = "0x200130E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE83C", Offset = "0x5AE83C")]
		private sealed class _003CGet_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B51")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B52")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B53")]
			[FieldOffset(Offset = "0x20")]
			public ImageMessageStore _003C_003E4__this;

			[Token(Token = "0x4005B54")]
			[FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005B55")]
			[FieldOffset(Offset = "0x30")]
			public Action<Texture2D> onSuccess;

			[Token(Token = "0x4005B56")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> onError;

			[Token(Token = "0x17000CB8")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006FF2")]
				[Address(RVA = "0xB25010", Offset = "0xB25010", VA = "0xB25010", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB9")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006FF4")]
				[Address(RVA = "0xB25058", Offset = "0xB25058", VA = "0xB25058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006FEF")]
			[Address(RVA = "0xB24E0C", Offset = "0xB24E0C", VA = "0xB24E0C")]
			[DebuggerHidden]
			public _003CGet_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006FF0")]
			[Address(RVA = "0xB24E38", Offset = "0xB24E38", VA = "0xB24E38", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006FF1")]
			[Address(RVA = "0xB24E3C", Offset = "0xB24E3C", VA = "0xB24E3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006FF3")]
			[Address(RVA = "0xB25018", Offset = "0xB25018", VA = "0xB25018", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x200130F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE84C", Offset = "0x5AE84C")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x4005B57")]
			[FieldOffset(Offset = "0x10")]
			public int downloading;

			[Token(Token = "0x4005B58")]
			[FieldOffset(Offset = "0x14")]
			public int maxConcurrent;

			[Token(Token = "0x4005B59")]
			[FieldOffset(Offset = "0x18")]
			public ImageMessageStore _003C_003E4__this;

			[Token(Token = "0x4005B5A")]
			[FieldOffset(Offset = "0x20")]
			public int downloaded;

			[Token(Token = "0x4005B5B")]
			[FieldOffset(Offset = "0x28")]
			public string error;

			[Token(Token = "0x4005B5C")]
			[FieldOffset(Offset = "0x30")]
			public Func<bool> _003C_003E9__0;

			[Token(Token = "0x4005B5D")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> _003C_003E9__2;

			[Token(Token = "0x6006FF5")]
			[Address(RVA = "0xB24740", Offset = "0xB24740", VA = "0xB24740")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6006FF6")]
			[Address(RVA = "0xB24748", Offset = "0xB24748", VA = "0xB24748")]
			internal bool _003CPrefetch_003Eb__0()
			{
				return default(bool);
			}

			[Token(Token = "0x6006FF7")]
			[Address(RVA = "0xB24758", Offset = "0xB24758", VA = "0xB24758")]
			internal void _003CPrefetch_003Eb__2(string e)
			{
			}
		}

		[Token(Token = "0x2001310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE85C", Offset = "0x5AE85C")]
		private sealed class _003C_003Ec__DisplayClass6_1
		{
			[Token(Token = "0x4005B5E")]
			[FieldOffset(Offset = "0x10")]
			public string url;

			[Token(Token = "0x4005B5F")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6006FF8")]
			[Address(RVA = "0xB2476C", Offset = "0xB2476C", VA = "0xB2476C")]
			public _003C_003Ec__DisplayClass6_1()
			{
			}

			[Token(Token = "0x6006FF9")]
			[Address(RVA = "0xB24774", Offset = "0xB24774", VA = "0xB24774")]
			internal void _003CPrefetch_003Eb__1(string t)
			{
			}
		}

		[Token(Token = "0x2001311")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE86C", Offset = "0x5AE86C")]
		private sealed class _003CPrefetch_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B60")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B61")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B62")]
			[FieldOffset(Offset = "0x20")]
			public ImageMessageStore _003C_003E4__this;

			[Token(Token = "0x4005B63")]
			[FieldOffset(Offset = "0x28")]
			public string[] urls;

			[Token(Token = "0x4005B64")]
			[FieldOffset(Offset = "0x30")]
			public Action onSuccess;

			[Token(Token = "0x4005B65")]
			[FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

			[Token(Token = "0x4005B66")]
			[FieldOffset(Offset = "0x40")]
			private _003C_003Ec__DisplayClass6_1 _003C_003E8__2;

			[Token(Token = "0x4005B67")]
			[FieldOffset(Offset = "0x48")]
			public Action<string> onError;

			[Token(Token = "0x4005B68")]
			[FieldOffset(Offset = "0x50")]
			private string[] _003C_003E7__wrap1;

			[Token(Token = "0x4005B69")]
			[FieldOffset(Offset = "0x58")]
			private int _003C_003E7__wrap2;

			[Token(Token = "0x17000CBA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006FFD")]
				[Address(RVA = "0xB25600", Offset = "0xB25600", VA = "0xB25600", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CBB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006FFF")]
				[Address(RVA = "0xB25648", Offset = "0xB25648", VA = "0xB25648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006FFA")]
			[Address(RVA = "0xB25060", Offset = "0xB25060", VA = "0xB25060")]
			[DebuggerHidden]
			public _003CPrefetch_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006FFB")]
			[Address(RVA = "0xB2508C", Offset = "0xB2508C", VA = "0xB2508C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006FFC")]
			[Address(RVA = "0xB25090", Offset = "0xB25090", VA = "0xB25090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006FFE")]
			[Address(RVA = "0xB25608", Offset = "0xB25608", VA = "0xB25608", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2001312")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE87C", Offset = "0x5AE87C")]
		private sealed class _003CFetch_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B6A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B6B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B6C")]
			[FieldOffset(Offset = "0x20")]
			public ImageMessageStore _003C_003E4__this;

			[Token(Token = "0x4005B6D")]
			[FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005B6E")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> onError;

			[Token(Token = "0x4005B6F")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> onSuccess;

			[Token(Token = "0x4005B70")]
			[FieldOffset(Offset = "0x40")]
			private string _003CfilePathTmp_003E5__2;

			[Token(Token = "0x4005B71")]
			[FieldOffset(Offset = "0x48")]
			private DownloadHandlerFile _003CdownloadHandler_003E5__3;

			[Token(Token = "0x4005B72")]
			[FieldOffset(Offset = "0x50")]
			private UnityWebRequest _003Cwww_003E5__4;

			[Token(Token = "0x17000CBC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007005")]
				[Address(RVA = "0xB24DBC", Offset = "0xB24DBC", VA = "0xB24DBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CBD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007007")]
				[Address(RVA = "0xB24E04", Offset = "0xB24E04", VA = "0xB24E04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007000")]
			[Address(RVA = "0xB24808", Offset = "0xB24808", VA = "0xB24808")]
			[DebuggerHidden]
			public _003CFetch_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007001")]
			[Address(RVA = "0xB24834", Offset = "0xB24834", VA = "0xB24834", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007002")]
			[Address(RVA = "0xB24A3C", Offset = "0xB24A3C", VA = "0xB24A3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007003")]
			[Address(RVA = "0xB24980", Offset = "0xB24980", VA = "0xB24980")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6007004")]
			[Address(RVA = "0xB248C4", Offset = "0xB248C4", VA = "0xB248C4")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6007006")]
			[Address(RVA = "0xB24DC4", Offset = "0xB24DC4", VA = "0xB24DC4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005B4C")]
		[FieldOffset(Offset = "0x10")]
		private readonly string cache;

		[Token(Token = "0x4005B4D")]
		[FieldOffset(Offset = "0x18")]
		private readonly MonoBehaviour parent;

		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0xA18E7C", Offset = "0xA18E7C", VA = "0xA18E7C")]
		internal ImageMessageStore(MonoBehaviour parent)
		{
		}

		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0xA18FD8", Offset = "0xA18FD8", VA = "0xA18FD8", Slot = "4")]
		internal virtual bool Has(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0xA19098", Offset = "0xA19098", VA = "0xA19098")]
		internal Texture2D Get(string url)
		{
			return null;
		}

		[Token(Token = "0x6006FE7")]
		[Address(RVA = "0xA19174", Offset = "0xA19174", VA = "0xA19174")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CC80", Offset = "0x62CC80")]
		internal IEnumerator Get(string url, Action<Texture2D> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0xA19200", Offset = "0xA19200", VA = "0xA19200")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CCE0", Offset = "0x62CCE0")]
		internal IEnumerator Prefetch(Action onSuccess, Action<string> onError, params string[] urls)
		{
			return null;
		}

		[Token(Token = "0x6006FE9")]
		[Address(RVA = "0xA19290", Offset = "0xA19290", VA = "0xA19290")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0xA192D4", Offset = "0xA192D4", VA = "0xA192D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CD40", Offset = "0x62CD40")]
		private IEnumerator Fetch(string url, Action<string> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x6006FEB")]
		[Address(RVA = "0xA19010", Offset = "0xA19010", VA = "0xA19010")]
		private static string GetName(string url)
		{
			return null;
		}

		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0xA19360", Offset = "0xA19360", VA = "0xA19360")]
		private bool IsFull()
		{
			return default(bool);
		}
	}
}
