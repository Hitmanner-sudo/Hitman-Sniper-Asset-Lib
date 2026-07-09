using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599CB0", Offset = "0x599CB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599CB0", Offset = "0x599CB0")]
	public class AnimatorCrossFade : ComponentAction<Animator>
	{
		[Token(Token = "0x40045ED")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3860", Offset = "0x5C3860")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3860", Offset = "0x5C3860")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045EE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C38F4", Offset = "0x5C38F4")]
		public FsmString stateName;

		[Token(Token = "0x40045EF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C392C", Offset = "0x5C392C")]
		public FsmFloat transitionDuration;

		[Token(Token = "0x40045F0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3964", Offset = "0x5C3964")]
		public FsmInt layer;

		[Token(Token = "0x40045F1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C399C", Offset = "0x5C399C")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x17000C03")]
		private Animator animator
		{
			[Token(Token = "0x6005B37")]
			[Address(RVA = "0xD4647C", Offset = "0xD4647C", VA = "0xD4647C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B38")]
		[Address(RVA = "0xD46484", Offset = "0xD46484", VA = "0xD46484", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B39")]
		[Address(RVA = "0xD46540", Offset = "0xD46540", VA = "0xD46540", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B3A")]
		[Address(RVA = "0xD466B8", Offset = "0xD466B8", VA = "0xD466B8")]
		public AnimatorCrossFade()
		{
		}
	}
}
