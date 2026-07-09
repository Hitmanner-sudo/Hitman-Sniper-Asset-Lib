using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001135")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5F00", Offset = "0x5A5F00")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5F00", Offset = "0x5A5F00")]
	public class GetSpriteFlip : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051B9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F43E8", Offset = "0x5F43E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F43E8", Offset = "0x5F43E8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051BA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F447C", Offset = "0x5F447C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F447C", Offset = "0x5F447C")]
		public FsmBool x;

		[Token(Token = "0x40051BB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F44CC", Offset = "0x5F44CC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F44CC", Offset = "0x5F44CC")]
		public FsmBool y;

		[Token(Token = "0x40051BC")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F451C", Offset = "0x5F451C")]
		public bool everyFrame;

		[Token(Token = "0x60065FB")]
		[Address(RVA = "0xC7F56C", Offset = "0xC7F56C", VA = "0xC7F56C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065FC")]
		[Address(RVA = "0xC7F578", Offset = "0xC7F578", VA = "0xC7F578", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065FD")]
		[Address(RVA = "0xC7F68C", Offset = "0xC7F68C", VA = "0xC7F68C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065FE")]
		[Address(RVA = "0xC7F5B4", Offset = "0xC7F5B4", VA = "0xC7F5B4")]
		private void GetFlip()
		{
		}

		[Token(Token = "0x60065FF")]
		[Address(RVA = "0xC7F690", Offset = "0xC7F690", VA = "0xC7F690")]
		public GetSpriteFlip()
		{
		}
	}
}
