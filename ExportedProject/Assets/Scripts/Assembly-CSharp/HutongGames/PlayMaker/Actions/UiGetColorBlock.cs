using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001203")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAAA4", Offset = "0x5AAAA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAAA4", Offset = "0x5AAAA4")]
	public class UiGetColorBlock : ComponentAction<Selectable>
	{
		[Token(Token = "0x400561D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6027A0", Offset = "0x6027A0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6027A0", Offset = "0x6027A0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400561E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602834", Offset = "0x602834")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602834", Offset = "0x602834")]
		public FsmFloat fadeDuration;

		[Token(Token = "0x400561F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602884", Offset = "0x602884")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602884", Offset = "0x602884")]
		public FsmFloat colorMultiplier;

		[Token(Token = "0x4005620")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6028D4", Offset = "0x6028D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6028D4", Offset = "0x6028D4")]
		public FsmColor normalColor;

		[Token(Token = "0x4005621")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602924", Offset = "0x602924")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602924", Offset = "0x602924")]
		public FsmColor pressedColor;

		[Token(Token = "0x4005622")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602974", Offset = "0x602974")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602974", Offset = "0x602974")]
		public FsmColor highlightedColor;

		[Token(Token = "0x4005623")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6029C4", Offset = "0x6029C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6029C4", Offset = "0x6029C4")]
		public FsmColor disabledColor;

		[Token(Token = "0x4005624")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602A14", Offset = "0x602A14")]
		public bool everyFrame;

		[Token(Token = "0x4005625")]
		[FieldOffset(Offset = "0xA8")]
		private Selectable selectable;

		[Token(Token = "0x60069B6")]
		[Address(RVA = "0x117A444", Offset = "0x117A444", VA = "0x117A444", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069B7")]
		[Address(RVA = "0x117A460", Offset = "0x117A460", VA = "0x117A460", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x117A67C", Offset = "0x117A67C", VA = "0x117A67C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069B9")]
		[Address(RVA = "0x117A4FC", Offset = "0x117A4FC", VA = "0x117A4FC")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x60069BA")]
		[Address(RVA = "0x117A680", Offset = "0x117A680", VA = "0x117A680")]
		public UiGetColorBlock()
		{
		}
	}
}
