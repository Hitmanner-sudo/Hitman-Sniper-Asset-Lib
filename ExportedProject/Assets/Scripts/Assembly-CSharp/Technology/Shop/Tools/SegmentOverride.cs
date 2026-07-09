using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B70")]
	public class SegmentOverride : BaseShopData
	{
		[Token(Token = "0x2000B71")]
		public delegate void SegmentOverrideHandler(SegmentOverride segment);

		[Token(Token = "0x2000B72")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981B0", Offset = "0x5981B0")]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			[Token(Token = "0x4003A2E")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpSetItemOfferSegment svcOp;

			[Token(Token = "0x4003A2F")]
			[FieldOffset(Offset = "0x18")]
			public bool create;

			[Token(Token = "0x4003A30")]
			[FieldOffset(Offset = "0x20")]
			public SegmentOverride _003C_003E4__this;

			[Token(Token = "0x600489B")]
			[Address(RVA = "0x8BB95C", Offset = "0x8BB95C", VA = "0x8BB95C")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600489C")]
			[Address(RVA = "0x8BB964", Offset = "0x8BB964", VA = "0x8BB964")]
			internal void _003CCreateOrUpdateSegmentOverride_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B73")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981C0", Offset = "0x5981C0")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4003A31")]
			[FieldOffset(Offset = "0x10")]
			public SvcIOpDeleteItemOfferSegment svcOpC;

			[Token(Token = "0x4003A32")]
			[FieldOffset(Offset = "0x18")]
			public SegmentOverride _003C_003E4__this;

			[Token(Token = "0x600489D")]
			[Address(RVA = "0x8BBB04", Offset = "0x8BBB04", VA = "0x8BBB04")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600489E")]
			[Address(RVA = "0x8BBB0C", Offset = "0x8BBB0C", VA = "0x8BBB0C")]
			internal void _003CDelete_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003A28")]
		[FieldOffset(Offset = "0x60")]
		public long BloodMoney;

		[Token(Token = "0x4003A29")]
		[FieldOffset(Offset = "0x68")]
		public long Bonds;

		[Token(Token = "0x4003A2A")]
		[FieldOffset(Offset = "0x70")]
		public bool Deployed;

		[Token(Token = "0x4003A2B")]
		[FieldOffset(Offset = "0x78")]
		public DateTime DateEffective;

		[Token(Token = "0x4003A2C")]
		[FieldOffset(Offset = "0x80")]
		public DateTime DateExpiry;

		[Token(Token = "0x4003A2D")]
		[FieldOffset(Offset = "0x88")]
		public List<ItemTemplateSettings> TemplateList;

		[Token(Token = "0x17000929")]
		public override string Name
		{
			[Token(Token = "0x6004886")]
			[Address(RVA = "0xB6D234", Offset = "0xB6D234", VA = "0xB6D234", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004887")]
			[Address(RVA = "0xB6D23C", Offset = "0xB6D23C", VA = "0xB6D23C", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x1700092A")]
		public string SegmentName
		{
			[Token(Token = "0x6004888")]
			[Address(RVA = "0xB6D244", Offset = "0xB6D244", VA = "0xB6D244")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004889")]
			[Address(RVA = "0xB6D24C", Offset = "0xB6D24C", VA = "0xB6D24C")]
			set
			{
			}
		}

		[Token(Token = "0x1700092B")]
		public override string ObjectName
		{
			[Token(Token = "0x600488C")]
			[Address(RVA = "0xB6D4C8", Offset = "0xB6D4C8", VA = "0xB6D4C8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092C")]
		public override string UniqueId
		{
			[Token(Token = "0x600488D")]
			[Address(RVA = "0xB6D50C", Offset = "0xB6D50C", VA = "0xB6D50C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000F8")]
		public event SegmentOverrideHandler OnCreate
		{
			[Token(Token = "0x600487E")]
			[Address(RVA = "0xB6CD34", Offset = "0xB6CD34", VA = "0xB6CD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627200", Offset = "0x627200")]
			add
			{
			}
			[Token(Token = "0x600487F")]
			[Address(RVA = "0xB6CDD4", Offset = "0xB6CDD4", VA = "0xB6CDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627210", Offset = "0x627210")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F9")]
		public event SegmentOverrideHandler OnUpdate
		{
			[Token(Token = "0x6004880")]
			[Address(RVA = "0xB6CE74", Offset = "0xB6CE74", VA = "0xB6CE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627220", Offset = "0x627220")]
			add
			{
			}
			[Token(Token = "0x6004881")]
			[Address(RVA = "0xB6CF14", Offset = "0xB6CF14", VA = "0xB6CF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627230", Offset = "0x627230")]
			remove
			{
			}
		}

		[Token(Token = "0x140000FA")]
		public event SegmentOverrideHandler OnDelete
		{
			[Token(Token = "0x6004882")]
			[Address(RVA = "0xB6CFB4", Offset = "0xB6CFB4", VA = "0xB6CFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627240", Offset = "0x627240")]
			add
			{
			}
			[Token(Token = "0x6004883")]
			[Address(RVA = "0xB6D054", Offset = "0xB6D054", VA = "0xB6D054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627250", Offset = "0x627250")]
			remove
			{
			}
		}

		[Token(Token = "0x140000FB")]
		public event SegmentOverrideHandler OnError
		{
			[Token(Token = "0x6004884")]
			[Address(RVA = "0xB6D0F4", Offset = "0xB6D0F4", VA = "0xB6D0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627260", Offset = "0x627260")]
			add
			{
			}
			[Token(Token = "0x6004885")]
			[Address(RVA = "0xB6D194", Offset = "0xB6D194", VA = "0xB6D194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627270", Offset = "0x627270")]
			remove
			{
			}
		}

		[Token(Token = "0x600488A")]
		[Address(RVA = "0xB6D254", Offset = "0xB6D254", VA = "0xB6D254")]
		public SegmentOverride()
		{
		}

		[Token(Token = "0x600488B")]
		[Address(RVA = "0xB6D2CC", Offset = "0xB6D2CC", VA = "0xB6D2CC")]
		public SegmentOverride(SegmentOverride obj)
		{
		}

		[Token(Token = "0x600488E")]
		[Address(RVA = "0xB6D568", Offset = "0xB6D568", VA = "0xB6D568")]
		private void CreateOrUpdateSegmentOverride(bool create)
		{
		}

		[Token(Token = "0x600488F")]
		[Address(RVA = "0xB6D6C4", Offset = "0xB6D6C4", VA = "0xB6D6C4", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x6004890")]
		[Address(RVA = "0xB6D6E0", Offset = "0xB6D6E0", VA = "0xB6D6E0", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004891")]
		[Address(RVA = "0xB6D6FC", Offset = "0xB6D6FC", VA = "0xB6D6FC", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x6004892")]
		[Address(RVA = "0xB6D830", Offset = "0xB6D830", VA = "0xB6D830", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x6004893")]
		[Address(RVA = "0xB6DE18", Offset = "0xB6DE18", VA = "0xB6DE18", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004894")]
		[Address(RVA = "0xB6E330", Offset = "0xB6E330", VA = "0xB6E330")]
		private void TriggerEvent(SegmentOverrideHandler handler)
		{
		}

		[Token(Token = "0x6004895")]
		[Address(RVA = "0xB6E34C", Offset = "0xB6E34C", VA = "0xB6E34C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627280", Offset = "0x627280")]
		[DebuggerHidden]
		private bool _003C_003En__0()
		{
			return default(bool);
		}

		[Token(Token = "0x6004896")]
		[Address(RVA = "0xB6E354", Offset = "0xB6E354", VA = "0xB6E354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6272B8", Offset = "0x6272B8")]
		[DebuggerHidden]
		private bool _003C_003En__1()
		{
			return default(bool);
		}
	}
}
