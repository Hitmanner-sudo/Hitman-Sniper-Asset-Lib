using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001046")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1570", Offset = "0x5A1570")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1570", Offset = "0x5A1570")]
	public class SetTextureValue : FsmStateAction
	{
		[Token(Token = "0x4004C73")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEF08", Offset = "0x5DEF08")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DEF08", Offset = "0x5DEF08")]
		[RequiredField]
		public FsmTexture textureVariable;

		[Token(Token = "0x4004C74")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEF68", Offset = "0x5DEF68")]
		[RequiredField]
		public FsmTexture textureValue;

		[Token(Token = "0x4004C75")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEFB4", Offset = "0x5DEFB4")]
		public bool everyFrame;

		[Token(Token = "0x600617A")]
		[Address(RVA = "0x83C1B4", Offset = "0x83C1B4", VA = "0x83C1B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600617B")]
		[Address(RVA = "0x83C1C0", Offset = "0x83C1C0", VA = "0x83C1C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600617C")]
		[Address(RVA = "0x83C224", Offset = "0x83C224", VA = "0x83C224", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600617D")]
		[Address(RVA = "0x83C268", Offset = "0x83C268", VA = "0x83C268")]
		public SetTextureValue()
		{
		}
	}
}
