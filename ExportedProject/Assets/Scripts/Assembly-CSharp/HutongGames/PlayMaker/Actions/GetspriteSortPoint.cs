using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001139")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6040", Offset = "0x5A6040")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6040", Offset = "0x5A6040")]
	public class GetspriteSortPoint : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051C4")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F48A8", Offset = "0x5F48A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F48A8", Offset = "0x5F48A8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051C5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F493C", Offset = "0x5F493C")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F493C", Offset = "0x5F493C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F493C", Offset = "0x5F493C")]
		public FsmEnum spriteSortPoint;

		[Token(Token = "0x6006609")]
		[Address(RVA = "0xC81FEC", Offset = "0xC81FEC", VA = "0xC81FEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600660A")]
		[Address(RVA = "0xC81FF4", Offset = "0xC81FF4", VA = "0xC81FF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600660B")]
		[Address(RVA = "0xC820C8", Offset = "0xC820C8", VA = "0xC820C8")]
		public GetspriteSortPoint()
		{
		}
	}
}
