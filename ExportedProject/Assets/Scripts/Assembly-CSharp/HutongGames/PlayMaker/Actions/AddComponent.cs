using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ECF8", Offset = "0x59ECF8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ECF8", Offset = "0x59ECF8")]
	public class AddComponent : FsmStateAction
	{
		[Token(Token = "0x4004A55")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5E94", Offset = "0x5D5E94")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A56")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5EE0", Offset = "0x5D5EE0")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5D5EE0", Offset = "0x5D5EE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5EE0", Offset = "0x5D5EE0")]
		[RequiredField]
		public FsmString component;

		[Token(Token = "0x4004A57")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5D5F64", Offset = "0x5D5F64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5F64", Offset = "0x5D5F64")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5F64", Offset = "0x5D5F64")]
		public FsmObject storeComponent;

		[Token(Token = "0x4004A58")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5FFC", Offset = "0x5D5FFC")]
		public FsmBool removeOnExit;

		[Token(Token = "0x4004A59")]
		[FieldOffset(Offset = "0x70")]
		private Component addedComponent;

		[Token(Token = "0x6005F63")]
		[Address(RVA = "0xD5C204", Offset = "0xD5C204", VA = "0xD5C204", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F64")]
		[Address(RVA = "0xD5C210", Offset = "0xD5C210", VA = "0xD5C210", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F65")]
		[Address(RVA = "0xD5C3C8", Offset = "0xD5C3C8", VA = "0xD5C3C8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005F66")]
		[Address(RVA = "0xD5C238", Offset = "0xD5C238", VA = "0xD5C238")]
		private void DoAddComponent()
		{
		}

		[Token(Token = "0x6005F67")]
		[Address(RVA = "0xD5C490", Offset = "0xD5C490", VA = "0xD5C490")]
		public AddComponent()
		{
		}
	}
}
