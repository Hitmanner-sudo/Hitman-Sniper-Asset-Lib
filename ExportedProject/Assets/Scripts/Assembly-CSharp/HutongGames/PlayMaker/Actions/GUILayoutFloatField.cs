using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E7A8", Offset = "0x59E7A8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E7A8", Offset = "0x59E7A8")]
	public class GUILayoutFloatField : GUILayoutAction
	{
		[Token(Token = "0x4004A0D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4E78", Offset = "0x5D4E78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4E78", Offset = "0x5D4E78")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004A0E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4EC8", Offset = "0x5D4EC8")]
		public FsmString style;

		[Token(Token = "0x4004A0F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4F00", Offset = "0x5D4F00")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F24")]
		[Address(RVA = "0xD90AD8", Offset = "0xD90AD8", VA = "0xD90AD8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F25")]
		[Address(RVA = "0xD90B38", Offset = "0xD90B38", VA = "0xD90B38", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F26")]
		[Address(RVA = "0xD90D40", Offset = "0xD90D40", VA = "0xD90D40")]
		public GUILayoutFloatField()
		{
		}
	}
}
