using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001133")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5E60", Offset = "0x5A5E60")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5E60", Offset = "0x5A5E60")]
	public class GetSprite : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051B0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4050", Offset = "0x5F4050")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4050", Offset = "0x5F4050")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051B1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F40E4", Offset = "0x5F40E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F40E4", Offset = "0x5F40E4")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F40E4", Offset = "0x5F40E4")]
		public FsmObject sprite;

		[Token(Token = "0x60065F2")]
		[Address(RVA = "0xC7F194", Offset = "0xC7F194", VA = "0xC7F194", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065F3")]
		[Address(RVA = "0xC7F19C", Offset = "0xC7F19C", VA = "0xC7F19C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065F4")]
		[Address(RVA = "0xC7F1C4", Offset = "0xC7F1C4", VA = "0xC7F1C4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x60065F5")]
		[Address(RVA = "0xC7F250", Offset = "0xC7F250", VA = "0xC7F250")]
		public GetSprite()
		{
		}
	}
}
