using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001136")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5F50", Offset = "0x5A5F50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5F50", Offset = "0x5A5F50")]
	public class GetSpriteMaskInteraction : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051BD")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4554", Offset = "0x5F4554")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4554", Offset = "0x5F4554")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051BE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F45E8", Offset = "0x5F45E8")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F45E8", Offset = "0x5F45E8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F45E8", Offset = "0x5F45E8")]
		public FsmEnum spriteMaskInteraction;

		[Token(Token = "0x6006600")]
		[Address(RVA = "0xC7F6DC", Offset = "0xC7F6DC", VA = "0xC7F6DC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006601")]
		[Address(RVA = "0xC7F6E4", Offset = "0xC7F6E4", VA = "0xC7F6E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006602")]
		[Address(RVA = "0xC7F7B8", Offset = "0xC7F7B8", VA = "0xC7F7B8")]
		public GetSpriteMaskInteraction()
		{
		}
	}
}
