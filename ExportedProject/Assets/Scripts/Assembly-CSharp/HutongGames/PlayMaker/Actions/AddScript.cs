using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5BE0", Offset = "0x5A5BE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5BE0", Offset = "0x5A5BE0")]
	public class AddScript : FsmStateAction
	{
		[Token(Token = "0x4005170")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F34B8", Offset = "0x5F34B8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005171")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3504", Offset = "0x5F3504")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3504", Offset = "0x5F3504")]
		[RequiredField]
		public FsmString script;

		[Token(Token = "0x4005172")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3564", Offset = "0x5F3564")]
		public FsmBool removeOnExit;

		[Token(Token = "0x4005173")]
		[FieldOffset(Offset = "0x68")]
		private Component addedComponent;

		[Token(Token = "0x60065C7")]
		[Address(RVA = "0xD5D3C0", Offset = "0xD5D3C0", VA = "0xD5D3C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065C8")]
		[Address(RVA = "0xD5D3C8", Offset = "0xD5D3C8", VA = "0xD5D3C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065C9")]
		[Address(RVA = "0xD5D564", Offset = "0xD5D564", VA = "0xD5D564", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065CA")]
		[Address(RVA = "0xD5D424", Offset = "0xD5D424", VA = "0xD5D424")]
		private void DoAddComponent(GameObject go)
		{
		}

		[Token(Token = "0x60065CB")]
		[Address(RVA = "0xD5D62C", Offset = "0xD5D62C", VA = "0xD5D62C")]
		public AddScript()
		{
		}
	}
}
