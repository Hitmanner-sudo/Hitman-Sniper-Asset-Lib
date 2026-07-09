using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6E5C", Offset = "0x5A6E5C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6E5C", Offset = "0x5A6E5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6E5C", Offset = "0x5A6E5C")]
	public class GetFsmObject : FsmStateAction
	{
		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6CC4", Offset = "0x5F6CC4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6D10", Offset = "0x5F6D10")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6D10", Offset = "0x5F6D10")]
		public FsmString fsmName;

		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6D60", Offset = "0x5F6D60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6D60", Offset = "0x5F6D60")]
		public FsmString variableName;

		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6DC0", Offset = "0x5F6DC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6DC0", Offset = "0x5F6DC0")]
		[RequiredField]
		public FsmObject storeValue;

		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6E20", Offset = "0x5F6E20")]
		public bool everyFrame;

		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x88")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x6006686")]
		[Address(RVA = "0x1061CCC", Offset = "0x1061CCC", VA = "0x1061CCC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006687")]
		[Address(RVA = "0x1061D38", Offset = "0x1061D38", VA = "0x1061D38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006688")]
		[Address(RVA = "0x1061F38", Offset = "0x1061F38", VA = "0x1061F38", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006689")]
		[Address(RVA = "0x1061D74", Offset = "0x1061D74", VA = "0x1061D74")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x600668A")]
		[Address(RVA = "0x1061F3C", Offset = "0x1061F3C", VA = "0x1061F3C")]
		public GetFsmObject()
		{
		}
	}
}
