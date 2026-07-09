using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9568", Offset = "0x5A9568")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9568", Offset = "0x5A9568")]
	public class TransformDirection : FsmStateAction
	{
		[Token(Token = "0x4005498")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDF6C", Offset = "0x5FDF6C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005499")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDFB8", Offset = "0x5FDFB8")]
		[RequiredField]
		public FsmVector3 localDirection;

		[Token(Token = "0x400549A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE004", Offset = "0x5FE004")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE004", Offset = "0x5FE004")]
		public FsmVector3 storeResult;

		[Token(Token = "0x400549B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE064", Offset = "0x5FE064")]
		public bool everyFrame;

		[Token(Token = "0x6006852")]
		[Address(RVA = "0xC97074", Offset = "0xC97074", VA = "0xC97074", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006853")]
		[Address(RVA = "0xC97084", Offset = "0xC97084", VA = "0xC97084", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006854")]
		[Address(RVA = "0xC971A0", Offset = "0xC971A0", VA = "0xC971A0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006855")]
		[Address(RVA = "0xC970C0", Offset = "0xC970C0", VA = "0xC970C0")]
		private void DoTransformDirection()
		{
		}

		[Token(Token = "0x6006856")]
		[Address(RVA = "0xC971A4", Offset = "0xC971A4", VA = "0xC971A4")]
		public TransformDirection()
		{
		}
	}
}
