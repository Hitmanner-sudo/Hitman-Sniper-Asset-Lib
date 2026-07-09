using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7F84", Offset = "0x5A7F84")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7F84", Offset = "0x5A7F84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7F84", Offset = "0x5A7F84")]
	public class SetFsmFloat : FsmStateAction
	{
		[Token(Token = "0x4005313")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8EAC", Offset = "0x5F8EAC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005314")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8EF8", Offset = "0x5F8EF8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8EF8", Offset = "0x5F8EF8")]
		public FsmString fsmName;

		[Token(Token = "0x4005315")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8F48", Offset = "0x5F8F48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8F48", Offset = "0x5F8F48")]
		public FsmString variableName;

		[Token(Token = "0x4005316")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8FA8", Offset = "0x5F8FA8")]
		public FsmFloat setValue;

		[Token(Token = "0x4005317")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8FF4", Offset = "0x5F8FF4")]
		public bool everyFrame;

		[Token(Token = "0x4005318")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005319")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400531A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006733")]
		[Address(RVA = "0x103ABB8", Offset = "0x103ABB8", VA = "0x103ABB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006734")]
		[Address(RVA = "0x103AC14", Offset = "0x103AC14", VA = "0x103AC14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006735")]
		[Address(RVA = "0x103AC50", Offset = "0x103AC50", VA = "0x103AC50")]
		private void DoSetFsmFloat()
		{
		}

		[Token(Token = "0x6006736")]
		[Address(RVA = "0x103AE94", Offset = "0x103AE94", VA = "0x103AE94", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006737")]
		[Address(RVA = "0x103AE98", Offset = "0x103AE98", VA = "0x103AE98")]
		public SetFsmFloat()
		{
		}
	}
}
