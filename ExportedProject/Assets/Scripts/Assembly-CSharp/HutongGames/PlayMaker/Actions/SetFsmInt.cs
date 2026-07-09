using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001180")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A80F4", Offset = "0x5A80F4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A80F4", Offset = "0x5A80F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A80F4", Offset = "0x5A80F4")]
	public class SetFsmInt : FsmStateAction
	{
		[Token(Token = "0x4005323")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9198", Offset = "0x5F9198")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005324")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F91E4", Offset = "0x5F91E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F91E4", Offset = "0x5F91E4")]
		public FsmString fsmName;

		[Token(Token = "0x4005325")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9234", Offset = "0x5F9234")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9234", Offset = "0x5F9234")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4005326")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9294", Offset = "0x5F9294")]
		public FsmInt setValue;

		[Token(Token = "0x4005327")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F92E0", Offset = "0x5F92E0")]
		public bool everyFrame;

		[Token(Token = "0x4005328")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005329")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400532A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600673D")]
		[Address(RVA = "0x103B17C", Offset = "0x103B17C", VA = "0x103B17C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600673E")]
		[Address(RVA = "0x103B1D8", Offset = "0x103B1D8", VA = "0x103B1D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600673F")]
		[Address(RVA = "0x103B214", Offset = "0x103B214", VA = "0x103B214")]
		private void DoSetFsmInt()
		{
		}

		[Token(Token = "0x6006740")]
		[Address(RVA = "0x103B458", Offset = "0x103B458", VA = "0x103B458", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006741")]
		[Address(RVA = "0x103B45C", Offset = "0x103B45C", VA = "0x103B45C")]
		public SetFsmInt()
		{
		}
	}
}
