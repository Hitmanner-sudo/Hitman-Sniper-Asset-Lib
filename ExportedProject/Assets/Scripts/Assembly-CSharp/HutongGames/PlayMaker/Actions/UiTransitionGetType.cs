using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200120A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AACD4", Offset = "0x5AACD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AACD4", Offset = "0x5AACD4")]
	public class UiTransitionGetType : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005653")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60338C", Offset = "0x60338C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60338C", Offset = "0x60338C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005654")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603420", Offset = "0x603420")]
		public FsmString transition;

		[Token(Token = "0x4005655")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603458", Offset = "0x603458")]
		public FsmEvent colorTintEvent;

		[Token(Token = "0x4005656")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603490", Offset = "0x603490")]
		public FsmEvent spriteSwapEvent;

		[Token(Token = "0x4005657")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6034C8", Offset = "0x6034C8")]
		public FsmEvent animationEvent;

		[Token(Token = "0x4005658")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603500", Offset = "0x603500")]
		public FsmEvent noTransitionEvent;

		[Token(Token = "0x4005659")]
		[FieldOffset(Offset = "0x98")]
		private Selectable selectable;

		[Token(Token = "0x60069D8")]
		[Address(RVA = "0xB9A6A4", Offset = "0xB9A6A4", VA = "0xB9A6A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069D9")]
		[Address(RVA = "0xB9A6B8", Offset = "0xB9A6B8", VA = "0xB9A6B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069DA")]
		[Address(RVA = "0xB9A740", Offset = "0xB9A740", VA = "0xB9A740")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x60069DB")]
		[Address(RVA = "0xB9A89C", Offset = "0xB9A89C", VA = "0xB9A89C")]
		public UiTransitionGetType()
		{
		}
	}
}
