using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A3E0", Offset = "0x59A3E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A3E0", Offset = "0x59A3E0")]
	public class GetAnimatorHumanScale : ComponentAction<Animator>
	{
		[Token(Token = "0x4004660")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5CCC", Offset = "0x5C5CCC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5CCC", Offset = "0x5C5CCC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004661")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5D60", Offset = "0x5C5D60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5D60", Offset = "0x5C5D60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5D60", Offset = "0x5C5D60")]
		public FsmFloat humanScale;

		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0xDA3818", Offset = "0xDA3818", VA = "0xDA3818", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0xDA3820", Offset = "0xDA3820", VA = "0xDA3820", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0xDA38B4", Offset = "0xDA38B4", VA = "0xDA38B4")]
		public GetAnimatorHumanScale()
		{
		}
	}
}
