using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F5F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CBE0", Offset = "0x59CBE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CBE0", Offset = "0x59CBE0")]
	public class ConvertIntToFloat : FsmStateAction
	{
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFD38", Offset = "0x5CFD38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFD38", Offset = "0x5CFD38")]
		[RequiredField]
		public FsmInt intVariable;

		[Token(Token = "0x40048AB")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFD98", Offset = "0x5CFD98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFD98", Offset = "0x5CFD98")]
		public FsmFloat floatVariable;

		[Token(Token = "0x40048AC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFDF8", Offset = "0x5CFDF8")]
		public bool everyFrame;

		[Token(Token = "0x6005DF3")]
		[Address(RVA = "0xD7F6B4", Offset = "0xD7F6B4", VA = "0xD7F6B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0xD7F6C0", Offset = "0xD7F6C0", VA = "0xD7F6C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0xD7F73C", Offset = "0xD7F73C", VA = "0xD7F73C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0xD7F6FC", Offset = "0xD7F6FC", VA = "0xD7F6FC")]
		private void DoConvertIntToFloat()
		{
		}

		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0xD7F740", Offset = "0xD7F740", VA = "0xD7F740")]
		public ConvertIntToFloat()
		{
		}
	}
}
