using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A61D0", Offset = "0x5A61D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A61D0", Offset = "0x5A61D0")]
	public class SetSpriteOrderInLayer : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051DB")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F5004", Offset = "0x5F5004")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5004", Offset = "0x5F5004")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051DC")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5098", Offset = "0x5F5098")]
		public FsmInt orderInLayer;

		[Token(Token = "0x600661E")]
		[Address(RVA = "0x1045890", Offset = "0x1045890", VA = "0x1045890", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600661F")]
		[Address(RVA = "0x1045898", Offset = "0x1045898", VA = "0x1045898", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006620")]
		[Address(RVA = "0x1045944", Offset = "0x1045944", VA = "0x1045944")]
		public SetSpriteOrderInLayer()
		{
		}
	}
}
