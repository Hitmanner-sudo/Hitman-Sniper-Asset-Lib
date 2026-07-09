using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EA78", Offset = "0x59EA78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EA78", Offset = "0x59EA78")]
	public class GUILayoutTextField : GUILayoutAction
	{
		[Token(Token = "0x4004A2D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5678", Offset = "0x5D5678")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5678", Offset = "0x5D5678")]
		public FsmString text;

		[Token(Token = "0x4004A2E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D56C8", Offset = "0x5D56C8")]
		public FsmInt maxLength;

		[Token(Token = "0x4004A2F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5700", Offset = "0x5D5700")]
		public FsmString style;

		[Token(Token = "0x4004A30")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5738", Offset = "0x5D5738")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0xD91C50", Offset = "0xD91C50", VA = "0xD91C50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F40")]
		[Address(RVA = "0xD91CC0", Offset = "0xD91CC0", VA = "0xD91CC0", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F41")]
		[Address(RVA = "0xD91E84", Offset = "0xD91E84", VA = "0xD91E84")]
		public GUILayoutTextField()
		{
		}
	}
}
