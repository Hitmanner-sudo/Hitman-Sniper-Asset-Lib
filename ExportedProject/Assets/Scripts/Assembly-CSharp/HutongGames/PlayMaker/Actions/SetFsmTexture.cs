using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001186")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8544", Offset = "0x5A8544")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A8544", Offset = "0x5A8544")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8544", Offset = "0x5A8544")]
	public class SetFsmTexture : FsmStateAction
	{
		[Token(Token = "0x4005353")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9A70", Offset = "0x5F9A70")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005354")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9ABC", Offset = "0x5F9ABC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9ABC", Offset = "0x5F9ABC")]
		public FsmString fsmName;

		[Token(Token = "0x4005355")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9B0C", Offset = "0x5F9B0C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9B0C", Offset = "0x5F9B0C")]
		public FsmString variableName;

		[Token(Token = "0x4005356")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9B6C", Offset = "0x5F9B6C")]
		public FsmTexture setValue;

		[Token(Token = "0x4005357")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9BA4", Offset = "0x5F9BA4")]
		public bool everyFrame;

		[Token(Token = "0x4005358")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005359")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400535A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600675B")]
		[Address(RVA = "0x103C334", Offset = "0x103C334", VA = "0x103C334", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600675C")]
		[Address(RVA = "0x103C3A0", Offset = "0x103C3A0", VA = "0x103C3A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600675D")]
		[Address(RVA = "0x103C3DC", Offset = "0x103C3DC", VA = "0x103C3DC")]
		private void DoSetFsmTexture()
		{
		}

		[Token(Token = "0x600675E")]
		[Address(RVA = "0x103C638", Offset = "0x103C638", VA = "0x103C638", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600675F")]
		[Address(RVA = "0x103C63C", Offset = "0x103C63C", VA = "0x103C63C")]
		public SetFsmTexture()
		{
		}
	}
}
