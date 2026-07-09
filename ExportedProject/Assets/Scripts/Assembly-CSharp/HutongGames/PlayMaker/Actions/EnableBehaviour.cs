using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5D20", Offset = "0x5A5D20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5D20", Offset = "0x5A5D20")]
	public class EnableBehaviour : FsmStateAction
	{
		[Token(Token = "0x4005195")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3A88", Offset = "0x5F3A88")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005196")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3AD4", Offset = "0x5F3AD4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3AD4", Offset = "0x5F3AD4")]
		public FsmString behaviour;

		[Token(Token = "0x4005197")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3B24", Offset = "0x5F3B24")]
		public Component component;

		[Token(Token = "0x4005198")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3B5C", Offset = "0x5F3B5C")]
		[RequiredField]
		public FsmBool enable;

		[Token(Token = "0x4005199")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3BA8", Offset = "0x5F3BA8")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400519A")]
		[FieldOffset(Offset = "0x78")]
		private Behaviour componentTarget;

		[Token(Token = "0x60065DE")]
		[Address(RVA = "0xE0CFB0", Offset = "0xE0CFB0", VA = "0xE0CFB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065DF")]
		[Address(RVA = "0xE0CFF4", Offset = "0xE0CFF4", VA = "0xE0CFF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065E0")]
		[Address(RVA = "0xE0D03C", Offset = "0xE0D03C", VA = "0xE0D03C")]
		private void DoEnableBehaviour(GameObject go)
		{
		}

		[Token(Token = "0x60065E1")]
		[Address(RVA = "0xE0D2C8", Offset = "0xE0D2C8", VA = "0xE0D2C8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065E2")]
		[Address(RVA = "0xE0D388", Offset = "0xE0D388", VA = "0xE0D388", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60065E3")]
		[Address(RVA = "0xE0D584", Offset = "0xE0D584", VA = "0xE0D584")]
		public EnableBehaviour()
		{
		}
	}
}
