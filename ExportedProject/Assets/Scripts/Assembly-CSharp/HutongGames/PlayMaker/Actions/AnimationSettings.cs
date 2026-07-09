using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5998F0", Offset = "0x5998F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5998F0", Offset = "0x5998F0")]
	public class AnimationSettings : BaseAnimationAction
	{
		[Token(Token = "0x40045B0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C24F0", Offset = "0x5C24F0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C24F0", Offset = "0x5C24F0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045B1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2584", Offset = "0x5C2584")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2584", Offset = "0x5C2584")]
		[RequiredField]
		public FsmString animName;

		[Token(Token = "0x40045B2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C25E4", Offset = "0x5C25E4")]
		public WrapMode wrapMode;

		[Token(Token = "0x40045B3")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C261C", Offset = "0x5C261C")]
		public AnimationBlendMode blendMode;

		[Token(Token = "0x40045B4")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C2654", Offset = "0x5C2654")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2654", Offset = "0x5C2654")]
		public FsmFloat speed;

		[Token(Token = "0x40045B5")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C26A8", Offset = "0x5C26A8")]
		public FsmInt layer;

		[Token(Token = "0x6005AF4")]
		[Address(RVA = "0xD45D74", Offset = "0xD45D74", VA = "0xD45D74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0xD45DC0", Offset = "0xD45DC0", VA = "0xD45DC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0xD45DE8", Offset = "0xD45DE8", VA = "0xD45DE8")]
		private void DoAnimationSettings()
		{
		}

		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0xD45FB4", Offset = "0xD45FB4", VA = "0xD45FB4")]
		public AnimationSettings()
		{
		}
	}
}
