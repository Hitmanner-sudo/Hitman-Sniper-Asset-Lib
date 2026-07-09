using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001159")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6DA4", Offset = "0x5A6DA4")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6DA4", Offset = "0x5A6DA4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6DA4", Offset = "0x5A6DA4")]
	public class GetFsmMaterial : FsmStateAction
	{
		[Token(Token = "0x4005254")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6B30", Offset = "0x5F6B30")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005255")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6B7C", Offset = "0x5F6B7C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6B7C", Offset = "0x5F6B7C")]
		public FsmString fsmName;

		[Token(Token = "0x4005256")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6BCC", Offset = "0x5F6BCC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6BCC", Offset = "0x5F6BCC")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4005257")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6C2C", Offset = "0x5F6C2C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6C2C", Offset = "0x5F6C2C")]
		public FsmMaterial storeValue;

		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6C8C", Offset = "0x5F6C8C")]
		public bool everyFrame;

		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x88")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x6006681")]
		[Address(RVA = "0x1061A3C", Offset = "0x1061A3C", VA = "0x1061A3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006682")]
		[Address(RVA = "0x1061AA8", Offset = "0x1061AA8", VA = "0x1061AA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006683")]
		[Address(RVA = "0x1061CC0", Offset = "0x1061CC0", VA = "0x1061CC0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006684")]
		[Address(RVA = "0x1061AE4", Offset = "0x1061AE4", VA = "0x1061AE4")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x6006685")]
		[Address(RVA = "0x1061CC4", Offset = "0x1061CC4", VA = "0x1061CC4")]
		public GetFsmMaterial()
		{
		}
	}
}
