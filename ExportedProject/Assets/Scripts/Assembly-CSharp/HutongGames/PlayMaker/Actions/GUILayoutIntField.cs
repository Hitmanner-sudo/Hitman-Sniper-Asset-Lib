using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E898", Offset = "0x59E898")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E898", Offset = "0x59E898")]
	public class GUILayoutIntField : GUILayoutAction
	{
		[Token(Token = "0x4004A17")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5138", Offset = "0x5D5138")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5138", Offset = "0x5D5138")]
		public FsmInt intVariable;

		[Token(Token = "0x4004A18")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5188", Offset = "0x5D5188")]
		public FsmString style;

		[Token(Token = "0x4004A19")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D51C0", Offset = "0x5D51C0")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0xD91110", Offset = "0xD91110", VA = "0xD91110", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0xD91170", Offset = "0xD91170", VA = "0xD91170", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0xD91378", Offset = "0xD91378", VA = "0xD91378")]
		public GUILayoutIntField()
		{
		}
	}
}
