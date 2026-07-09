using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F21")]
	[NoActionTargets]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B890", Offset = "0x59B890")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B890", Offset = "0x59B890")]
	public class ArrayTransferValue : FsmStateAction
	{
		[Token(Token = "0x2000F22")]
		public enum ArrayTransferType
		{
			[Token(Token = "0x4004771")]
			Copy = 0,
			[Token(Token = "0x4004772")]
			Cut = 1,
			[Token(Token = "0x4004773")]
			nullify = 2
		}

		[Token(Token = "0x2000F23")]
		public enum ArrayPasteType
		{
			[Token(Token = "0x4004775")]
			AsFirstItem = 0,
			[Token(Token = "0x4004776")]
			AsLastItem = 1,
			[Token(Token = "0x4004777")]
			InsertAtSameIndex = 2,
			[Token(Token = "0x4004778")]
			ReplaceAtSameIndex = 3
		}

		[Token(Token = "0x400476A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CAE14", Offset = "0x5CAE14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAE14", Offset = "0x5CAE14")]
		[RequiredField]
		public FsmArray arraySource;

		[Token(Token = "0x400476B")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CAE74", Offset = "0x5CAE74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAE74", Offset = "0x5CAE74")]
		public FsmArray arrayTarget;

		[Token(Token = "0x400476C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "MatchFieldTypeAttribute", RVA = "0x5CAED4", Offset = "0x5CAED4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAED4", Offset = "0x5CAED4")]
		public FsmInt indexToTransfer;

		[Token(Token = "0x400476D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAF34", Offset = "0x5CAF34")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CAF34", Offset = "0x5CAF34")]
		[Attribute(Name = "ActionSection", RVA = "0x5CAF34", Offset = "0x5CAF34")]
		public FsmEnum copyType;

		[Token(Token = "0x400476E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CAFDC", Offset = "0x5CAFDC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAFDC", Offset = "0x5CAFDC")]
		public FsmEnum pasteType;

		[Token(Token = "0x400476F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ActionSection", RVA = "0x5CB060", Offset = "0x5CB060")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB060", Offset = "0x5CB060")]
		public FsmEvent indexOutOfRange;

		[Token(Token = "0x6005CDE")]
		[Address(RVA = "0xBFDE98", Offset = "0xBFDE98", VA = "0xBFDE98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0xBFDF3C", Offset = "0xBFDF3C", VA = "0xBFDF3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0xBFDF64", Offset = "0xBFDF64", VA = "0xBFDF64")]
		private void DoTransferValue()
		{
		}

		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0xBFE498", Offset = "0xBFE498", VA = "0xBFE498")]
		public ArrayTransferValue()
		{
		}
	}
}
