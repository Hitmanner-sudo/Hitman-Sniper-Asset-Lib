using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BF3")]
	public class Download : Singleton<Download>
	{
		[Token(Token = "0x2000BF4")]
		private class BundleDownloadMeta
		{
			[Token(Token = "0x4003BD2")]
			[FieldOffset(Offset = "0x10")]
			public Bundle Bundle;

			[Token(Token = "0x4003BD3")]
			[FieldOffset(Offset = "0x18")]
			public int Timeout;

			[Token(Token = "0x4003BD4")]
			[FieldOffset(Offset = "0x20")]
			public DateTime StartTime;

			[Token(Token = "0x6004BC8")]
			[Address(RVA = "0x86BCA4", Offset = "0x86BCA4", VA = "0x86BCA4")]
			public BundleDownloadMeta()
			{
			}
		}

		[Token(Token = "0x4003BCC")]
		[FieldOffset(Offset = "0x28")]
		public bool ClearCache;

		[Token(Token = "0x4003BCD")]
		[FieldOffset(Offset = "0x2C")]
		public int CacheSizeInMB;

		[Token(Token = "0x4003BCE")]
		[FieldOffset(Offset = "0x30")]
		public int CacheExpirationInDays;

		[Token(Token = "0x4003BCF")]
		[FieldOffset(Offset = "0x38")]
		private Downloader _downloader;

		[Token(Token = "0x4003BD0")]
		[FieldOffset(Offset = "0x40")]
		private List<BundleDownloadMeta> _timeoutList;

		[Token(Token = "0x4003BD1")]
		[FieldOffset(Offset = "0x48")]
		private List<BundleDownloadMeta> _entriesToRemove;

		[Token(Token = "0x170009A7")]
		public bool IsEventOnErrorDefined
		{
			[Token(Token = "0x6004BBB")]
			[Address(RVA = "0xC19B10", Offset = "0xC19B10", VA = "0xC19B10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009A8")]
		public bool IsEventOnDownloadDefined
		{
			[Token(Token = "0x6004BBC")]
			[Address(RVA = "0xC19B20", Offset = "0xC19B20", VA = "0xC19B20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009A9")]
		public bool IsEventTimeOutDefined
		{
			[Token(Token = "0x6004BBD")]
			[Address(RVA = "0xC19B30", Offset = "0xC19B30", VA = "0xC19B30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400012E")]
		public event DownloadEventHandler OnDownloaded
		{
			[Token(Token = "0x6004BB5")]
			[Address(RVA = "0xC19750", Offset = "0xC19750", VA = "0xC19750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6283F0", Offset = "0x6283F0")]
			add
			{
			}
			[Token(Token = "0x6004BB6")]
			[Address(RVA = "0xC197F0", Offset = "0xC197F0", VA = "0xC197F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628400", Offset = "0x628400")]
			remove
			{
			}
		}

		[Token(Token = "0x1400012F")]
		public event DownloadEventHandler OnError
		{
			[Token(Token = "0x6004BB7")]
			[Address(RVA = "0xC19890", Offset = "0xC19890", VA = "0xC19890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628410", Offset = "0x628410")]
			add
			{
			}
			[Token(Token = "0x6004BB8")]
			[Address(RVA = "0xC19930", Offset = "0xC19930", VA = "0xC19930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628420", Offset = "0x628420")]
			remove
			{
			}
		}

		[Token(Token = "0x14000130")]
		public event DownloadEventHandler OnTimeOut
		{
			[Token(Token = "0x6004BB9")]
			[Address(RVA = "0xC199D0", Offset = "0xC199D0", VA = "0xC199D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628430", Offset = "0x628430")]
			add
			{
			}
			[Token(Token = "0x6004BBA")]
			[Address(RVA = "0xC19A70", Offset = "0xC19A70", VA = "0xC19A70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628440", Offset = "0x628440")]
			remove
			{
			}
		}

		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0xC19B40", Offset = "0xC19B40", VA = "0xC19B40")]
		public static Bundle Load(Bundle bundle, ThreadPriority threadPriority, bool isAsync = false)
		{
			return null;
		}

		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0xC19D0C", Offset = "0xC19D0C", VA = "0xC19D0C")]
		public Download()
		{
		}

		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0xC19BE8", Offset = "0xC19BE8", VA = "0xC19BE8")]
		public void StartDownload(Bundle bundle, ThreadPriority threadPriority, bool async = true, int timeout = 30000)
		{
		}

		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0xC1A0B4", Offset = "0xC1A0B4", VA = "0xC1A0B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0xC1A724", Offset = "0xC1A724", VA = "0xC1A724")]
		private void Init()
		{
		}

		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0xC19FA0", Offset = "0xC19FA0", VA = "0xC19FA0")]
		private void Get(Bundle bundle, bool async = true)
		{
		}

		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0xC19ECC", Offset = "0xC19ECC", VA = "0xC19ECC")]
		private void AddEventHandlers(Bundle bundle)
		{
		}

		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0xC1A2CC", Offset = "0xC1A2CC", VA = "0xC1A2CC")]
		private void RemoveEventHandlers(Bundle bundle)
		{
		}

		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0xC1AA70", Offset = "0xC1AA70", VA = "0xC1AA70")]
		public void OnRequestComplete(Bundle bundle)
		{
		}

		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0xC1AAAC", Offset = "0xC1AAAC", VA = "0xC1AAAC")]
		public void OnRequestFailure(Bundle bundle)
		{
		}
	}
}
