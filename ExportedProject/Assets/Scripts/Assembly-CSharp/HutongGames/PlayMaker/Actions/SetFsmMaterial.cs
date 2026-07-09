using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001181")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A81AC", Offset = "0x5A81AC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A81AC", Offset = "0x5A81AC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A81AC", Offset = "0x5A81AC")]
	public class SetFsmMaterial : FsmStateAction
	{
		[Token(Token = "0x400532B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9318", Offset = "0x5F9318")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400532C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9364", Offset = "0x5F9364")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9364", Offset = "0x5F9364")]
		public FsmString fsmName;

		[Token(Token = "0x400532D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F93B4", Offset = "0x5F93B4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F93B4", Offset = "0x5F93B4")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x400532E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9414", Offset = "0x5F9414")]
		[RequiredField]
		public FsmMaterial setValue;

		[Token(Token = "0x400532F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9460", Offset = "0x5F9460")]
		public bool everyFrame;

		[Token(Token = "0x4005330")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005331")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005332")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006742")]
		[Address(RVA = "0x103B464", Offset = "0x103B464", VA = "0x103B464", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006743")]
		[Address(RVA = "0x103B4D0", Offset = "0x103B4D0", VA = "0x103B4D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006744")]
		[Address(RVA = "0x103B50C", Offset = "0x103B50C", VA = "0x103B50C")]
		private void DoSetFsmBool()
		{
		}

		[Token(Token = "0x6006745")]
		[Address(RVA = "0x103B768", Offset = "0x103B768", VA = "0x103B768", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006746")]
		[Address(RVA = "0x103B76C", Offset = "0x103B76C", VA = "0x103B76C")]
		public SetFsmMaterial()
		{
		}
	}
}
