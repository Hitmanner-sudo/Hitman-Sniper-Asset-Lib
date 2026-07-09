using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FEF")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x59F8A0", Offset = "0x59F8A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59F8A0", Offset = "0x59F8A0")]
	public class SetTagsOnChildren : FsmStateAction
	{
		[Token(Token = "0x4004ADA")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5D82C4", Offset = "0x5D82C4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004ADB")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5D8310", Offset = "0x5D8310")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5D8310", Offset = "0x5D8310")]
		[RequiredField]
		public FsmString tag;

		[Token(Token = "0x4004ADC")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5D8370", Offset = "0x5D8370")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5D8370", Offset = "0x5D8370")]
		public FsmString filterByComponent;

		[Token(Token = "0x4004ADD")]
		[FieldOffset(Offset = "0x68")]
		private Type componentFilter;

		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x83B338", Offset = "0x83B338", VA = "0x83B338", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x83B344", Offset = "0x83B344", VA = "0x83B344", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x83B38C", Offset = "0x83B38C", VA = "0x83B38C")]
		private void SetTag(GameObject parent)
		{
		}

		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x83B7B8", Offset = "0x83B7B8", VA = "0x83B7B8")]
		private void UpdateComponentFilter()
		{
		}

		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0x83B9B0", Offset = "0x83B9B0", VA = "0x83B9B0")]
		public SetTagsOnChildren()
		{
		}
	}
}
