using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5999E0", Offset = "0x5999E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5999E0", Offset = "0x5999E0")]
	public class EnableAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045C1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2AB8", Offset = "0x5C2AB8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C2AB8", Offset = "0x5C2AB8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045C2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2B4C", Offset = "0x5C2B4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2B4C", Offset = "0x5C2B4C")]
		[RequiredField]
		public FsmString animName;

		[Token(Token = "0x40045C3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2BAC", Offset = "0x5C2BAC")]
		[RequiredField]
		public FsmBool enable;

		[Token(Token = "0x40045C4")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2BF8", Offset = "0x5C2BF8")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40045C5")]
		[FieldOffset(Offset = "0x88")]
		private AnimationState anim;

		[Token(Token = "0x6005B08")]
		[Address(RVA = "0xE0CDA8", Offset = "0xE0CDA8", VA = "0xE0CDA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B09")]
		[Address(RVA = "0xE0CDE8", Offset = "0xE0CDE8", VA = "0xE0CDE8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B0A")]
		[Address(RVA = "0xE0CE30", Offset = "0xE0CE30", VA = "0xE0CE30")]
		private void DoEnableAnimation(GameObject go)
		{
		}

		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0xE0CF2C", Offset = "0xE0CF2C", VA = "0xE0CF2C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0xE0CFA8", Offset = "0xE0CFA8", VA = "0xE0CFA8")]
		public EnableAnimation()
		{
		}
	}
}
