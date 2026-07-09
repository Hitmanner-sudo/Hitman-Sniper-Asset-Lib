using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6090", Offset = "0x5A6090")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6090", Offset = "0x5A6090")]
	public class SetSprite : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051C6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F49D4", Offset = "0x5F49D4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F49D4", Offset = "0x5F49D4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051C7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F4A68", Offset = "0x5F4A68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4A68", Offset = "0x5F4A68")]
		public FsmObject sprite;

		[Token(Token = "0x600660C")]
		[Address(RVA = "0x1044F74", Offset = "0x1044F74", VA = "0x1044F74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600660D")]
		[Address(RVA = "0x1044F7C", Offset = "0x1044F7C", VA = "0x1044F7C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600660E")]
		[Address(RVA = "0x1045054", Offset = "0x1045054", VA = "0x1045054")]
		public SetSprite()
		{
		}
	}
}
