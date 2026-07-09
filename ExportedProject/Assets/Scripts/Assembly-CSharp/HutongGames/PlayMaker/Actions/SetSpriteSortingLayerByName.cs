using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001141")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A62C0", Offset = "0x5A62C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A62C0", Offset = "0x5A62C0")]
	public class SetSpriteSortingLayerByName : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051E2")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F5314", Offset = "0x5F5314")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5314", Offset = "0x5F5314")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051E3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F53A8", Offset = "0x5F53A8")]
		[RequiredField]
		public FsmString sortingLayerName;

		[Token(Token = "0x40051E4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F53F4", Offset = "0x5F53F4")]
		public FsmBool setAllSpritesInChildren;

		[Token(Token = "0x6006627")]
		[Address(RVA = "0x83AA0C", Offset = "0x83AA0C", VA = "0x83AA0C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006628")]
		[Address(RVA = "0x83AA3C", Offset = "0x83AA3C", VA = "0x83AA3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006629")]
		[Address(RVA = "0x83AB98", Offset = "0x83AB98", VA = "0x83AB98")]
		public SetSpriteSortingLayerByName()
		{
		}
	}
}
