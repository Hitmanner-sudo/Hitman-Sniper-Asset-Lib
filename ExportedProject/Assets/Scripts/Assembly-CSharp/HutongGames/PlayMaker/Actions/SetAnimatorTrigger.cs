using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F02")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AF70", Offset = "0x59AF70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AF70", Offset = "0x59AF70")]
	public class SetAnimatorTrigger : ComponentAction<Animator>
	{
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C9178", Offset = "0x5C9178")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9178", Offset = "0x5C9178")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C920C", Offset = "0x5C920C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C920C", Offset = "0x5C920C")]
		[RequiredField]
		public FsmString trigger;

		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x103776C", Offset = "0x103776C", VA = "0x103776C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x1037774", Offset = "0x1037774", VA = "0x1037774", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x1037814", Offset = "0x1037814", VA = "0x1037814")]
		public SetAnimatorTrigger()
		{
		}
	}
}
