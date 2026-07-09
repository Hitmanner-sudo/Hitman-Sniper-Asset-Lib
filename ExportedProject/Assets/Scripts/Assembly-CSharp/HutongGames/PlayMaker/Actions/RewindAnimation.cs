using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599B20", Offset = "0x599B20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599B20", Offset = "0x599B20")]
	public class RewindAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045DC")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3234", Offset = "0x5C3234")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3234", Offset = "0x5C3234")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045DD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C32C8", Offset = "0x5C32C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C32C8", Offset = "0x5C32C8")]
		public FsmString animName;

		[Token(Token = "0x6005B20")]
		[Address(RVA = "0x96DD18", Offset = "0x96DD18", VA = "0x96DD18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B21")]
		[Address(RVA = "0x96DD20", Offset = "0x96DD20", VA = "0x96DD20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B22")]
		[Address(RVA = "0x96DD48", Offset = "0x96DD48", VA = "0x96DD48")]
		private void DoRewindAnimation()
		{
		}

		[Token(Token = "0x6005B23")]
		[Address(RVA = "0x96DE28", Offset = "0x96DE28", VA = "0x96DE28")]
		public RewindAnimation()
		{
		}
	}
}
