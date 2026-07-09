using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6130", Offset = "0x5A6130")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6130", Offset = "0x5A6130")]
	public class SetSpriteFlip : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051D2")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4D78", Offset = "0x5F4D78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4D78", Offset = "0x5F4D78")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051D3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4E0C", Offset = "0x5F4E0C")]
		public FsmBool x;

		[Token(Token = "0x40051D4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4E44", Offset = "0x5F4E44")]
		public FsmBool y;

		[Token(Token = "0x40051D5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4E7C", Offset = "0x5F4E7C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40051D6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4EB4", Offset = "0x5F4EB4")]
		public bool everyFrame;

		[Token(Token = "0x40051D7")]
		[FieldOffset(Offset = "0x89")]
		private bool x_orig;

		[Token(Token = "0x40051D8")]
		[FieldOffset(Offset = "0x8A")]
		private bool y_orig;

		[Token(Token = "0x6006615")]
		[Address(RVA = "0x104548C", Offset = "0x104548C", VA = "0x104548C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006616")]
		[Address(RVA = "0x10454C0", Offset = "0x10454C0", VA = "0x10454C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006617")]
		[Address(RVA = "0x104563C", Offset = "0x104563C", VA = "0x104563C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006618")]
		[Address(RVA = "0x1045640", Offset = "0x1045640", VA = "0x1045640", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006619")]
		[Address(RVA = "0x104559C", Offset = "0x104559C", VA = "0x104559C")]
		private void FlipSprites()
		{
		}

		[Token(Token = "0x600661A")]
		[Address(RVA = "0x10456A4", Offset = "0x10456A4", VA = "0x10456A4")]
		public SetSpriteFlip()
		{
		}
	}
}
