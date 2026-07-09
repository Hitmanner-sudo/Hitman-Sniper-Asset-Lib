using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BF6")]
	public class Downloader
	{
		[Token(Token = "0x2000BF7")]
		public struct BundleCacheDebugData
		{
			[Token(Token = "0x4003BD8")]
			[FieldOffset(Offset = "0x0")]
			public bool CachedBefore;

			[Token(Token = "0x4003BD9")]
			[FieldOffset(Offset = "0x1")]
			public bool CachedAfter1;

			[Token(Token = "0x4003BDA")]
			[FieldOffset(Offset = "0x2")]
			public bool CachedAfter2;

			[Token(Token = "0x4003BDB")]
			[FieldOffset(Offset = "0x3")]
			public bool CachedAfter3;

			[Token(Token = "0x4003BDC")]
			[FieldOffset(Offset = "0x8")]
			public string Url;

			[Token(Token = "0x4003BDD")]
			[FieldOffset(Offset = "0x10")]
			public int Version;
		}

		[Token(Token = "0x2000BF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59851C", Offset = "0x59851C")]
		private sealed class _003CDownloadAsync_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003BDE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003BDF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003BE0")]
			[FieldOffset(Offset = "0x20")]
			public Bundle bundle;

			[Token(Token = "0x4003BE1")]
			[FieldOffset(Offset = "0x28")]
			public Downloader _003C_003E4__this;

			[Token(Token = "0x4003BE2")]
			[FieldOffset(Offset = "0x30")]
			private WWW _003Cwww_003E5__2;

			[Token(Token = "0x170009AB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004BD5")]
				[Address(RVA = "0x86C78C", Offset = "0x86C78C", VA = "0x86C78C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009AC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004BD7")]
				[Address(RVA = "0x86C7D4", Offset = "0x86C7D4", VA = "0x86C7D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004BD2")]
			[Address(RVA = "0x86C4A8", Offset = "0x86C4A8", VA = "0x86C4A8")]
			[DebuggerHidden]
			public _003CDownloadAsync_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004BD3")]
			[Address(RVA = "0x86C4D4", Offset = "0x86C4D4", VA = "0x86C4D4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004BD4")]
			[Address(RVA = "0x86C4D8", Offset = "0x86C4D8", VA = "0x86C4D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004BD6")]
			[Address(RVA = "0x86C794", Offset = "0x86C794", VA = "0x86C794", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x0")]
		public static bool ON_WIFI_ONLY;

		[Token(Token = "0x4003BD7")]
		public const string STATE_SUCCESS = "SUCCESS";

		[Token(Token = "0x170009AA")]
		public bool canDownload
		{
			[Token(Token = "0x6004BCA")]
			[Address(RVA = "0xC1EB80", Offset = "0xC1EB80", VA = "0xC1EB80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0xC1A7F8", Offset = "0xC1A7F8", VA = "0xC1A7F8")]
		public Downloader(bool l_clearCache)
		{
		}

		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0xC1A830", Offset = "0xC1A830", VA = "0xC1A830")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x628450", Offset = "0x628450")]
		public IEnumerator DownloadAsync(Bundle bundle)
		{
			return null;
		}

		[Token(Token = "0x6004BCD")]
		[Address(RVA = "0xC1EC20", Offset = "0xC1EC20", VA = "0xC1EC20")]
		private static WWW LoadBundle(Bundle bundle, string wwwurl)
		{
			return null;
		}

		[Token(Token = "0x6004BCE")]
		[Address(RVA = "0xC1A8A8", Offset = "0xC1A8A8", VA = "0xC1A8A8")]
		public void DownloadSync(Bundle bundle)
		{
		}

		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0xC1ED24", Offset = "0xC1ED24", VA = "0xC1ED24")]
		private bool OnDownloaded(Bundle bundle, WWW www)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0xC1EC00", Offset = "0xC1EC00", VA = "0xC1EC00")]
		private bool isWifiEnable()
		{
			return default(bool);
		}
	}
}
