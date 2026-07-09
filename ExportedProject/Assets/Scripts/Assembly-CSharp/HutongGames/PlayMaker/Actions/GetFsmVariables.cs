using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001161")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A735C", Offset = "0x5A735C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A735C", Offset = "0x5A735C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A735C", Offset = "0x5A735C")]
	public class GetFsmVariables : FsmStateAction
	{
		[Token(Token = "0x4005293")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7744", Offset = "0x5F7744")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005294")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7790", Offset = "0x5F7790")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7790", Offset = "0x5F7790")]
		public FsmString fsmName;

		[Token(Token = "0x4005295")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[HideTypeFilter]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F77E0", Offset = "0x5F77E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F77E0", Offset = "0x5F77E0")]
		public FsmVar[] getVariables;

		[Token(Token = "0x4005296")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7850", Offset = "0x5F7850")]
		public bool everyFrame;

		[Token(Token = "0x4005297")]
		[FieldOffset(Offset = "0x70")]
		private GameObject cachedGO;

		[Token(Token = "0x4005298")]
		[FieldOffset(Offset = "0x78")]
		private string cachedFsmName;

		[Token(Token = "0x4005299")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM sourceFsm;

		[Token(Token = "0x400529A")]
		[FieldOffset(Offset = "0x88")]
		private INamedVariable[] sourceVariables;

		[Token(Token = "0x400529B")]
		[FieldOffset(Offset = "0x90")]
		private NamedVariable[] targetVariables;

		[Token(Token = "0x60066AA")]
		[Address(RVA = "0x1062EB0", Offset = "0x1062EB0", VA = "0x1062EB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066AB")]
		[Address(RVA = "0x1062F08", Offset = "0x1062F08", VA = "0x1062F08")]
		private void InitFsmVars()
		{
		}

		[Token(Token = "0x60066AC")]
		[Address(RVA = "0x1063248", Offset = "0x1063248", VA = "0x1063248", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066AD")]
		[Address(RVA = "0x1063358", Offset = "0x1063358", VA = "0x1063358", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066AE")]
		[Address(RVA = "0x106328C", Offset = "0x106328C", VA = "0x106328C")]
		private void DoGetFsmVariables()
		{
		}

		[Token(Token = "0x60066AF")]
		[Address(RVA = "0x106335C", Offset = "0x106335C", VA = "0x106335C")]
		public GetFsmVariables()
		{
		}
	}
}
