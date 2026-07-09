using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001184")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A83D4", Offset = "0x5A83D4")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A83D4", Offset = "0x5A83D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A83D4", Offset = "0x5A83D4")]
	public class SetFsmRect : FsmStateAction
	{
		[Token(Token = "0x4005343")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9784", Offset = "0x5F9784")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005344")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F97D0", Offset = "0x5F97D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F97D0", Offset = "0x5F97D0")]
		public FsmString fsmName;

		[Token(Token = "0x4005345")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9820", Offset = "0x5F9820")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9820", Offset = "0x5F9820")]
		public FsmString variableName;

		[Token(Token = "0x4005346")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9880", Offset = "0x5F9880")]
		[RequiredField]
		public FsmRect setValue;

		[Token(Token = "0x4005347")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F98CC", Offset = "0x5F98CC")]
		public bool everyFrame;

		[Token(Token = "0x4005348")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005349")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400534A")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006751")]
		[Address(RVA = "0x103BD5C", Offset = "0x103BD5C", VA = "0x103BD5C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006752")]
		[Address(RVA = "0x103BDC8", Offset = "0x103BDC8", VA = "0x103BDC8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006753")]
		[Address(RVA = "0x103BE04", Offset = "0x103BE04", VA = "0x103BE04")]
		private void DoSetFsmBool()
		{
		}

		[Token(Token = "0x6006754")]
		[Address(RVA = "0x103C040", Offset = "0x103C040", VA = "0x103C040", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006755")]
		[Address(RVA = "0x103C044", Offset = "0x103C044", VA = "0x103C044")]
		public SetFsmRect()
		{
		}
	}
}
