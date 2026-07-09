using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B74")]
	public class ItemData : BaseShopData
	{
		[Token(Token = "0x2000B75")]
		public delegate void ItemDataHandler(ItemData data);

		[Token(Token = "0x2000B76")]
		public delegate void ItemDataListHandler(List<ItemData> list);

		[Token(Token = "0x2000B77")]
		public delegate void SegmentOverrideHandler(ItemData data, SegmentOverride segment);

		[Serializable]
		[Token(Token = "0x2000B78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981D0", Offset = "0x5981D0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003A4C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003A4D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<DateTime, string> _003C_003E9__55_0;

			[Token(Token = "0x60048D7")]
			[Address(RVA = "0xB28048", Offset = "0xB28048", VA = "0xB28048")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60048D8")]
			[Address(RVA = "0xB28050", Offset = "0xB28050", VA = "0xB28050")]
			internal string _003CToJSON_003Eb__55_0(DateTime d)
			{
				return null;
			}
		}

		[Token(Token = "0x2000B79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981E0", Offset = "0x5981E0")]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			[Token(Token = "0x4003A4E")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetItemOffersRaw svcOpC;

			[Token(Token = "0x4003A4F")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemData> offerList;

			[Token(Token = "0x60048D9")]
			[Address(RVA = "0xB280BC", Offset = "0xB280BC", VA = "0xB280BC")]
			public _003C_003Ec__DisplayClass57_0()
			{
			}

			[Token(Token = "0x60048DA")]
			[Address(RVA = "0xB280C4", Offset = "0xB280C4", VA = "0xB280C4")]
			internal void _003CGetOfferList_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B7A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981F0", Offset = "0x5981F0")]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			[Token(Token = "0x4003A50")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpCreateItemOffer svcOpC;

			[Token(Token = "0x4003A51")]
			[FieldOffset(Offset = "0x18")]
			public ItemData _003C_003E4__this;

			[Token(Token = "0x60048DB")]
			[Address(RVA = "0xB286D4", Offset = "0xB286D4", VA = "0xB286D4")]
			public _003C_003Ec__DisplayClass59_0()
			{
			}

			[Token(Token = "0x60048DC")]
			[Address(RVA = "0xB286DC", Offset = "0xB286DC", VA = "0xB286DC")]
			internal void _003CCreate_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B7B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598200", Offset = "0x598200")]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			[Token(Token = "0x4003A52")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpUpdateItemOffer svcOpC;

			[Token(Token = "0x4003A53")]
			[FieldOffset(Offset = "0x18")]
			public ItemData _003C_003E4__this;

			[Token(Token = "0x60048DD")]
			[Address(RVA = "0xB288A4", Offset = "0xB288A4", VA = "0xB288A4")]
			public _003C_003Ec__DisplayClass60_0()
			{
			}

			[Token(Token = "0x60048DE")]
			[Address(RVA = "0xB288AC", Offset = "0xB288AC", VA = "0xB288AC")]
			internal void _003CUpdate_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598210", Offset = "0x598210")]
		private sealed class _003C_003Ec__DisplayClass61_0
		{
			[Token(Token = "0x4003A54")]
			[FieldOffset(Offset = "0x10")]
			public SvcIOpDeleteItemOffer svcOpC;

			[Token(Token = "0x4003A55")]
			[FieldOffset(Offset = "0x18")]
			public ItemData _003C_003E4__this;

			[Token(Token = "0x60048DF")]
			[Address(RVA = "0xB28A2C", Offset = "0xB28A2C", VA = "0xB28A2C")]
			public _003C_003Ec__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60048E0")]
			[Address(RVA = "0xB28A34", Offset = "0xB28A34", VA = "0xB28A34")]
			internal void _003CDelete_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x80")]
		public long BloodMoney;

		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x88")]
		public long Bonds;

		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x90")]
		public string ReplaceOfferId;

		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x98")]
		public string SortingCategory;

		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0xA0")]
		public string BundleURL;

		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0xA8")]
		public bool Deployed;

		[Token(Token = "0x4003A42")]
		[FieldOffset(Offset = "0xB0")]
		public DateTime DateEffective;

		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0xB8")]
		public DateTime DateExpiry;

		[Token(Token = "0x4003A44")]
		[FieldOffset(Offset = "0xC0")]
		public bool IsRegistered;

		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0xC8")]
		public string ShopOwner;

		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0xD0")]
		public DateTime SaleEffective;

		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0xD8")]
		public DateTime SaleExpiry;

		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0xE0")]
		public float SaleDiscount;

		[Token(Token = "0x4003A49")]
		[FieldOffset(Offset = "0xE8")]
		public List<ItemTemplateSettings> TemplateList;

		[Token(Token = "0x4003A4A")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<LanguageCode, LocalizationEntry> LocaInfos;

		[Token(Token = "0x4003A4B")]
		[FieldOffset(Offset = "0xF8")]
		public List<SegmentOverride> SegmentsOverrideList;

		[Token(Token = "0x1700092D")]
		public override string ObjectName
		{
			[Token(Token = "0x60048B4")]
			[Address(RVA = "0x10C1764", Offset = "0x10C1764", VA = "0x10C1764", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092E")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x60048B5")]
			[Address(RVA = "0x10C17A8", Offset = "0x10C17A8", VA = "0x10C17A8", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000FC")]
		public event ItemDataHandler OnCreate
		{
			[Token(Token = "0x600489F")]
			[Address(RVA = "0x10C010C", Offset = "0x10C010C", VA = "0x10C010C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6272F0", Offset = "0x6272F0")]
			add
			{
			}
			[Token(Token = "0x60048A0")]
			[Address(RVA = "0x10C01AC", Offset = "0x10C01AC", VA = "0x10C01AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627300", Offset = "0x627300")]
			remove
			{
			}
		}

		[Token(Token = "0x140000FD")]
		public event ItemDataHandler OnUpdate
		{
			[Token(Token = "0x60048A1")]
			[Address(RVA = "0x10C024C", Offset = "0x10C024C", VA = "0x10C024C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627310", Offset = "0x627310")]
			add
			{
			}
			[Token(Token = "0x60048A2")]
			[Address(RVA = "0x10C02EC", Offset = "0x10C02EC", VA = "0x10C02EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627320", Offset = "0x627320")]
			remove
			{
			}
		}

		[Token(Token = "0x140000FE")]
		public event ItemDataHandler OnDelete
		{
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x10C038C", Offset = "0x10C038C", VA = "0x10C038C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627330", Offset = "0x627330")]
			add
			{
			}
			[Token(Token = "0x60048A4")]
			[Address(RVA = "0x10C042C", Offset = "0x10C042C", VA = "0x10C042C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627340", Offset = "0x627340")]
			remove
			{
			}
		}

		[Token(Token = "0x140000FF")]
		public event ItemDataHandler OnError
		{
			[Token(Token = "0x60048A5")]
			[Address(RVA = "0x10C04CC", Offset = "0x10C04CC", VA = "0x10C04CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627350", Offset = "0x627350")]
			add
			{
			}
			[Token(Token = "0x60048A6")]
			[Address(RVA = "0x10C056C", Offset = "0x10C056C", VA = "0x10C056C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627360", Offset = "0x627360")]
			remove
			{
			}
		}

		[Token(Token = "0x14000100")]
		public static event ItemDataListHandler OnGetOfferList
		{
			[Token(Token = "0x60048A7")]
			[Address(RVA = "0x10C060C", Offset = "0x10C060C", VA = "0x10C060C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627370", Offset = "0x627370")]
			add
			{
			}
			[Token(Token = "0x60048A8")]
			[Address(RVA = "0x10C06C8", Offset = "0x10C06C8", VA = "0x10C06C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627380", Offset = "0x627380")]
			remove
			{
			}
		}

		[Token(Token = "0x14000101")]
		public event SegmentOverrideHandler OnCreateSegment
		{
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x10C0784", Offset = "0x10C0784", VA = "0x10C0784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627390", Offset = "0x627390")]
			add
			{
			}
			[Token(Token = "0x60048AA")]
			[Address(RVA = "0x10C0824", Offset = "0x10C0824", VA = "0x10C0824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273A0", Offset = "0x6273A0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000102")]
		public event SegmentOverrideHandler OnUpdateSegment
		{
			[Token(Token = "0x60048AB")]
			[Address(RVA = "0x10C08C4", Offset = "0x10C08C4", VA = "0x10C08C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273B0", Offset = "0x6273B0")]
			add
			{
			}
			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x10C0964", Offset = "0x10C0964", VA = "0x10C0964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273C0", Offset = "0x6273C0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000103")]
		public event SegmentOverrideHandler OnDeleteSegment
		{
			[Token(Token = "0x60048AD")]
			[Address(RVA = "0x10C0A04", Offset = "0x10C0A04", VA = "0x10C0A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273D0", Offset = "0x6273D0")]
			add
			{
			}
			[Token(Token = "0x60048AE")]
			[Address(RVA = "0x10C0AA4", Offset = "0x10C0AA4", VA = "0x10C0AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273E0", Offset = "0x6273E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000104")]
		public event SegmentOverrideHandler OnErrorSegment
		{
			[Token(Token = "0x60048AF")]
			[Address(RVA = "0x10C0B44", Offset = "0x10C0B44", VA = "0x10C0B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273F0", Offset = "0x6273F0")]
			add
			{
			}
			[Token(Token = "0x60048B0")]
			[Address(RVA = "0x10C0BE4", Offset = "0x10C0BE4", VA = "0x10C0BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627400", Offset = "0x627400")]
			remove
			{
			}
		}

		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x10C0C84", Offset = "0x10C0C84", VA = "0x10C0C84")]
		public ItemData()
		{
		}

		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x10C0D7C", Offset = "0x10C0D7C", VA = "0x10C0D7C")]
		public ItemData(ItemData obj)
		{
		}

		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x10C144C", Offset = "0x10C144C", VA = "0x10C144C", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x10C1B0C", Offset = "0x10C1B0C", VA = "0x10C1B0C", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x10C2564", Offset = "0x10C2564", VA = "0x10C2564")]
		private void SetTemplatesFromJSON(JSONNode templatesNode)
		{
		}

		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x10C2A3C", Offset = "0x10C2A3C", VA = "0x10C2A3C", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x10C2940", Offset = "0x10C2940", VA = "0x10C2940")]
		public string GetEnglishName()
		{
			return null;
		}

		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x10C45E4", Offset = "0x10C45E4", VA = "0x10C45E4")]
		public static void GetOfferList()
		{
		}

		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x10C4734", Offset = "0x10C4734", VA = "0x10C4734")]
		private SegmentOverride GetSegmentOverrideByName(string name)
		{
			return null;
		}

		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x10C481C", Offset = "0x10C481C", VA = "0x10C481C", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x10C4950", Offset = "0x10C4950", VA = "0x10C4950", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x10C4A9C", Offset = "0x10C4A9C", VA = "0x10C4A9C", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x10C4C40", Offset = "0x10C4C40", VA = "0x10C4C40")]
		public void CreateItemSegment(string segmentName)
		{
		}

		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x10C4E7C", Offset = "0x10C4E7C", VA = "0x10C4E7C")]
		private void OnCreateItemSegment(SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x10C4F7C", Offset = "0x10C4F7C", VA = "0x10C4F7C")]
		public void UpdateItemSegment(string segmentName)
		{
		}

		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x10C5064", Offset = "0x10C5064", VA = "0x10C5064")]
		private void OnUpdateItemSegement(SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x10C5120", Offset = "0x10C5120", VA = "0x10C5120")]
		public void DeleteItemSegment(string segmentName)
		{
		}

		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x10C5208", Offset = "0x10C5208", VA = "0x10C5208")]
		private void OnDeleteItemSegment(SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x10C5294", Offset = "0x10C5294", VA = "0x10C5294")]
		private void TriggerEvent(ItemDataHandler handler)
		{
		}

		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x10C4F60", Offset = "0x10C4F60", VA = "0x10C4F60")]
		private void TriggerEvent(SegmentOverrideHandler handler, SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x10C52B0", Offset = "0x10C52B0", VA = "0x10C52B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627410", Offset = "0x627410")]
		[DebuggerHidden]
		private bool _003C_003En__0()
		{
			return default(bool);
		}

		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x10C52B8", Offset = "0x10C52B8", VA = "0x10C52B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627448", Offset = "0x627448")]
		[DebuggerHidden]
		private bool _003C_003En__1()
		{
			return default(bool);
		}

		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x10C52C0", Offset = "0x10C52C0", VA = "0x10C52C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627480", Offset = "0x627480")]
		[DebuggerHidden]
		private bool _003C_003En__2()
		{
			return default(bool);
		}
	}
}
