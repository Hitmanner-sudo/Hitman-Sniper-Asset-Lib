using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3150", Offset = "0x5A3150")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3150", Offset = "0x5A3150")]
	public class LookAt2dGameObject : FsmStateAction
	{
		[Token(Token = "0x4004E91")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7E04", Offset = "0x5E7E04")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E92")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7E50", Offset = "0x5E7E50")]
		public FsmGameObject targetObject;

		[Token(Token = "0x4004E93")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7E88", Offset = "0x5E7E88")]
		public FsmFloat rotationOffset;

		[Token(Token = "0x4004E94")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5E7EC0", Offset = "0x5E7EC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7EC0", Offset = "0x5E7EC0")]
		public FsmBool debug;

		[Token(Token = "0x4004E95")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7F20", Offset = "0x5E7F20")]
		public FsmColor debugLineColor;

		[Token(Token = "0x4004E96")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7F58", Offset = "0x5E7F58")]
		public bool everyFrame;

		[Token(Token = "0x4004E97")]
		[FieldOffset(Offset = "0x80")]
		private GameObject go;

		[Token(Token = "0x4004E98")]
		[FieldOffset(Offset = "0x88")]
		private GameObject goTarget;

		[Token(Token = "0x600634F")]
		[Address(RVA = "0x9DF9F8", Offset = "0x9DF9F8", VA = "0x9DF9F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006350")]
		[Address(RVA = "0x9DFA44", Offset = "0x9DFA44", VA = "0x9DFA44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006351")]
		[Address(RVA = "0x9DFD20", Offset = "0x9DFD20", VA = "0x9DFD20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006352")]
		[Address(RVA = "0x9DFA80", Offset = "0x9DFA80", VA = "0x9DFA80")]
		private void DoLookAt()
		{
		}

		[Token(Token = "0x6006353")]
		[Address(RVA = "0x9DFD24", Offset = "0x9DFD24", VA = "0x9DFD24")]
		public LookAt2dGameObject()
		{
		}
	}
}
