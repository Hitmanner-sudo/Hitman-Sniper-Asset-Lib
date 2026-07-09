using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000AFC")]
	public class DynamicLoader
	{
		[Token(Token = "0x2000AFD")]
		public class CachedData
		{
			[Token(Token = "0x4003831")]
			[FieldOffset(Offset = "0x10")]
			public WWW www;

			[Token(Token = "0x4003832")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object[] objs;

			[Token(Token = "0x4003833")]
			[FieldOffset(Offset = "0x20")]
			public readonly List<DynamicLoader> pendingUsers;

			[Token(Token = "0x600448E")]
			[Address(RVA = "0x86CF50", Offset = "0x86CF50", VA = "0x86CF50")]
			public CachedData()
			{
			}
		}

		[Token(Token = "0x2000AFE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E68", Offset = "0x597E68")]
		private sealed class _003CDownload_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003834")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003835")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003836")]
			[FieldOffset(Offset = "0x20")]
			public CachedData cachedData;

			[Token(Token = "0x4003837")]
			[FieldOffset(Offset = "0x28")]
			public string uri;

			[Token(Token = "0x170008A2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004492")]
				[Address(RVA = "0x86CF00", Offset = "0x86CF00", VA = "0x86CF00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008A3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004494")]
				[Address(RVA = "0x86CF48", Offset = "0x86CF48", VA = "0x86CF48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600448F")]
			[Address(RVA = "0x86CAA4", Offset = "0x86CAA4", VA = "0x86CAA4")]
			[DebuggerHidden]
			public _003CDownload_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004490")]
			[Address(RVA = "0x86CAD0", Offset = "0x86CAD0", VA = "0x86CAD0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004491")]
			[Address(RVA = "0x86CAD4", Offset = "0x86CAD4", VA = "0x86CAD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004493")]
			[Address(RVA = "0x86CF08", Offset = "0x86CF08", VA = "0x86CF08", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400382E")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, CachedData> _loaderCache;

		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x8")]
		private static bool _keepCache;

		[Token(Token = "0x170008A1")]
		public static bool KeepCache
		{
			[Token(Token = "0x6004483")]
			[Address(RVA = "0xC21E70", Offset = "0xC21E70", VA = "0xC21E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004484")]
			[Address(RVA = "0xC1C8C0", Offset = "0xC1C8C0", VA = "0xC1C8C0")]
			set
			{
			}
		}

		[Token(Token = "0x140000C5")]
		public event EventHandler<DynamicLoaderEvent> OnDownloadComplete
		{
			[Token(Token = "0x6004485")]
			[Address(RVA = "0xC21FF0", Offset = "0xC21FF0", VA = "0xC21FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626128", Offset = "0x626128")]
			add
			{
			}
			[Token(Token = "0x6004486")]
			[Address(RVA = "0xC22090", Offset = "0xC22090", VA = "0xC22090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626138", Offset = "0x626138")]
			remove
			{
			}
		}

		[Token(Token = "0x6004487")]
		[Address(RVA = "0xC22130", Offset = "0xC22130", VA = "0xC22130")]
		internal DynamicLoader()
		{
		}

		[Token(Token = "0x6004488")]
		[Address(RVA = "0xC22138", Offset = "0xC22138", VA = "0xC22138")]
		public void Download(string contentUri)
		{
		}

		[Token(Token = "0x6004489")]
		[Address(RVA = "0xC22638", Offset = "0xC22638", VA = "0xC22638")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626148", Offset = "0x626148")]
		private static IEnumerator Download(CachedData cachedData, string uri)
		{
			return null;
		}

		[Token(Token = "0x600448A")]
		[Address(RVA = "0xC226B0", Offset = "0xC226B0", VA = "0xC226B0")]
		private static void DisposeLoader(string URI)
		{
		}

		[Token(Token = "0x600448B")]
		[Address(RVA = "0xC21ED4", Offset = "0xC21ED4", VA = "0xC21ED4")]
		private static void DisposeAllCompletedLoaders()
		{
		}

		[Token(Token = "0x600448C")]
		[Address(RVA = "0xC227E8", Offset = "0xC227E8", VA = "0xC227E8")]
		public static bool InstantiateAll(UnityEngine.Object[] objects)
		{
			return default(bool);
		}
	}
}
