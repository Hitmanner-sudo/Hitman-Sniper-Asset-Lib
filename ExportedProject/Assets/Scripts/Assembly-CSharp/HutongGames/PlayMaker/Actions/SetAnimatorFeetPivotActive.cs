using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ABB0", Offset = "0x59ABB0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ABB0", Offset = "0x59ABB0")]
	public class SetAnimatorFeetPivotActive : ComponentAction<Animator>
	{
		[Token(Token = "0x40046CD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C81A4", Offset = "0x5C81A4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C81A4", Offset = "0x5C81A4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046CE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8238", Offset = "0x5C8238")]
		public FsmFloat feetPivotActive;

		[Token(Token = "0x6005C27")]
		[Address(RVA = "0x1035A60", Offset = "0x1035A60", VA = "0x1035A60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C28")]
		[Address(RVA = "0x1035A68", Offset = "0x1035A68", VA = "0x1035A68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C29")]
		[Address(RVA = "0x1035B04", Offset = "0x1035B04", VA = "0x1035B04")]
		public SetAnimatorFeetPivotActive()
		{
		}
	}
}
