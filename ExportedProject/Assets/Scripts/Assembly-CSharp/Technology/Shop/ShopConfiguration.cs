using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000B38")]
	public class ShopConfiguration : ScriptableObject, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCD28", Offset = "0x5BCD28")]
		public string GoogleBillingPublicKey;

		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCD60", Offset = "0x5BCD60")]
		[HideInInspector]
		public List<Consumable> Consumables;

		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCDAC", Offset = "0x5BCDAC")]
		public List<NonConsumable> Nonconsumables;

		[Token(Token = "0x4003933")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCDF8", Offset = "0x5BCDF8")]
		[HideInInspector]
		public List<Membership> Memberships;

		[Token(Token = "0x4003934")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCE44", Offset = "0x5BCE44")]
		[HideInInspector]
		public List<OfferDescription> OfferDescriptions;

		[Token(Token = "0x4003935")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCE90", Offset = "0x5BCE90")]
		public List<Credit> InventoryStartingBalances;

		[Token(Token = "0x4003936")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCEC8", Offset = "0x5BCEC8")]
		public List<OfferDescription> AllIntelUnlockWeapons;

		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCF14", Offset = "0x5BCF14")]
		[HideInInspector]
		public bool ClearCache;

		[Token(Token = "0x4003938")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BCF60", Offset = "0x5BCF60")]
		[HideInInspector]
		public string GUID;

		[Token(Token = "0x4003939")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCFAC", Offset = "0x5BCFAC")]
		private bool _003CIsUpdated_003Ek__BackingField;

		[Token(Token = "0x400393A")]
		[FieldOffset(Offset = "0x68")]
		private List<Item> _items;

		[NonSerialized]
		[Token(Token = "0x400393B")]
		[FieldOffset(Offset = "0x70")]
		public bool isItemsDirty;

		[Token(Token = "0x170008F1")]
		public bool IsUpdated
		{
			[Token(Token = "0x60046DA")]
			[Address(RVA = "0x8443F4", Offset = "0x8443F4", VA = "0x8443F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CB8", Offset = "0x626CB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046DB")]
			[Address(RVA = "0x8443FC", Offset = "0x8443FC", VA = "0x8443FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CC8", Offset = "0x626CC8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170008F2")]
		public string SavedGUID
		{
			[Token(Token = "0x60046DC")]
			[Address(RVA = "0x83F794", Offset = "0x83F794", VA = "0x83F794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F3")]
		public List<Item> Items
		{
			[Token(Token = "0x60046DE")]
			[Address(RVA = "0x844408", Offset = "0x844408", VA = "0x844408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x83FBEC", Offset = "0x83FBEC", VA = "0x83FBEC")]
		public void SaveGUID()
		{
		}

		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x8446FC", Offset = "0x8446FC", VA = "0x8446FC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x8447AC", Offset = "0x8447AC", VA = "0x8447AC", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x8447B0", Offset = "0x8447B0", VA = "0x8447B0")]
		public ShopConfiguration()
		{
		}
	}
}
