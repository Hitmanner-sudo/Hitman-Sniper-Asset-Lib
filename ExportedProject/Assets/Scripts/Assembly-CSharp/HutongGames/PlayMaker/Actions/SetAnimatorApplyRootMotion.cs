using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AA70", Offset = "0x59AA70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AA70", Offset = "0x59AA70")]
	public class SetAnimatorApplyRootMotion : ComponentAction<Animator>
	{
		[Token(Token = "0x40046BC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7D34", Offset = "0x5C7D34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7D34", Offset = "0x5C7D34")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046BD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7DC8", Offset = "0x5C7DC8")]
		public FsmBool applyRootMotion;

		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x1035270", Offset = "0x1035270", VA = "0x1035270", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x1035278", Offset = "0x1035278", VA = "0x1035278", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x1035318", Offset = "0x1035318", VA = "0x1035318")]
		public SetAnimatorApplyRootMotion()
		{
		}
	}
}
