using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001137")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5FA0", Offset = "0x5A5FA0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5FA0", Offset = "0x5A5FA0")]
	public class GetSpriteOrderInLayer : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051BF")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4680", Offset = "0x5F4680")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4680", Offset = "0x5F4680")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051C0")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4714", Offset = "0x5F4714")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4714", Offset = "0x5F4714")]
		public FsmInt orderInLayer;

		[Token(Token = "0x6006603")]
		[Address(RVA = "0xC7F804", Offset = "0xC7F804", VA = "0xC7F804", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006604")]
		[Address(RVA = "0xC7F80C", Offset = "0xC7F80C", VA = "0xC7F80C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006605")]
		[Address(RVA = "0xC7F8AC", Offset = "0xC7F8AC", VA = "0xC7F8AC")]
		public GetSpriteOrderInLayer()
		{
		}
	}
}
