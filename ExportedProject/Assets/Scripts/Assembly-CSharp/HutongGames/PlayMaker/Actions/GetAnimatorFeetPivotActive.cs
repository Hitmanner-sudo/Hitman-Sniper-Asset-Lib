using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A2F0", Offset = "0x59A2F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A2F0", Offset = "0x59A2F0")]
	public class GetAnimatorFeetPivotActive : ComponentAction<Animator>
	{
		[Token(Token = "0x4004657")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C597C", Offset = "0x5C597C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C597C", Offset = "0x5C597C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004658")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5A10", Offset = "0x5C5A10")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5A10", Offset = "0x5C5A10")]
		public FsmFloat feetPivotActive;

		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0xDA3498", Offset = "0xDA3498", VA = "0xDA3498", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0xDA34A0", Offset = "0xDA34A0", VA = "0xDA34A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0xDA3534", Offset = "0xDA3534", VA = "0xDA3534")]
		public GetAnimatorFeetPivotActive()
		{
		}
	}
}
