using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001188")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A86B4", Offset = "0x5A86B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A86B4", Offset = "0x5A86B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A86B4", Offset = "0x5A86B4")]
	public class SetFsmVector2 : FsmStateAction
	{
		[Token(Token = "0x4005365")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9D34", Offset = "0x5F9D34")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005366")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9D80", Offset = "0x5F9D80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9D80", Offset = "0x5F9D80")]
		public FsmString fsmName;

		[Token(Token = "0x4005367")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9DD0", Offset = "0x5F9DD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9DD0", Offset = "0x5F9DD0")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4005368")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9E30", Offset = "0x5F9E30")]
		public FsmVector2 setValue;

		[Token(Token = "0x4005369")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9E7C", Offset = "0x5F9E7C")]
		public bool everyFrame;

		[Token(Token = "0x400536A")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400536B")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400536C")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006765")]
		[Address(RVA = "0x103C9D0", Offset = "0x103C9D0", VA = "0x103C9D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006766")]
		[Address(RVA = "0x103CA2C", Offset = "0x103CA2C", VA = "0x103CA2C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006767")]
		[Address(RVA = "0x103CA68", Offset = "0x103CA68", VA = "0x103CA68")]
		private void DoSetFsmVector2()
		{
		}

		[Token(Token = "0x6006768")]
		[Address(RVA = "0x103CCA4", Offset = "0x103CCA4", VA = "0x103CCA4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006769")]
		[Address(RVA = "0x103CCA8", Offset = "0x103CCA8", VA = "0x103CCA8")]
		public SetFsmVector2()
		{
		}
	}
}
