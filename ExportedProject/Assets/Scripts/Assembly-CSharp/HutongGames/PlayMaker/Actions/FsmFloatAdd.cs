using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D92C", Offset = "0x59D92C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D92C", Offset = "0x59D92C")]
	public class FsmFloatAdd : FsmStateAction
	{
		[Token(Token = "0x4004979")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2C30", Offset = "0x5D2C30")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400497A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2C7C", Offset = "0x5D2C7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2C7C", Offset = "0x5D2C7C")]
		public FsmString fsmName;

		[Token(Token = "0x400497B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2CCC", Offset = "0x5D2CCC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2CCC", Offset = "0x5D2CCC")]
		public FsmString variableName;

		[Token(Token = "0x400497C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2D2C", Offset = "0x5D2D2C")]
		public FsmFloat addValue;

		[Token(Token = "0x400497D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2D78", Offset = "0x5D2D78")]
		public bool everyFrame;

		[Token(Token = "0x400497E")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400497F")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0x95C548", Offset = "0x95C548", VA = "0x95C548", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0x95C5A4", Offset = "0x95C5A4", VA = "0x95C5A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0x95C5E0", Offset = "0x95C5E0", VA = "0x95C5E0")]
		private void DoAddFsmFloat()
		{
		}

		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0x95C808", Offset = "0x95C808", VA = "0x95C808", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0x95C80C", Offset = "0x95C80C", VA = "0x95C80C")]
		public FsmFloatAdd()
		{
		}
	}
}
