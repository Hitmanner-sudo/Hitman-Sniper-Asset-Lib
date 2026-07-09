using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000E9B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5990AC", Offset = "0x5990AC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5990AC", Offset = "0x5990AC")]
	public class AnimatorForceStateNormalizedTime : FsmStateAction
	{
		[Token(Token = "0x40044A6")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5BFE44", Offset = "0x5BFE44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5BFE44", Offset = "0x5BFE44")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044A7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5BFED8", Offset = "0x5BFED8")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x40044A8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5BFF10", Offset = "0x5BFF10")]
		public bool everyFrame;

		[Token(Token = "0x40044A9")]
		[FieldOffset(Offset = "0x68")]
		private Animator _animator;

		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0xD46FB4", Offset = "0xD46FB4", VA = "0xD46FB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0xD46FC0", Offset = "0xD46FC0", VA = "0xD46FC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A50")]
		[Address(RVA = "0xD4717C", Offset = "0xD4717C", VA = "0xD4717C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A51")]
		[Address(RVA = "0xD470D8", Offset = "0xD470D8", VA = "0xD470D8")]
		private void ForceNormalizedTime()
		{
		}

		[Token(Token = "0x6005A52")]
		[Address(RVA = "0xD47180", Offset = "0xD47180", VA = "0xD47180")]
		public AnimatorForceStateNormalizedTime()
		{
		}
	}
}
