using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001140")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6270", Offset = "0x5A6270")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6270", Offset = "0x5A6270")]
	public class SetSpriteSortingLayerById : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051DF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F51FC", Offset = "0x5F51FC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F51FC", Offset = "0x5F51FC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051E0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5290", Offset = "0x5F5290")]
		[RequiredField]
		public FsmInt sortingLayerId;

		[Token(Token = "0x40051E1")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F52DC", Offset = "0x5F52DC")]
		public FsmBool setAllSpritesInChildren;

		[Token(Token = "0x6006624")]
		[Address(RVA = "0x1045B30", Offset = "0x1045B30", VA = "0x1045B30", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006625")]
		[Address(RVA = "0x1045B60", Offset = "0x1045B60", VA = "0x1045B60", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006626")]
		[Address(RVA = "0x1045CBC", Offset = "0x1045CBC", VA = "0x1045CBC")]
		public SetSpriteSortingLayerById()
		{
		}
	}
}
