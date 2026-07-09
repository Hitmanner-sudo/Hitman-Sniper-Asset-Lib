using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EB18", Offset = "0x59EB18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EB18", Offset = "0x59EB18")]
	public class GUILayoutToggle : GUILayoutAction
	{
		[Token(Token = "0x4004A33")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D57E0", Offset = "0x5D57E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D57E0", Offset = "0x5D57E0")]
		public FsmBool storeButtonState;

		[Token(Token = "0x4004A34")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5840", Offset = "0x5D5840")]
		public FsmTexture image;

		[Token(Token = "0x4004A35")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5878", Offset = "0x5D5878")]
		public FsmString text;

		[Token(Token = "0x4004A36")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D58B0", Offset = "0x5D58B0")]
		public FsmString tooltip;

		[Token(Token = "0x4004A37")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D58E8", Offset = "0x5D58E8")]
		public FsmString style;

		[Token(Token = "0x4004A38")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5920", Offset = "0x5D5920")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F45")]
		[Address(RVA = "0xD92034", Offset = "0xD92034", VA = "0xD92034", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F46")]
		[Address(RVA = "0xD920C8", Offset = "0xD920C8", VA = "0xD920C8", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F47")]
		[Address(RVA = "0xD92300", Offset = "0xD92300", VA = "0xD92300")]
		public GUILayoutToggle()
		{
		}
	}
}
