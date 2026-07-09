using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001157")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6C34", Offset = "0x5A6C34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6C34", Offset = "0x5A6C34")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6C34", Offset = "0x5A6C34")]
	public class GetFsmGameObject : FsmStateAction
	{
		[Token(Token = "0x4005244")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6808", Offset = "0x5F6808")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005245")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6854", Offset = "0x5F6854")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6854", Offset = "0x5F6854")]
		public FsmString fsmName;

		[Token(Token = "0x4005246")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F68A4", Offset = "0x5F68A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F68A4", Offset = "0x5F68A4")]
		public FsmString variableName;

		[Token(Token = "0x4005247")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6904", Offset = "0x5F6904")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6904", Offset = "0x5F6904")]
		public FsmGameObject storeValue;

		[Token(Token = "0x4005248")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6964", Offset = "0x5F6964")]
		public bool everyFrame;

		[Token(Token = "0x4005249")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400524A")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400524B")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006677")]
		[Address(RVA = "0x1061554", Offset = "0x1061554", VA = "0x1061554", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006678")]
		[Address(RVA = "0x10615B0", Offset = "0x10615B0", VA = "0x10615B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006679")]
		[Address(RVA = "0x10617C8", Offset = "0x10617C8", VA = "0x10617C8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600667A")]
		[Address(RVA = "0x10615EC", Offset = "0x10615EC", VA = "0x10615EC")]
		private void DoGetFsmGameObject()
		{
		}

		[Token(Token = "0x600667B")]
		[Address(RVA = "0x10617CC", Offset = "0x10617CC", VA = "0x10617CC")]
		public GetFsmGameObject()
		{
		}
	}
}
