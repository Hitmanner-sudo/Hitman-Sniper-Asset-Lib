using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B83")]
	public class PlayersToSegmentData : BaseShopData
	{
		[Token(Token = "0x2000B84")]
		public delegate void PlayersToSegmentDataHandler(PlayersToSegmentData segment);

		[Token(Token = "0x4003A69")]
		[FieldOffset(Offset = "0x60")]
		public string PlayersList;

		[Token(Token = "0x17000932")]
		public override string ObjectName
		{
			[Token(Token = "0x6004933")]
			[Address(RVA = "0xABEB50", Offset = "0xABEB50", VA = "0xABEB50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000933")]
		public override string UniqueId
		{
			[Token(Token = "0x6004934")]
			[Address(RVA = "0xABEB94", Offset = "0xABEB94", VA = "0xABEB94", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000934")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x6004935")]
			[Address(RVA = "0xABEBA0", Offset = "0xABEBA0", VA = "0xABEBA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400010B")]
		public event PlayersToSegmentDataHandler OnCreate
		{
			[Token(Token = "0x6004928")]
			[Address(RVA = "0xABE5B4", Offset = "0xABE5B4", VA = "0xABE5B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275B8", Offset = "0x6275B8")]
			add
			{
			}
			[Token(Token = "0x6004929")]
			[Address(RVA = "0xABE654", Offset = "0xABE654", VA = "0xABE654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275C8", Offset = "0x6275C8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400010C")]
		public event PlayersToSegmentDataHandler OnUpdate
		{
			[Token(Token = "0x600492A")]
			[Address(RVA = "0xABE6F4", Offset = "0xABE6F4", VA = "0xABE6F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275D8", Offset = "0x6275D8")]
			add
			{
			}
			[Token(Token = "0x600492B")]
			[Address(RVA = "0xABE794", Offset = "0xABE794", VA = "0xABE794")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275E8", Offset = "0x6275E8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400010D")]
		public event PlayersToSegmentDataHandler OnDelete
		{
			[Token(Token = "0x600492C")]
			[Address(RVA = "0xABE834", Offset = "0xABE834", VA = "0xABE834")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275F8", Offset = "0x6275F8")]
			add
			{
			}
			[Token(Token = "0x600492D")]
			[Address(RVA = "0xABE8D4", Offset = "0xABE8D4", VA = "0xABE8D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627608", Offset = "0x627608")]
			remove
			{
			}
		}

		[Token(Token = "0x1400010E")]
		public event PlayersToSegmentDataHandler OnError
		{
			[Token(Token = "0x600492E")]
			[Address(RVA = "0xABE974", Offset = "0xABE974", VA = "0xABE974")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627618", Offset = "0x627618")]
			add
			{
			}
			[Token(Token = "0x600492F")]
			[Address(RVA = "0xABEA14", Offset = "0xABEA14", VA = "0xABEA14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627628", Offset = "0x627628")]
			remove
			{
			}
		}

		[Token(Token = "0x6004930")]
		[Address(RVA = "0xABEAB4", Offset = "0xABEAB4", VA = "0xABEAB4")]
		public PlayersToSegmentData()
		{
		}

		[Token(Token = "0x6004931")]
		[Address(RVA = "0xABEABC", Offset = "0xABEABC", VA = "0xABEABC")]
		public PlayersToSegmentData(PlayersToSegmentData obj)
		{
		}

		[Token(Token = "0x6004932")]
		[Address(RVA = "0xABEAF0", Offset = "0xABEAF0", VA = "0xABEAF0", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004936")]
		[Address(RVA = "0xABEC24", Offset = "0xABEC24", VA = "0xABEC24", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x6004937")]
		[Address(RVA = "0xABEDE8", Offset = "0xABEDE8", VA = "0xABEDE8", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004938")]
		[Address(RVA = "0xABEF48", Offset = "0xABEF48", VA = "0xABEF48", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x6004939")]
		[Address(RVA = "0xABF048", Offset = "0xABF048", VA = "0xABF048", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600493A")]
		[Address(RVA = "0xABF08C", Offset = "0xABF08C", VA = "0xABF08C", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x600493B")]
		[Address(RVA = "0xABF070", Offset = "0xABF070", VA = "0xABF070")]
		private void TriggerEvent(PlayersToSegmentDataHandler handler)
		{
		}

		[Token(Token = "0x600493C")]
		[Address(RVA = "0xABF270", Offset = "0xABF270", VA = "0xABF270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627638", Offset = "0x627638")]
		private void _003CCreate_003Eb__25_0(IResponseContext response)
		{
		}

		[Token(Token = "0x600493D")]
		[Address(RVA = "0xABF420", Offset = "0xABF420", VA = "0xABF420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627648", Offset = "0x627648")]
		private void _003CDelete_003Eb__27_0(IResponseContext response)
		{
		}
	}
}
