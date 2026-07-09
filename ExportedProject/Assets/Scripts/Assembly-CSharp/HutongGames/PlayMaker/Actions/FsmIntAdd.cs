using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D97C", Offset = "0x59D97C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D97C", Offset = "0x59D97C")]
	public class FsmIntAdd : FsmStateAction
	{
		[Token(Token = "0x4004980")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2DB0", Offset = "0x5D2DB0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004981")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2DFC", Offset = "0x5D2DFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2DFC", Offset = "0x5D2DFC")]
		public FsmString fsmName;

		[Token(Token = "0x4004982")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2E4C", Offset = "0x5D2E4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2E4C", Offset = "0x5D2E4C")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4004983")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2EAC", Offset = "0x5D2EAC")]
		public FsmInt addValue;

		[Token(Token = "0x4004984")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2EF8", Offset = "0x5D2EF8")]
		public bool everyFrame;

		[Token(Token = "0x4004985")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4004986")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0x95CA28", Offset = "0x95CA28", VA = "0x95CA28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0x95CA84", Offset = "0x95CA84", VA = "0x95CA84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0x95CAC0", Offset = "0x95CAC0", VA = "0x95CAC0")]
		private void DoFsmIntAdd()
		{
		}

		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0x95CCE0", Offset = "0x95CCE0", VA = "0x95CCE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0x95CCE4", Offset = "0x95CCE4", VA = "0x95CCE4")]
		public FsmIntAdd()
		{
		}
	}
}
