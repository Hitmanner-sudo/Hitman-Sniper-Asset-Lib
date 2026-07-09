using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABB94", Offset = "0x5ABB94")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABB94", Offset = "0x5ABB94")]
	public class UiScrollbarGetDirection : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x400574C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6071AC", Offset = "0x6071AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6071AC", Offset = "0x6071AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400574D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x607240", Offset = "0x607240")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607240", Offset = "0x607240")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607240", Offset = "0x607240")]
		[RequiredField]
		public FsmEnum direction;

		[Token(Token = "0x400574E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6072E8", Offset = "0x6072E8")]
		public bool everyFrame;

		[Token(Token = "0x400574F")]
		[FieldOffset(Offset = "0x80")]
		private Scrollbar scrollbar;

		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0xB960E8", Offset = "0xB960E8", VA = "0xB960E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0xB960F4", Offset = "0xB960F4", VA = "0xB960F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0xB96258", Offset = "0xB96258", VA = "0xB96258", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0xB96190", Offset = "0xB96190", VA = "0xB96190")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AC5")]
		[Address(RVA = "0xB9625C", Offset = "0xB9625C", VA = "0xB9625C")]
		public UiScrollbarGetDirection()
		{
		}
	}
}
