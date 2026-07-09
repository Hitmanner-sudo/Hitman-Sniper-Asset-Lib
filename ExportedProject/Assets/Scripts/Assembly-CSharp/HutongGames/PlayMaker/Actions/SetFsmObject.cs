using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001182")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8264", Offset = "0x5A8264")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A8264", Offset = "0x5A8264")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8264", Offset = "0x5A8264")]
	public class SetFsmObject : FsmStateAction
	{
		[Token(Token = "0x4005333")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9498", Offset = "0x5F9498")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005334")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F94E4", Offset = "0x5F94E4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F94E4", Offset = "0x5F94E4")]
		public FsmString fsmName;

		[Token(Token = "0x4005335")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9534", Offset = "0x5F9534")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9534", Offset = "0x5F9534")]
		public FsmString variableName;

		[Token(Token = "0x4005336")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9594", Offset = "0x5F9594")]
		public FsmObject setValue;

		[Token(Token = "0x4005337")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F95CC", Offset = "0x5F95CC")]
		public bool everyFrame;

		[Token(Token = "0x4005338")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005339")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400533A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006747")]
		[Address(RVA = "0x103B774", Offset = "0x103B774", VA = "0x103B774", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006748")]
		[Address(RVA = "0x103B7E0", Offset = "0x103B7E0", VA = "0x103B7E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006749")]
		[Address(RVA = "0x103B81C", Offset = "0x103B81C", VA = "0x103B81C")]
		private void DoSetFsmBool()
		{
		}

		[Token(Token = "0x600674A")]
		[Address(RVA = "0x103BA60", Offset = "0x103BA60", VA = "0x103BA60", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600674B")]
		[Address(RVA = "0x103BA64", Offset = "0x103BA64", VA = "0x103BA64")]
		public SetFsmObject()
		{
		}
	}
}
