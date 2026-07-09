using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001156")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6B7C", Offset = "0x5A6B7C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6B7C", Offset = "0x5A6B7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6B7C", Offset = "0x5A6B7C")]
	public class GetFsmFloat : FsmStateAction
	{
		[Token(Token = "0x400523C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6674", Offset = "0x5F6674")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400523D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F66C0", Offset = "0x5F66C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F66C0", Offset = "0x5F66C0")]
		public FsmString fsmName;

		[Token(Token = "0x400523E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6710", Offset = "0x5F6710")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6710", Offset = "0x5F6710")]
		public FsmString variableName;

		[Token(Token = "0x400523F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6770", Offset = "0x5F6770")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6770", Offset = "0x5F6770")]
		public FsmFloat storeValue;

		[Token(Token = "0x4005240")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F67D0", Offset = "0x5F67D0")]
		public bool everyFrame;

		[Token(Token = "0x4005241")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005242")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005243")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006672")]
		[Address(RVA = "0x10612E0", Offset = "0x10612E0", VA = "0x10612E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006673")]
		[Address(RVA = "0x106133C", Offset = "0x106133C", VA = "0x106133C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006674")]
		[Address(RVA = "0x1061548", Offset = "0x1061548", VA = "0x1061548", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006675")]
		[Address(RVA = "0x1061378", Offset = "0x1061378", VA = "0x1061378")]
		private void DoGetFsmFloat()
		{
		}

		[Token(Token = "0x6006676")]
		[Address(RVA = "0x106154C", Offset = "0x106154C", VA = "0x106154C")]
		public GetFsmFloat()
		{
		}
	}
}
