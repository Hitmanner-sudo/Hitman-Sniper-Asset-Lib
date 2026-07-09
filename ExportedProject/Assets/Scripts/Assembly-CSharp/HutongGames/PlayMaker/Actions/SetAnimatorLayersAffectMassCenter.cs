using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AD40", Offset = "0x59AD40")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AD40", Offset = "0x59AD40")]
	public class SetAnimatorLayersAffectMassCenter : ComponentAction<Animator>
	{
		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C88B8", Offset = "0x5C88B8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C88B8", Offset = "0x5C88B8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046E9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C894C", Offset = "0x5C894C")]
		public FsmBool affectMassCenter;

		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x10365AC", Offset = "0x10365AC", VA = "0x10365AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x10365B4", Offset = "0x10365B4", VA = "0x10365B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x1036654", Offset = "0x1036654", VA = "0x1036654")]
		public SetAnimatorLayersAffectMassCenter()
		{
		}
	}
}
