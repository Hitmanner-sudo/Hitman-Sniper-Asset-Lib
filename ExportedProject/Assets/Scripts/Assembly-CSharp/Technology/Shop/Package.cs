using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000B2D")]
	internal class Package
	{
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCBD8", Offset = "0x5BCBD8")]
		private string _003CItemId_003Ek__BackingField;

		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCBE8", Offset = "0x5BCBE8")]
		private bool _003CIsDefective_003Ek__BackingField;

		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCBF8", Offset = "0x5BCBF8")]
		private bool _003CIsReady_003Ek__BackingField;

		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCC08", Offset = "0x5BCC08")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0x28")]
		private readonly string _uri;

		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0x30")]
		private readonly DynamicLoader _loader;

		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0x38")]
		private UnityEngine.Object[] _objects;

		[Token(Token = "0x170008DB")]
		internal string ItemId
		{
			[Token(Token = "0x6004638")]
			[Address(RVA = "0x8F3A04", Offset = "0x8F3A04", VA = "0x8F3A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626988", Offset = "0x626988")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004639")]
			[Address(RVA = "0x8F3A0C", Offset = "0x8F3A0C", VA = "0x8F3A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626998", Offset = "0x626998")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DC")]
		internal bool IsDefective
		{
			[Token(Token = "0x600463A")]
			[Address(RVA = "0x8F3A14", Offset = "0x8F3A14", VA = "0x8F3A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269A8", Offset = "0x6269A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600463B")]
			[Address(RVA = "0x8F3A1C", Offset = "0x8F3A1C", VA = "0x8F3A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269B8", Offset = "0x6269B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DD")]
		internal bool IsReady
		{
			[Token(Token = "0x600463C")]
			[Address(RVA = "0x8F3A28", Offset = "0x8F3A28", VA = "0x8F3A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269C8", Offset = "0x6269C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600463D")]
			[Address(RVA = "0x8F3A30", Offset = "0x8F3A30", VA = "0x8F3A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269D8", Offset = "0x6269D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DE")]
		internal bool IsInProgress
		{
			[Token(Token = "0x600463E")]
			[Address(RVA = "0x8F3A3C", Offset = "0x8F3A3C", VA = "0x8F3A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269E8", Offset = "0x6269E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600463F")]
			[Address(RVA = "0x8F3A44", Offset = "0x8F3A44", VA = "0x8F3A44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6269F8", Offset = "0x6269F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DF")]
		internal string URI
		{
			[Token(Token = "0x6004640")]
			[Address(RVA = "0x8F3A50", Offset = "0x8F3A50", VA = "0x8F3A50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E0")]
		internal UnityEngine.Object[] Objects
		{
			[Token(Token = "0x6004641")]
			[Address(RVA = "0x8F3A58", Offset = "0x8F3A58", VA = "0x8F3A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000DA")]
		internal event EventHandler<PackageEvent> OnPackagingComplete
		{
			[Token(Token = "0x6004636")]
			[Address(RVA = "0x8F38C4", Offset = "0x8F38C4", VA = "0x8F38C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626968", Offset = "0x626968")]
			add
			{
			}
			[Token(Token = "0x6004637")]
			[Address(RVA = "0x8F3964", Offset = "0x8F3964", VA = "0x8F3964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626978", Offset = "0x626978")]
			remove
			{
			}
		}

		[Token(Token = "0x6004642")]
		[Address(RVA = "0x8F3A60", Offset = "0x8F3A60", VA = "0x8F3A60")]
		internal Package(string itemId, string uri)
		{
		}

		[Token(Token = "0x6004643")]
		[Address(RVA = "0x8F3B10", Offset = "0x8F3B10", VA = "0x8F3B10")]
		internal void Receive()
		{
		}

		[Token(Token = "0x6004644")]
		[Address(RVA = "0x8F3C64", Offset = "0x8F3C64", VA = "0x8F3C64")]
		private void OnDownloadCompleteHandler(object sender, DynamicLoaderEvent dynamicLoaderEvent)
		{
		}

		[Token(Token = "0x6004645")]
		[Address(RVA = "0x8F3E78", Offset = "0x8F3E78", VA = "0x8F3E78")]
		internal void Show()
		{
		}
	}
}
