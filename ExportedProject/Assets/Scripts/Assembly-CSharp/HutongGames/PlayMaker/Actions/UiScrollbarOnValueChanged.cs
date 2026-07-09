using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABC34", Offset = "0x5ABC34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABC34", Offset = "0x5ABC34")]
	public class UiScrollbarOnValueChanged : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x4005754")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60744C", Offset = "0x60744C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60744C", Offset = "0x60744C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005755")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6074E0", Offset = "0x6074E0")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4005756")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607518", Offset = "0x607518")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4005757")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607550", Offset = "0x607550")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607550", Offset = "0x607550")]
		public FsmFloat value;

		[Token(Token = "0x4005758")]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar scrollbar;

		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0xB96434", Offset = "0xB96434", VA = "0xB96434", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0xB96444", Offset = "0xB96444", VA = "0xB96444", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0xB9659C", Offset = "0xB9659C", VA = "0xB9659C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0xB966B4", Offset = "0xB966B4", VA = "0xB966B4")]
		public void DoOnValueChanged(float _value)
		{
		}

		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0xB96760", Offset = "0xB96760", VA = "0xB96760")]
		public UiScrollbarOnValueChanged()
		{
		}
	}
}
