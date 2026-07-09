using Il2CppDummyDll;
using SimpleJSON;
using Technology.CrossPromotion;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B54")]
	public class CrossPromotionData : BaseShopData
	{
		[Token(Token = "0x2000B55")]
		public delegate void CrossPromotionEventHandler(Infocast infocast);

		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0x58")]
		private Infocast _infoCast;

		[Token(Token = "0x1700091E")]
		public Infocast InfoCast
		{
			[Token(Token = "0x60047BD")]
			[Address(RVA = "0xD84ED4", Offset = "0xD84ED4", VA = "0xD84ED4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0xD84EDC", Offset = "0xD84EDC", VA = "0xD84EDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700091F")]
		public override string ObjectName
		{
			[Token(Token = "0x60047C2")]
			[Address(RVA = "0xD854B4", Offset = "0xD854B4", VA = "0xD854B4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000920")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x60047C4")]
			[Address(RVA = "0xD8558C", Offset = "0xD8558C", VA = "0xD8558C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000E8")]
		public event CrossPromotionEventHandler OnCreation
		{
			[Token(Token = "0x60047B5")]
			[Address(RVA = "0xD84ADC", Offset = "0xD84ADC", VA = "0xD84ADC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626F68", Offset = "0x626F68")]
			add
			{
			}
			[Token(Token = "0x60047B6")]
			[Address(RVA = "0xD84B7C", Offset = "0xD84B7C", VA = "0xD84B7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626F78", Offset = "0x626F78")]
			remove
			{
			}
		}

		[Token(Token = "0x140000E9")]
		public event CrossPromotionEventHandler OnUpdate
		{
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0xD84C1C", Offset = "0xD84C1C", VA = "0xD84C1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626F88", Offset = "0x626F88")]
			add
			{
			}
			[Token(Token = "0x60047B8")]
			[Address(RVA = "0xD84CBC", Offset = "0xD84CBC", VA = "0xD84CBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626F98", Offset = "0x626F98")]
			remove
			{
			}
		}

		[Token(Token = "0x140000EA")]
		public event CrossPromotionEventHandler OnDelete
		{
			[Token(Token = "0x60047B9")]
			[Address(RVA = "0xD84D5C", Offset = "0xD84D5C", VA = "0xD84D5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FA8", Offset = "0x626FA8")]
			add
			{
			}
			[Token(Token = "0x60047BA")]
			[Address(RVA = "0xD84DFC", Offset = "0xD84DFC", VA = "0xD84DFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FB8", Offset = "0x626FB8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000EB")]
		public event Infocast.InfocastEventHandler OnError
		{
			[Token(Token = "0x60047BB")]
			[Address(RVA = "0xD84E9C", Offset = "0xD84E9C", VA = "0xD84E9C")]
			add
			{
			}
			[Token(Token = "0x60047BC")]
			[Address(RVA = "0xD84EB8", Offset = "0xD84EB8", VA = "0xD84EB8")]
			remove
			{
			}
		}

		[Token(Token = "0x60047BF")]
		[Address(RVA = "0xD851F0", Offset = "0xD851F0", VA = "0xD851F0")]
		public CrossPromotionData()
		{
		}

		[Token(Token = "0x60047C0")]
		[Address(RVA = "0xD8525C", Offset = "0xD8525C", VA = "0xD8525C")]
		public CrossPromotionData(CrossPromotionData obj)
		{
		}

		[Token(Token = "0x60047C1")]
		[Address(RVA = "0xD852F8", Offset = "0xD852F8", VA = "0xD852F8", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60047C3")]
		[Address(RVA = "0xD854F8", Offset = "0xD854F8", VA = "0xD854F8", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x60047C5")]
		[Address(RVA = "0xD85600", Offset = "0xD85600", VA = "0xD85600")]
		private void BaseCreate(Infocast infocast)
		{
		}

		[Token(Token = "0x60047C6")]
		[Address(RVA = "0xD85674", Offset = "0xD85674", VA = "0xD85674", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60047C7")]
		[Address(RVA = "0xD85718", Offset = "0xD85718", VA = "0xD85718")]
		public void UpdateSegment(Infocast infocast)
		{
		}

		[Token(Token = "0x60047C8")]
		[Address(RVA = "0xD8571C", Offset = "0xD8571C", VA = "0xD8571C")]
		private void BaseUpdate(Infocast infocast)
		{
		}

		[Token(Token = "0x60047C9")]
		[Address(RVA = "0xD85760", Offset = "0xD85760", VA = "0xD85760", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x60047CA")]
		[Address(RVA = "0xD857F4", Offset = "0xD857F4", VA = "0xD857F4")]
		private void BaseDelete(Infocast infocast)
		{
		}

		[Token(Token = "0x60047CB")]
		[Address(RVA = "0xD85838", Offset = "0xD85838", VA = "0xD85838", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x60047CC")]
		[Address(RVA = "0xD858E8", Offset = "0xD858E8", VA = "0xD858E8", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}
	}
}
