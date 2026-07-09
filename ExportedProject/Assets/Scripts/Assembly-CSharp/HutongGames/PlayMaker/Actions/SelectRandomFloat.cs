using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1CA0", Offset = "0x5A1CA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1CA0", Offset = "0x5A1CA0")]
	public class SelectRandomFloat : FsmStateAction
	{
		[Token(Token = "0x4004CDC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E07A8", Offset = "0x5E07A8")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5E07A8", Offset = "0x5E07A8")]
		public FsmFloat[] floats;

		[Token(Token = "0x4004CDD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E0838", Offset = "0x5E0838")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0838", Offset = "0x5E0838")]
		public FsmFloat[] weights;

		[Token(Token = "0x4004CDE")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E088C", Offset = "0x5E088C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E088C", Offset = "0x5E088C")]
		public FsmFloat storeFloat;

		[Token(Token = "0x60061E2")]
		[Address(RVA = "0xB6FC38", Offset = "0xB6FC38", VA = "0xB6FC38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061E3")]
		[Address(RVA = "0xB6FD6C", Offset = "0xB6FD6C", VA = "0xB6FD6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061E4")]
		[Address(RVA = "0xB6FD94", Offset = "0xB6FD94", VA = "0xB6FD94")]
		private void DoSelectRandomString()
		{
		}

		[Token(Token = "0x60061E5")]
		[Address(RVA = "0xB6FE20", Offset = "0xB6FE20", VA = "0xB6FE20")]
		public SelectRandomFloat()
		{
		}
	}
}
