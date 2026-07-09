using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B7E")]
	public class SegmentData : BaseShopData
	{
		[Token(Token = "0x2000B7F")]
		public delegate void SegmentDataHandler(SegmentData segment);

		[Token(Token = "0x2000B80")]
		public delegate void StringListHandler(SegmentData data, List<string> list);

		[Token(Token = "0x2000B81")]
		public delegate void SegmentDataListHandler(List<SegmentData> list);

		[Serializable]
		[Token(Token = "0x2000B82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598220", Offset = "0x598220")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003A63")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003A64")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IResponseContext> _003C_003E9__35_0;

			[Token(Token = "0x6004926")]
			[Address(RVA = "0x8BAA6C", Offset = "0x8BAA6C", VA = "0x8BAA6C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004927")]
			[Address(RVA = "0x8BAA74", Offset = "0x8BAA74", VA = "0x8BAA74")]
			internal void _003CGetSegmentList_003Eb__35_0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003A60")]
		[FieldOffset(Offset = "0x68")]
		public string Description;

		[Token(Token = "0x4003A61")]
		[FieldOffset(Offset = "0x70")]
		public DateTime StartDate;

		[Token(Token = "0x4003A62")]
		[FieldOffset(Offset = "0x78")]
		public DateTime EndDate;

		[Token(Token = "0x1700092F")]
		public override string ObjectName
		{
			[Token(Token = "0x600490A")]
			[Address(RVA = "0xB6BD90", Offset = "0xB6BD90", VA = "0xB6BD90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000930")]
		public override string UniqueId
		{
			[Token(Token = "0x600490B")]
			[Address(RVA = "0xB6BDD4", Offset = "0xB6BDD4", VA = "0xB6BDD4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000931")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x600490C")]
			[Address(RVA = "0xB6BDE0", Offset = "0xB6BDE0", VA = "0xB6BDE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000105")]
		public event SegmentDataHandler OnCreate
		{
			[Token(Token = "0x60048FB")]
			[Address(RVA = "0xB6B4E4", Offset = "0xB6B4E4", VA = "0xB6B4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6274B8", Offset = "0x6274B8")]
			add
			{
			}
			[Token(Token = "0x60048FC")]
			[Address(RVA = "0xB6B584", Offset = "0xB6B584", VA = "0xB6B584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6274C8", Offset = "0x6274C8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000106")]
		public event SegmentDataHandler OnUpdate
		{
			[Token(Token = "0x60048FD")]
			[Address(RVA = "0xB6B624", Offset = "0xB6B624", VA = "0xB6B624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6274D8", Offset = "0x6274D8")]
			add
			{
			}
			[Token(Token = "0x60048FE")]
			[Address(RVA = "0xB6B6C4", Offset = "0xB6B6C4", VA = "0xB6B6C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6274E8", Offset = "0x6274E8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000107")]
		public event SegmentDataHandler OnDelete
		{
			[Token(Token = "0x60048FF")]
			[Address(RVA = "0xB6B764", Offset = "0xB6B764", VA = "0xB6B764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6274F8", Offset = "0x6274F8")]
			add
			{
			}
			[Token(Token = "0x6004900")]
			[Address(RVA = "0xB6B804", Offset = "0xB6B804", VA = "0xB6B804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627508", Offset = "0x627508")]
			remove
			{
			}
		}

		[Token(Token = "0x14000108")]
		public event SegmentDataHandler OnError
		{
			[Token(Token = "0x6004901")]
			[Address(RVA = "0xB6B8A4", Offset = "0xB6B8A4", VA = "0xB6B8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627518", Offset = "0x627518")]
			add
			{
			}
			[Token(Token = "0x6004902")]
			[Address(RVA = "0xB6B944", Offset = "0xB6B944", VA = "0xB6B944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627528", Offset = "0x627528")]
			remove
			{
			}
		}

		[Token(Token = "0x14000109")]
		public event StringListHandler OnGetPlayersList
		{
			[Token(Token = "0x6004903")]
			[Address(RVA = "0xB6B9E4", Offset = "0xB6B9E4", VA = "0xB6B9E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627538", Offset = "0x627538")]
			add
			{
			}
			[Token(Token = "0x6004904")]
			[Address(RVA = "0xB6BA84", Offset = "0xB6BA84", VA = "0xB6BA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627548", Offset = "0x627548")]
			remove
			{
			}
		}

		[Token(Token = "0x1400010A")]
		public static event SegmentDataListHandler OnGetSegmentList
		{
			[Token(Token = "0x6004905")]
			[Address(RVA = "0xB6BB24", Offset = "0xB6BB24", VA = "0xB6BB24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627558", Offset = "0x627558")]
			add
			{
			}
			[Token(Token = "0x6004906")]
			[Address(RVA = "0xB6BBE0", Offset = "0xB6BBE0", VA = "0xB6BBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627568", Offset = "0x627568")]
			remove
			{
			}
		}

		[Token(Token = "0x6004907")]
		[Address(RVA = "0xB6BC9C", Offset = "0xB6BC9C", VA = "0xB6BC9C")]
		public SegmentData()
		{
		}

		[Token(Token = "0x6004908")]
		[Address(RVA = "0xB6BCA4", Offset = "0xB6BCA4", VA = "0xB6BCA4")]
		public SegmentData(SegmentData obj)
		{
		}

		[Token(Token = "0x6004909")]
		[Address(RVA = "0xB6BCE8", Offset = "0xB6BCE8", VA = "0xB6BCE8", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x600490D")]
		[Address(RVA = "0xB6BE64", Offset = "0xB6BE64", VA = "0xB6BE64", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x600490E")]
		[Address(RVA = "0xB6BF38", Offset = "0xB6BF38", VA = "0xB6BF38", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x600490F")]
		[Address(RVA = "0xB6C03C", Offset = "0xB6C03C", VA = "0xB6C03C")]
		public static void GetSegmentList()
		{
		}

		[Token(Token = "0x6004910")]
		[Address(RVA = "0xB6C16C", Offset = "0xB6C16C", VA = "0xB6C16C", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x6004911")]
		[Address(RVA = "0xB6C26C", Offset = "0xB6C26C", VA = "0xB6C26C", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004912")]
		[Address(RVA = "0xB6C36C", Offset = "0xB6C36C", VA = "0xB6C36C", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x6004913")]
		[Address(RVA = "0xB6C454", Offset = "0xB6C454", VA = "0xB6C454")]
		public void GetPlayersList()
		{
		}

		[Token(Token = "0x6004914")]
		[Address(RVA = "0xB6C564", Offset = "0xB6C564", VA = "0xB6C564")]
		private void TriggerEvent(SegmentDataHandler handler)
		{
		}

		[Token(Token = "0x6004915")]
		[Address(RVA = "0xB6C580", Offset = "0xB6C580", VA = "0xB6C580")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627578", Offset = "0x627578")]
		private void _003CCreate_003Eb__36_0(IResponseContext response)
		{
		}

		[Token(Token = "0x6004916")]
		[Address(RVA = "0xB6C730", Offset = "0xB6C730", VA = "0xB6C730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627588", Offset = "0x627588")]
		private void _003CUpdate_003Eb__37_0(IResponseContext response)
		{
		}

		[Token(Token = "0x6004917")]
		[Address(RVA = "0xB6C8E0", Offset = "0xB6C8E0", VA = "0xB6C8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627598", Offset = "0x627598")]
		private void _003CDelete_003Eb__38_0(IResponseContext response)
		{
		}

		[Token(Token = "0x6004918")]
		[Address(RVA = "0xB6CA90", Offset = "0xB6CA90", VA = "0xB6CA90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275A8", Offset = "0x6275A8")]
		private void _003CGetPlayersList_003Eb__39_0(IResponseContext response)
		{
		}
	}
}
