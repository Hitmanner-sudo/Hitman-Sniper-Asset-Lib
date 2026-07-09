using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A17F0", Offset = "0x5A17F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A17F0", Offset = "0x5A17F0")]
	public class FloatDivide : FsmStateAction
	{
		[Token(Token = "0x4004C8D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF698", Offset = "0x5DF698")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF698", Offset = "0x5DF698")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004C8E")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF6F8", Offset = "0x5DF6F8")]
		public FsmFloat divideBy;

		[Token(Token = "0x4004C8F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF744", Offset = "0x5DF744")]
		public bool everyFrame;

		[Token(Token = "0x60061A0")]
		[Address(RVA = "0x959114", Offset = "0x959114", VA = "0x959114", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061A1")]
		[Address(RVA = "0x959120", Offset = "0x959120", VA = "0x959120", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061A2")]
		[Address(RVA = "0x959198", Offset = "0x959198", VA = "0x959198", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061A3")]
		[Address(RVA = "0x9591F0", Offset = "0x9591F0", VA = "0x9591F0")]
		public FloatDivide()
		{
		}
	}
}
