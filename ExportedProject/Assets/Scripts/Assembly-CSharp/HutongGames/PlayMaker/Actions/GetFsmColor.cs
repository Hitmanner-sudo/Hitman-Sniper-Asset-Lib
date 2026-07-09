using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001154")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6A14", Offset = "0x5A6A14")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6A14", Offset = "0x5A6A14")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6A14", Offset = "0x5A6A14")]
	public class GetFsmColor : FsmStateAction
	{
		[Token(Token = "0x400522C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F634C", Offset = "0x5F634C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400522D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6398", Offset = "0x5F6398")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6398", Offset = "0x5F6398")]
		public FsmString fsmName;

		[Token(Token = "0x400522E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F63E8", Offset = "0x5F63E8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F63E8", Offset = "0x5F63E8")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x400522F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6448", Offset = "0x5F6448")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6448", Offset = "0x5F6448")]
		public FsmColor storeValue;

		[Token(Token = "0x4005230")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F64A8", Offset = "0x5F64A8")]
		public bool everyFrame;

		[Token(Token = "0x4005231")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005232")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005233")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006668")]
		[Address(RVA = "0x1060DFC", Offset = "0x1060DFC", VA = "0x1060DFC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006669")]
		[Address(RVA = "0x1060E58", Offset = "0x1060E58", VA = "0x1060E58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600666A")]
		[Address(RVA = "0x1061054", Offset = "0x1061054", VA = "0x1061054", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600666B")]
		[Address(RVA = "0x1060E94", Offset = "0x1060E94", VA = "0x1060E94")]
		private void DoGetFsmColor()
		{
		}

		[Token(Token = "0x600666C")]
		[Address(RVA = "0x1061058", Offset = "0x1061058", VA = "0x1061058")]
		public GetFsmColor()
		{
		}
	}
}
