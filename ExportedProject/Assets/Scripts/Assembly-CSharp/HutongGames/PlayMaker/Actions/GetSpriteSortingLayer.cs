using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001138")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5FF0", Offset = "0x5A5FF0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5FF0", Offset = "0x5A5FF0")]
	public class GetSpriteSortingLayer : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051C1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4774", Offset = "0x5F4774")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4774", Offset = "0x5F4774")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051C2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4808", Offset = "0x5F4808")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4808", Offset = "0x5F4808")]
		public FsmString sortingLayerName;

		[Token(Token = "0x40051C3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4858", Offset = "0x5F4858")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4858", Offset = "0x5F4858")]
		public FsmInt sortingLayerId;

		[Token(Token = "0x6006606")]
		[Address(RVA = "0xC7F8F8", Offset = "0xC7F8F8", VA = "0xC7F8F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006607")]
		[Address(RVA = "0xC7F904", Offset = "0xC7F904", VA = "0xC7F904", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006608")]
		[Address(RVA = "0xC7F9E8", Offset = "0xC7F9E8", VA = "0xC7F9E8")]
		public GetSpriteSortingLayer()
		{
		}
	}
}
