using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E8E8", Offset = "0x59E8E8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E8E8", Offset = "0x59E8E8")]
	public class GUILayoutIntLabel : GUILayoutAction
	{
		[Token(Token = "0x4004A1A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D51F8", Offset = "0x5D51F8")]
		public FsmString prefix;

		[Token(Token = "0x4004A1B")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5230", Offset = "0x5D5230")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5230", Offset = "0x5D5230")]
		public FsmInt intVariable;

		[Token(Token = "0x4004A1C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5290", Offset = "0x5D5290")]
		public FsmString style;

		[Token(Token = "0x6005F30")]
		[Address(RVA = "0xD91380", Offset = "0xD91380", VA = "0xD91380", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F31")]
		[Address(RVA = "0xD913EC", Offset = "0xD913EC", VA = "0xD913EC", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F32")]
		[Address(RVA = "0xD91560", Offset = "0xD91560", VA = "0xD91560")]
		public GUILayoutIntLabel()
		{
		}
	}
}
