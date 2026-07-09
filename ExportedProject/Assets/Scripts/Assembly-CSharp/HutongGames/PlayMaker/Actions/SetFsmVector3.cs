using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001189")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A876C", Offset = "0x5A876C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A876C", Offset = "0x5A876C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A876C", Offset = "0x5A876C")]
	public class SetFsmVector3 : FsmStateAction
	{
		[Token(Token = "0x400536D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9EB4", Offset = "0x5F9EB4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400536E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9F00", Offset = "0x5F9F00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9F00", Offset = "0x5F9F00")]
		public FsmString fsmName;

		[Token(Token = "0x400536F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9F50", Offset = "0x5F9F50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9F50", Offset = "0x5F9F50")]
		public FsmString variableName;

		[Token(Token = "0x4005370")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9FB0", Offset = "0x5F9FB0")]
		public FsmVector3 setValue;

		[Token(Token = "0x4005371")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9FFC", Offset = "0x5F9FFC")]
		public bool everyFrame;

		[Token(Token = "0x4005372")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005373")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005374")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600676A")]
		[Address(RVA = "0x103CCB0", Offset = "0x103CCB0", VA = "0x103CCB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600676B")]
		[Address(RVA = "0x103CD0C", Offset = "0x103CD0C", VA = "0x103CD0C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600676C")]
		[Address(RVA = "0x103CD48", Offset = "0x103CD48", VA = "0x103CD48")]
		private void DoSetFsmVector3()
		{
		}

		[Token(Token = "0x600676D")]
		[Address(RVA = "0x103CF90", Offset = "0x103CF90", VA = "0x103CF90", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600676E")]
		[Address(RVA = "0x103CF94", Offset = "0x103CF94", VA = "0x103CF94")]
		public SetFsmVector3()
		{
		}
	}
}
