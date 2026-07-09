using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B2E")]
	internal class Packages : List<Package>
	{
		[Token(Token = "0x4003901")]
		[FieldOffset(Offset = "0x30")]
		internal List<Package> _defectivePackages;

		[Token(Token = "0x4003902")]
		[FieldOffset(Offset = "0x38")]
		private int _readyCount;

		[Token(Token = "0x4003903")]
		[FieldOffset(Offset = "0x40")]
		private readonly Transaction _transaction;

		[Token(Token = "0x170008E1")]
		internal Transaction Transaction
		{
			[Token(Token = "0x6004648")]
			[Address(RVA = "0x8F40CC", Offset = "0x8F40CC", VA = "0x8F40CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E2")]
		internal bool IsEmpty
		{
			[Token(Token = "0x6004649")]
			[Address(RVA = "0x8F40D4", Offset = "0x8F40D4", VA = "0x8F40D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170008E3")]
		internal bool ContainsADefectivePackage
		{
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x8F411C", Offset = "0x8F411C", VA = "0x8F411C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000DB")]
		internal event EventHandler<PackageEvent> OnShippingComplete
		{
			[Token(Token = "0x6004646")]
			[Address(RVA = "0x8F3F8C", Offset = "0x8F3F8C", VA = "0x8F3F8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626A08", Offset = "0x626A08")]
			add
			{
			}
			[Token(Token = "0x6004647")]
			[Address(RVA = "0x8F402C", Offset = "0x8F402C", VA = "0x8F402C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626A18", Offset = "0x626A18")]
			remove
			{
			}
		}

		[Token(Token = "0x600464B")]
		[Address(RVA = "0x8F4170", Offset = "0x8F4170", VA = "0x8F4170")]
		private Packages()
		{
		}

		[Token(Token = "0x600464C")]
		[Address(RVA = "0x8F41E8", Offset = "0x8F41E8", VA = "0x8F41E8")]
		internal Packages(Transaction transaction)
		{
		}

		[Token(Token = "0x600464D")]
		[Address(RVA = "0x8F42A8", Offset = "0x8F42A8", VA = "0x8F42A8")]
		internal bool AddPackage(Package package)
		{
			return default(bool);
		}

		[Token(Token = "0x600464E")]
		[Address(RVA = "0x8F4378", Offset = "0x8F4378", VA = "0x8F4378")]
		internal void Receive()
		{
		}

		[Token(Token = "0x600464F")]
		[Address(RVA = "0x8F4408", Offset = "0x8F4408", VA = "0x8F4408")]
		private void OnPackagingCompleteHandler(object sender, PackageEvent packageEvent)
		{
		}

		[Token(Token = "0x6004650")]
		[Address(RVA = "0x8F453C", Offset = "0x8F453C", VA = "0x8F453C")]
		private void TriggerEvent()
		{
		}

		[Token(Token = "0x6004651")]
		[Address(RVA = "0x8F4680", Offset = "0x8F4680", VA = "0x8F4680")]
		internal void UnpackAndShowAll()
		{
		}
	}
}
