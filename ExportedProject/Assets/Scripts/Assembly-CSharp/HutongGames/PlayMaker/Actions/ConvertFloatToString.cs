using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F5E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CB90", Offset = "0x59CB90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CB90", Offset = "0x59CB90")]
	public class ConvertFloatToString : FsmStateAction
	{
		[Token(Token = "0x40048A6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFC08", Offset = "0x5CFC08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFC08", Offset = "0x5CFC08")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x40048A7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFC68", Offset = "0x5CFC68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFC68", Offset = "0x5CFC68")]
		public FsmString stringVariable;

		[Token(Token = "0x40048A8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFCC8", Offset = "0x5CFCC8")]
		public FsmString format;

		[Token(Token = "0x40048A9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFD00", Offset = "0x5CFD00")]
		public bool everyFrame;

		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0xD7F594", Offset = "0xD7F594", VA = "0xD7F594", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DEF")]
		[Address(RVA = "0xD7F5A4", Offset = "0xD7F5A4", VA = "0xD7F5A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DF0")]
		[Address(RVA = "0xD7F6A8", Offset = "0xD7F6A8", VA = "0xD7F6A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DF1")]
		[Address(RVA = "0xD7F5E0", Offset = "0xD7F5E0", VA = "0xD7F5E0")]
		private void DoConvertFloatToString()
		{
		}

		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0xD7F6AC", Offset = "0xD7F6AC", VA = "0xD7F6AC")]
		public ConvertFloatToString()
		{
		}
	}
}
