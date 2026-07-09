using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F24")]
	[Attribute(Name = "ActionTarget", RVA = "0x59B8F0", Offset = "0x59B8F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B8F0", Offset = "0x59B8F0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59B8F0", Offset = "0x59B8F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B8F0", Offset = "0x59B8F0")]
	public class FsmArraySet : FsmStateAction
	{
		[Token(Token = "0x4004779")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB0C0", Offset = "0x5CB0C0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400477A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB10C", Offset = "0x5CB10C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB10C", Offset = "0x5CB10C")]
		public FsmString fsmName;

		[Token(Token = "0x400477B")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB15C", Offset = "0x5CB15C")]
		public FsmString variableName;

		[Token(Token = "0x400477C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB1A8", Offset = "0x5CB1A8")]
		public FsmString setValue;

		[Token(Token = "0x400477D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB1E0", Offset = "0x5CB1E0")]
		public bool everyFrame;

		[Token(Token = "0x400477E")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400477F")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x95C298", Offset = "0x95C298", VA = "0x95C298", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x95C2F4", Offset = "0x95C2F4", VA = "0x95C2F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x95C330", Offset = "0x95C330", VA = "0x95C330")]
		private void DoSetFsmString()
		{
		}

		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x95C53C", Offset = "0x95C53C", VA = "0x95C53C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x95C540", Offset = "0x95C540", VA = "0x95C540")]
		public FsmArraySet()
		{
		}
	}
}
