using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001162")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A740C", Offset = "0x5A740C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A740C", Offset = "0x5A740C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A740C", Offset = "0x5A740C")]
	public class GetFsmVector2 : FsmStateAction
	{
		[Token(Token = "0x400529C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7888", Offset = "0x5F7888")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400529D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F78D4", Offset = "0x5F78D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F78D4", Offset = "0x5F78D4")]
		public FsmString fsmName;

		[Token(Token = "0x400529E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7924", Offset = "0x5F7924")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7924", Offset = "0x5F7924")]
		public FsmString variableName;

		[Token(Token = "0x400529F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7984", Offset = "0x5F7984")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7984", Offset = "0x5F7984")]
		public FsmVector2 storeValue;

		[Token(Token = "0x40052A0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F79E4", Offset = "0x5F79E4")]
		public bool everyFrame;

		[Token(Token = "0x40052A1")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x40052A2")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x40052A3")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x60066B0")]
		[Address(RVA = "0x1063364", Offset = "0x1063364", VA = "0x1063364", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066B1")]
		[Address(RVA = "0x10633C0", Offset = "0x10633C0", VA = "0x10633C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066B2")]
		[Address(RVA = "0x10635BC", Offset = "0x10635BC", VA = "0x10635BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066B3")]
		[Address(RVA = "0x10633FC", Offset = "0x10633FC", VA = "0x10633FC")]
		private void DoGetFsmVector2()
		{
		}

		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x10635C0", Offset = "0x10635C0", VA = "0x10635C0")]
		public GetFsmVector2()
		{
		}
	}
}
