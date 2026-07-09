using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3330", Offset = "0x5A3330")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3330", Offset = "0x5A3330")]
	public class SetCollider2dIsTrigger : FsmStateAction
	{
		[Token(Token = "0x4004ECC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8D3C", Offset = "0x5E8D3C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E8D3C", Offset = "0x5E8D3C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004ECD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8DD0", Offset = "0x5E8DD0")]
		[RequiredField]
		public FsmBool isTrigger;

		[Token(Token = "0x4004ECE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8E1C", Offset = "0x5E8E1C")]
		public bool setAllColliders;

		[Token(Token = "0x600636E")]
		[Address(RVA = "0x1038820", Offset = "0x1038820", VA = "0x1038820", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600636F")]
		[Address(RVA = "0x1038854", Offset = "0x1038854", VA = "0x1038854", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006370")]
		[Address(RVA = "0x103887C", Offset = "0x103887C", VA = "0x103887C")]
		private void DoSetIsTrigger()
		{
		}

		[Token(Token = "0x6006371")]
		[Address(RVA = "0x1038A44", Offset = "0x1038A44", VA = "0x1038A44")]
		public SetCollider2dIsTrigger()
		{
		}
	}
}
