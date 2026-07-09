using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E988", Offset = "0x59E988")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E988", Offset = "0x59E988")]
	public class GUILayoutPasswordField : GUILayoutAction
	{
		[Token(Token = "0x4004A21")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D53A8", Offset = "0x5D53A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D53A8", Offset = "0x5D53A8")]
		public FsmString text;

		[Token(Token = "0x4004A22")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D53F8", Offset = "0x5D53F8")]
		public FsmInt maxLength;

		[Token(Token = "0x4004A23")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5430", Offset = "0x5D5430")]
		public FsmString style;

		[Token(Token = "0x4004A24")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5468", Offset = "0x5D5468")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004A25")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D54A0", Offset = "0x5D54A0")]
		public FsmString mask;

		[Token(Token = "0x6005F36")]
		[Address(RVA = "0xD91764", Offset = "0xD91764", VA = "0xD91764", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F37")]
		[Address(RVA = "0xD917F0", Offset = "0xD917F0", VA = "0xD917F0", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F38")]
		[Address(RVA = "0xD919C4", Offset = "0xD919C4", VA = "0xD919C4")]
		public GUILayoutPasswordField()
		{
		}
	}
}
