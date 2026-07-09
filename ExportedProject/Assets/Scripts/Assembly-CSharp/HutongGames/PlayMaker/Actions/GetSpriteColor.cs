using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001134")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5EB0", Offset = "0x5A5EB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5EB0", Offset = "0x5A5EB0")]
	public class GetSpriteColor : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051B2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F418C", Offset = "0x5F418C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F418C", Offset = "0x5F418C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051B3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4220", Offset = "0x5F4220")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4220", Offset = "0x5F4220")]
		public FsmColor color;

		[Token(Token = "0x40051B4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4270", Offset = "0x5F4270")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4270", Offset = "0x5F4270")]
		public FsmFloat red;

		[Token(Token = "0x40051B5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F42C0", Offset = "0x5F42C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F42C0", Offset = "0x5F42C0")]
		public FsmFloat green;

		[Token(Token = "0x40051B6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4310", Offset = "0x5F4310")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4310", Offset = "0x5F4310")]
		public FsmFloat blue;

		[Token(Token = "0x40051B7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F4360", Offset = "0x5F4360")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4360", Offset = "0x5F4360")]
		public FsmFloat alpha;

		[Token(Token = "0x40051B8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F43B0", Offset = "0x5F43B0")]
		public bool everyFrame;

		[Token(Token = "0x60065F6")]
		[Address(RVA = "0xC7F29C", Offset = "0xC7F29C", VA = "0xC7F29C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065F7")]
		[Address(RVA = "0xC7F37C", Offset = "0xC7F37C", VA = "0xC7F37C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065F8")]
		[Address(RVA = "0xC7F51C", Offset = "0xC7F51C", VA = "0xC7F51C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065F9")]
		[Address(RVA = "0xC7F3B8", Offset = "0xC7F3B8", VA = "0xC7F3B8")]
		private void GetColor()
		{
		}

		[Token(Token = "0x60065FA")]
		[Address(RVA = "0xC7F520", Offset = "0xC7F520", VA = "0xC7F520")]
		public GetSpriteColor()
		{
		}
	}
}
