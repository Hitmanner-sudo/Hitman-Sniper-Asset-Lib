using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599C60", Offset = "0x599C60")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599C60", Offset = "0x599C60")]
	public class StopAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045EB")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C377C", Offset = "0x5C377C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C377C", Offset = "0x5C377C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045EC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3810", Offset = "0x5C3810")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C3810", Offset = "0x5C3810")]
		public FsmString animName;

		[Token(Token = "0x6005B33")]
		[Address(RVA = "0xD2B080", Offset = "0xD2B080", VA = "0xD2B080", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B34")]
		[Address(RVA = "0xD2B088", Offset = "0xD2B088", VA = "0xD2B088", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B35")]
		[Address(RVA = "0xD2B0B0", Offset = "0xD2B0B0", VA = "0xD2B0B0")]
		private void DoStopAnimation()
		{
		}

		[Token(Token = "0x6005B36")]
		[Address(RVA = "0xD2B1AC", Offset = "0xD2B1AC", VA = "0xD2B1AC")]
		public StopAnimation()
		{
		}
	}
}
