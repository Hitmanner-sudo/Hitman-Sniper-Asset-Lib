using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115B")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6F14", Offset = "0x5A6F14")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6F14", Offset = "0x5A6F14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6F14", Offset = "0x5A6F14")]
	public class GetFsmQuaternion : FsmStateAction
	{
		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6E58", Offset = "0x5F6E58")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6EA4", Offset = "0x5F6EA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6EA4", Offset = "0x5F6EA4")]
		public FsmString fsmName;

		[Token(Token = "0x4005266")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6EF4", Offset = "0x5F6EF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6EF4", Offset = "0x5F6EF4")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4005267")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6F54", Offset = "0x5F6F54")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6F54", Offset = "0x5F6F54")]
		[RequiredField]
		public FsmQuaternion storeValue;

		[Token(Token = "0x4005268")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6FB4", Offset = "0x5F6FB4")]
		public bool everyFrame;

		[Token(Token = "0x4005269")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400526A")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400526B")]
		[FieldOffset(Offset = "0x88")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x600668B")]
		[Address(RVA = "0x1061F44", Offset = "0x1061F44", VA = "0x1061F44", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600668C")]
		[Address(RVA = "0x1061FB0", Offset = "0x1061FB0", VA = "0x1061FB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600668D")]
		[Address(RVA = "0x10621AC", Offset = "0x10621AC", VA = "0x10621AC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600668E")]
		[Address(RVA = "0x1061FEC", Offset = "0x1061FEC", VA = "0x1061FEC")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x600668F")]
		[Address(RVA = "0x10621B0", Offset = "0x10621B0", VA = "0x10621B0")]
		public GetFsmQuaternion()
		{
		}
	}
}
