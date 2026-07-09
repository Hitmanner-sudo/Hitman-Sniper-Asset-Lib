using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A803C", Offset = "0x5A803C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A803C", Offset = "0x5A803C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A803C", Offset = "0x5A803C")]
	public class SetFsmGameObject : FsmStateAction
	{
		[Token(Token = "0x400531B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F902C", Offset = "0x5F902C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400531C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9078", Offset = "0x5F9078")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9078", Offset = "0x5F9078")]
		public FsmString fsmName;

		[Token(Token = "0x400531D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F90C8", Offset = "0x5F90C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F90C8", Offset = "0x5F90C8")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x400531E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9128", Offset = "0x5F9128")]
		public FsmGameObject setValue;

		[Token(Token = "0x400531F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9160", Offset = "0x5F9160")]
		public bool everyFrame;

		[Token(Token = "0x4005320")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005321")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005322")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006738")]
		[Address(RVA = "0x103AEA0", Offset = "0x103AEA0", VA = "0x103AEA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006739")]
		[Address(RVA = "0x103AF00", Offset = "0x103AF00", VA = "0x103AF00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600673A")]
		[Address(RVA = "0x103AF3C", Offset = "0x103AF3C", VA = "0x103AF3C")]
		private void DoSetFsmGameObject()
		{
		}

		[Token(Token = "0x600673B")]
		[Address(RVA = "0x103B170", Offset = "0x103B170", VA = "0x103B170", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600673C")]
		[Address(RVA = "0x103B174", Offset = "0x103B174", VA = "0x103B174")]
		public SetFsmGameObject()
		{
		}
	}
}
