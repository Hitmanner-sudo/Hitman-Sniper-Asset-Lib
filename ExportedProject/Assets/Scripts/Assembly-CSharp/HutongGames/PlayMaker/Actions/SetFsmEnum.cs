using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7ECC", Offset = "0x5A7ECC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7ECC", Offset = "0x5A7ECC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7ECC", Offset = "0x5A7ECC")]
	public class SetFsmEnum : FsmStateAction
	{
		[Token(Token = "0x400530B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8D2C", Offset = "0x5F8D2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400530C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8D78", Offset = "0x5F8D78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8D78", Offset = "0x5F8D78")]
		public FsmString fsmName;

		[Token(Token = "0x400530D")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8DC8", Offset = "0x5F8DC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8DC8", Offset = "0x5F8DC8")]
		public FsmString variableName;

		[Token(Token = "0x400530E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8E28", Offset = "0x5F8E28")]
		[RequiredField]
		public FsmEnum setValue;

		[Token(Token = "0x400530F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8E74", Offset = "0x5F8E74")]
		public bool everyFrame;

		[Token(Token = "0x4005310")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005311")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005312")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600672E")]
		[Address(RVA = "0x103A8B8", Offset = "0x103A8B8", VA = "0x103A8B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600672F")]
		[Address(RVA = "0x103A914", Offset = "0x103A914", VA = "0x103A914", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006730")]
		[Address(RVA = "0x103A950", Offset = "0x103A950", VA = "0x103A950")]
		private void DoSetFsmEnum()
		{
		}

		[Token(Token = "0x6006731")]
		[Address(RVA = "0x103ABAC", Offset = "0x103ABAC", VA = "0x103ABAC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006732")]
		[Address(RVA = "0x103ABB0", Offset = "0x103ABB0", VA = "0x103ABB0")]
		public SetFsmEnum()
		{
		}
	}
}
