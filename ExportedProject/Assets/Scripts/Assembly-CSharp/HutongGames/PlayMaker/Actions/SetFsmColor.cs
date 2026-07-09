using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7E14", Offset = "0x5A7E14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7E14", Offset = "0x5A7E14")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7E14", Offset = "0x5A7E14")]
	public class SetFsmColor : FsmStateAction
	{
		[Token(Token = "0x4005303")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8BAC", Offset = "0x5F8BAC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005304")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8BF8", Offset = "0x5F8BF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8BF8", Offset = "0x5F8BF8")]
		public FsmString fsmName;

		[Token(Token = "0x4005305")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8C48", Offset = "0x5F8C48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8C48", Offset = "0x5F8C48")]
		public FsmString variableName;

		[Token(Token = "0x4005306")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8CA8", Offset = "0x5F8CA8")]
		[RequiredField]
		public FsmColor setValue;

		[Token(Token = "0x4005307")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8CF4", Offset = "0x5F8CF4")]
		public bool everyFrame;

		[Token(Token = "0x4005308")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005309")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400530A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006729")]
		[Address(RVA = "0x103A5D8", Offset = "0x103A5D8", VA = "0x103A5D8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600672A")]
		[Address(RVA = "0x103A634", Offset = "0x103A634", VA = "0x103A634", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600672B")]
		[Address(RVA = "0x103A670", Offset = "0x103A670", VA = "0x103A670")]
		private void DoSetFsmColor()
		{
		}

		[Token(Token = "0x600672C")]
		[Address(RVA = "0x103A8AC", Offset = "0x103A8AC", VA = "0x103A8AC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600672D")]
		[Address(RVA = "0x103A8B0", Offset = "0x103A8B0", VA = "0x103A8B0")]
		public SetFsmColor()
		{
		}
	}
}
