using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AB60", Offset = "0x59AB60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AB60", Offset = "0x59AB60")]
	public class SetAnimatorCullingMode : ComponentAction<Animator>
	{
		[Token(Token = "0x40046CA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C80A0", Offset = "0x5C80A0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C80A0", Offset = "0x5C80A0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046CB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8134", Offset = "0x5C8134")]
		public FsmBool alwaysAnimate;

		[Token(Token = "0x40046CC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C816C", Offset = "0x5C816C")]
		public FsmBool cullCompletely;

		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x103593C", Offset = "0x103593C", VA = "0x103593C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x1035948", Offset = "0x1035948", VA = "0x1035948", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C26")]
		[Address(RVA = "0x1035A14", Offset = "0x1035A14", VA = "0x1035A14")]
		public SetAnimatorCullingMode()
		{
		}
	}
}
