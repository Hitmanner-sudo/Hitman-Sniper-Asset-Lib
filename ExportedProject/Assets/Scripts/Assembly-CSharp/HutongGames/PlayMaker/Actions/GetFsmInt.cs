using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001158")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6CEC", Offset = "0x5A6CEC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6CEC", Offset = "0x5A6CEC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6CEC", Offset = "0x5A6CEC")]
	public class GetFsmInt : FsmStateAction
	{
		[Token(Token = "0x400524C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F699C", Offset = "0x5F699C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400524D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F69E8", Offset = "0x5F69E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F69E8", Offset = "0x5F69E8")]
		public FsmString fsmName;

		[Token(Token = "0x400524E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6A38", Offset = "0x5F6A38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6A38", Offset = "0x5F6A38")]
		public FsmString variableName;

		[Token(Token = "0x400524F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6A98", Offset = "0x5F6A98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6A98", Offset = "0x5F6A98")]
		public FsmInt storeValue;

		[Token(Token = "0x4005250")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6AF8", Offset = "0x5F6AF8")]
		public bool everyFrame;

		[Token(Token = "0x4005251")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005252")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005253")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600667C")]
		[Address(RVA = "0x10617D4", Offset = "0x10617D4", VA = "0x10617D4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600667D")]
		[Address(RVA = "0x1061830", Offset = "0x1061830", VA = "0x1061830", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600667E")]
		[Address(RVA = "0x1061A30", Offset = "0x1061A30", VA = "0x1061A30", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600667F")]
		[Address(RVA = "0x106186C", Offset = "0x106186C", VA = "0x106186C")]
		private void DoGetFsmInt()
		{
		}

		[Token(Token = "0x6006680")]
		[Address(RVA = "0x1061A34", Offset = "0x1061A34", VA = "0x1061A34")]
		public GetFsmInt()
		{
		}
	}
}
