using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001060")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1CF0", Offset = "0x5A1CF0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1CF0", Offset = "0x5A1CF0")]
	public class SelectRandomInt : FsmStateAction
	{
		[Token(Token = "0x4004CDF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5E08EC", Offset = "0x5E08EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E08EC", Offset = "0x5E08EC")]
		public FsmInt[] ints;

		[Token(Token = "0x4004CE0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E097C", Offset = "0x5E097C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E097C", Offset = "0x5E097C")]
		public FsmFloat[] weights;

		[Token(Token = "0x4004CE1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E09D0", Offset = "0x5E09D0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E09D0", Offset = "0x5E09D0")]
		public FsmInt storeInt;

		[Token(Token = "0x60061E6")]
		[Address(RVA = "0xB70040", Offset = "0xB70040", VA = "0xB70040", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061E7")]
		[Address(RVA = "0xB70188", Offset = "0xB70188", VA = "0xB70188", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061E8")]
		[Address(RVA = "0xB701B0", Offset = "0xB701B0", VA = "0xB701B0")]
		private void DoSelectRandomString()
		{
		}

		[Token(Token = "0x60061E9")]
		[Address(RVA = "0xB7023C", Offset = "0xB7023C", VA = "0xB7023C")]
		public SelectRandomInt()
		{
		}
	}
}
