using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001201")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAA04", Offset = "0x5AAA04")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAA04", Offset = "0x5AAA04")]
	public class UiNavigationExplicitGetProperties : ComponentAction<Selectable>
	{
		[Token(Token = "0x400560E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6022F0", Offset = "0x6022F0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6022F0", Offset = "0x6022F0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400560F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602384", Offset = "0x602384")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602384", Offset = "0x602384")]
		public FsmGameObject selectOnDown;

		[Token(Token = "0x4005610")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6023D4", Offset = "0x6023D4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6023D4", Offset = "0x6023D4")]
		public FsmGameObject selectOnUp;

		[Token(Token = "0x4005611")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602424", Offset = "0x602424")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602424", Offset = "0x602424")]
		public FsmGameObject selectOnLeft;

		[Token(Token = "0x4005612")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602474", Offset = "0x602474")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602474", Offset = "0x602474")]
		public FsmGameObject selectOnRight;

		[Token(Token = "0x4005613")]
		[FieldOffset(Offset = "0x90")]
		private Selectable _selectable;

		[Token(Token = "0x60069AC")]
		[Address(RVA = "0xB92ACC", Offset = "0xB92ACC", VA = "0xB92ACC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069AD")]
		[Address(RVA = "0xB92AE0", Offset = "0xB92AE0", VA = "0xB92AE0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069AE")]
		[Address(RVA = "0xB92BA8", Offset = "0xB92BA8", VA = "0xB92BA8")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x60069AF")]
		[Address(RVA = "0xB92E34", Offset = "0xB92E34", VA = "0xB92E34")]
		public UiNavigationExplicitGetProperties()
		{
		}
	}
}
