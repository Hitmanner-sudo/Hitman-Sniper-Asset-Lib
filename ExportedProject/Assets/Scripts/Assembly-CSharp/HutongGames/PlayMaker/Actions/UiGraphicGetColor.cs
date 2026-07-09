using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001215")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB004", Offset = "0x5AB004")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB004", Offset = "0x5AB004")]
	public class UiGraphicGetColor : ComponentAction<Graphic>
	{
		[Token(Token = "0x400568C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6041E0", Offset = "0x6041E0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6041E0", Offset = "0x6041E0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400568D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604274", Offset = "0x604274")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x604274", Offset = "0x604274")]
		[RequiredField]
		public FsmColor color;

		[Token(Token = "0x400568E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6042D4", Offset = "0x6042D4")]
		public bool everyFrame;

		[Token(Token = "0x400568F")]
		[FieldOffset(Offset = "0x80")]
		private Graphic uiComponent;

		[Token(Token = "0x6006A06")]
		[Address(RVA = "0xB8DB40", Offset = "0xB8DB40", VA = "0xB8DB40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A07")]
		[Address(RVA = "0xB8DB48", Offset = "0xB8DB48", VA = "0xB8DB48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A08")]
		[Address(RVA = "0xB8DC84", Offset = "0xB8DC84", VA = "0xB8DC84", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A09")]
		[Address(RVA = "0xB8DBE4", Offset = "0xB8DBE4", VA = "0xB8DBE4")]
		private void DoGetColorValue()
		{
		}

		[Token(Token = "0x6006A0A")]
		[Address(RVA = "0xB8DC88", Offset = "0xB8DC88", VA = "0xB8DC88")]
		public UiGraphicGetColor()
		{
		}
	}
}
