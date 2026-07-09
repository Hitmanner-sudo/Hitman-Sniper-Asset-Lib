using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F00")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AED0", Offset = "0x59AED0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AED0", Offset = "0x59AED0")]
	public class SetAnimatorStabilizeFeet : ComponentAction<Animator>
	{
		[Token(Token = "0x40046FE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8F70", Offset = "0x5C8F70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8F70", Offset = "0x5C8F70")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046FF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9004", Offset = "0x5C9004")]
		public FsmBool stabilizeFeet;

		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x1037510", Offset = "0x1037510", VA = "0x1037510", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x1037518", Offset = "0x1037518", VA = "0x1037518", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x10375B8", Offset = "0x10375B8", VA = "0x10375B8")]
		public SetAnimatorStabilizeFeet()
		{
		}
	}
}
