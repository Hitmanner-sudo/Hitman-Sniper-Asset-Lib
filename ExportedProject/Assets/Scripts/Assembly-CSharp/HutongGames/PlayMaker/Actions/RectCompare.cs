using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001035")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1020", Offset = "0x5A1020")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1020", Offset = "0x5A1020")]
	public class RectCompare : FsmStateAction
	{
		[Token(Token = "0x4004C1E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD580", Offset = "0x5DD580")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD580", Offset = "0x5DD580")]
		[RequiredField]
		public FsmRect rect1;

		[Token(Token = "0x4004C1F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD5E0", Offset = "0x5DD5E0")]
		public FsmRect rect2;

		[Token(Token = "0x4004C20")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD62C", Offset = "0x5DD62C")]
		public FsmFloat tolerance;

		[Token(Token = "0x4004C21")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD678", Offset = "0x5DD678")]
		public FsmEvent equal;

		[Token(Token = "0x4004C22")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD6B0", Offset = "0x5DD6B0")]
		public FsmEvent notEqual;

		[Token(Token = "0x4004C23")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD6E8", Offset = "0x5DD6E8")]
		public bool everyFrame;

		[Token(Token = "0x6006129")]
		[Address(RVA = "0xB43B80", Offset = "0xB43B80", VA = "0xB43B80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600612A")]
		[Address(RVA = "0xB43BB8", Offset = "0xB43BB8", VA = "0xB43BB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600612B")]
		[Address(RVA = "0xB43DAC", Offset = "0xB43DAC", VA = "0xB43DAC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600612C")]
		[Address(RVA = "0xB43BF4", Offset = "0xB43BF4", VA = "0xB43BF4")]
		private void DoCompare()
		{
		}

		[Token(Token = "0x600612D")]
		[Address(RVA = "0xB43DB0", Offset = "0xB43DB0", VA = "0xB43DB0", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x600612E")]
		[Address(RVA = "0xB43E84", Offset = "0xB43E84", VA = "0xB43E84")]
		public RectCompare()
		{
		}
	}
}
