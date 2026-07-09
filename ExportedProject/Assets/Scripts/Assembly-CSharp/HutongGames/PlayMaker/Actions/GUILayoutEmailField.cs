using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FB3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E578", Offset = "0x59E578")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E578", Offset = "0x59E578")]
	public class GUILayoutEmailField : GUILayoutAction
	{
		[Token(Token = "0x4004A08")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4D48", Offset = "0x5D4D48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4D48", Offset = "0x5D4D48")]
		public FsmString text;

		[Token(Token = "0x4004A09")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4D98", Offset = "0x5D4D98")]
		public FsmInt maxLength;

		[Token(Token = "0x4004A0A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4DD0", Offset = "0x5D4DD0")]
		public FsmString style;

		[Token(Token = "0x4004A0B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4E08", Offset = "0x5D4E08")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004A0C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4E40", Offset = "0x5D4E40")]
		public FsmBool valid;

		[Token(Token = "0x6005F10")]
		[Address(RVA = "0xD9081C", Offset = "0xD9081C", VA = "0xD9081C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F11")]
		[Address(RVA = "0xD90894", Offset = "0xD90894", VA = "0xD90894", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F12")]
		[Address(RVA = "0xD90A30", Offset = "0xD90A30", VA = "0xD90A30")]
		public GUILayoutEmailField()
		{
		}
	}
}
