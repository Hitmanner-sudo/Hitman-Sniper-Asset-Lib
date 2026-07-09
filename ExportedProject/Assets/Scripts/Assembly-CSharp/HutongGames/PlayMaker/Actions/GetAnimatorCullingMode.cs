using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A070", Offset = "0x59A070")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A070", Offset = "0x59A070")]
	public class GetAnimatorCullingMode : ComponentAction<Animator>
	{
		[Token(Token = "0x4004626")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4868", Offset = "0x5C4868")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4868", Offset = "0x5C4868")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004627")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5C48FC", Offset = "0x5C48FC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C48FC", Offset = "0x5C48FC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C48FC", Offset = "0x5C48FC")]
		[RequiredField]
		public FsmBool alwaysAnimate;

		[Token(Token = "0x4004628")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4980", Offset = "0x5C4980")]
		public FsmEvent alwaysAnimateEvent;

		[Token(Token = "0x4004629")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C49B8", Offset = "0x5C49B8")]
		public FsmEvent basedOnRenderersEvent;

		[Token(Token = "0x6005B70")]
		[Address(RVA = "0xDA2574", Offset = "0xDA2574", VA = "0xDA2574", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B71")]
		[Address(RVA = "0xDA2584", Offset = "0xDA2584", VA = "0xDA2584", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B72")]
		[Address(RVA = "0xDA2648", Offset = "0xDA2648", VA = "0xDA2648")]
		public GetAnimatorCullingMode()
		{
		}
	}
}
