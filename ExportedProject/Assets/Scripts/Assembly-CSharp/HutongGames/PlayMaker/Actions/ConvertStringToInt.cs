using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F63")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CD44", Offset = "0x59CD44")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CD44", Offset = "0x59CD44")]
	public class ConvertStringToInt : FsmStateAction
	{
		[Token(Token = "0x40048B8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D019C", Offset = "0x5D019C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D019C", Offset = "0x5D019C")]
		public FsmString stringVariable;

		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D01FC", Offset = "0x5D01FC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D01FC", Offset = "0x5D01FC")]
		public FsmInt intVariable;

		[Token(Token = "0x40048BA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D025C", Offset = "0x5D025C")]
		public bool everyFrame;

		[Token(Token = "0x6005E07")]
		[Address(RVA = "0xD7FE50", Offset = "0xD7FE50", VA = "0xD7FE50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E08")]
		[Address(RVA = "0xD7FE5C", Offset = "0xD7FE5C", VA = "0xD7FE5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E09")]
		[Address(RVA = "0xD7FEDC", Offset = "0xD7FEDC", VA = "0xD7FEDC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0xD7FE98", Offset = "0xD7FE98", VA = "0xD7FE98")]
		private void DoConvertStringToInt()
		{
		}

		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0xD7FEE0", Offset = "0xD7FEE0", VA = "0xD7FEE0")]
		public ConvertStringToInt()
		{
		}
	}
}
