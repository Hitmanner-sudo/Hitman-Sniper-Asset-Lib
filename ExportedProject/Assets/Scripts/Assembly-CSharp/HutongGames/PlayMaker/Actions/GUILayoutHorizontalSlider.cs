using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E848", Offset = "0x59E848")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E848", Offset = "0x59E848")]
	public class GUILayoutHorizontalSlider : GUILayoutAction
	{
		[Token(Token = "0x4004A13")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5008", Offset = "0x5D5008")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5008", Offset = "0x5D5008")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004A14")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5068", Offset = "0x5D5068")]
		public FsmFloat leftValue;

		[Token(Token = "0x4004A15")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D50B4", Offset = "0x5D50B4")]
		public FsmFloat rightValue;

		[Token(Token = "0x4004A16")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5100", Offset = "0x5D5100")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0xD90F30", Offset = "0xD90F30", VA = "0xD90F30", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0xD90F78", Offset = "0xD90F78", VA = "0xD90F78", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0xD91108", Offset = "0xD91108", VA = "0xD91108")]
		public GUILayoutHorizontalSlider()
		{
		}
	}
}
