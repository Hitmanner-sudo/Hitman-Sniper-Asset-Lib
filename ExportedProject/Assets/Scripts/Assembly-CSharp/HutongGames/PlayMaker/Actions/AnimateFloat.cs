using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5993F0", Offset = "0x5993F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5993F0", Offset = "0x5993F0")]
	public class AnimateFloat : FsmStateAction
	{
		[Token(Token = "0x40044DA")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0900", Offset = "0x5C0900")]
		public FsmAnimationCurve animCurve;

		[Token(Token = "0x40044DB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C094C", Offset = "0x5C094C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C094C", Offset = "0x5C094C")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x40044DC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C09AC", Offset = "0x5C09AC")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40044DD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C09E4", Offset = "0x5C09E4")]
		public bool realTime;

		[Token(Token = "0x40044DE")]
		[FieldOffset(Offset = "0x6C")]
		private float startTime;

		[Token(Token = "0x40044DF")]
		[FieldOffset(Offset = "0x70")]
		private float currentTime;

		[Token(Token = "0x40044E0")]
		[FieldOffset(Offset = "0x74")]
		private float endTime;

		[Token(Token = "0x40044E1")]
		[FieldOffset(Offset = "0x78")]
		private bool looping;

		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0xD42BC4", Offset = "0xD42BC4", VA = "0xD42BC4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0xD42BD4", Offset = "0xD42BD4", VA = "0xD42BD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0xD42CF8", Offset = "0xD42CF8", VA = "0xD42CF8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0xD42DBC", Offset = "0xD42DBC", VA = "0xD42DBC")]
		public AnimateFloat()
		{
		}
	}
}
