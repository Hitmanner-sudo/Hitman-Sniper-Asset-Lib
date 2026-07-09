using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117B")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7D5C", Offset = "0x5A7D5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7D5C", Offset = "0x5A7D5C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7D5C", Offset = "0x5A7D5C")]
	public class SetFsmBool : FsmStateAction
	{
		[Token(Token = "0x40052FB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8A2C", Offset = "0x5F8A2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40052FC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8A78", Offset = "0x5F8A78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8A78", Offset = "0x5F8A78")]
		public FsmString fsmName;

		[Token(Token = "0x40052FD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8AC8", Offset = "0x5F8AC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8AC8", Offset = "0x5F8AC8")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x40052FE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8B28", Offset = "0x5F8B28")]
		public FsmBool setValue;

		[Token(Token = "0x40052FF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8B74", Offset = "0x5F8B74")]
		public bool everyFrame;

		[Token(Token = "0x4005300")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005301")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005302")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006724")]
		[Address(RVA = "0x103A2EC", Offset = "0x103A2EC", VA = "0x103A2EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006725")]
		[Address(RVA = "0x103A348", Offset = "0x103A348", VA = "0x103A348", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006726")]
		[Address(RVA = "0x103A384", Offset = "0x103A384", VA = "0x103A384")]
		private void DoSetFsmBool()
		{
		}

		[Token(Token = "0x6006727")]
		[Address(RVA = "0x103A5CC", Offset = "0x103A5CC", VA = "0x103A5CC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006728")]
		[Address(RVA = "0x103A5D0", Offset = "0x103A5D0", VA = "0x103A5D0")]
		public SetFsmBool()
		{
		}
	}
}
