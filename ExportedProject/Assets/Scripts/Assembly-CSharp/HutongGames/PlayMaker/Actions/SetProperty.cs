using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001254")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC3B4", Offset = "0x5AC3B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC3B4", Offset = "0x5AC3B4")]
	public class SetProperty : FsmStateAction
	{
		[Token(Token = "0x40057CD")]
		[FieldOffset(Offset = "0x50")]
		public FsmProperty targetProperty;

		[Token(Token = "0x40057CE")]
		[FieldOffset(Offset = "0x58")]
		public bool everyFrame;

		[Token(Token = "0x40057CF")]
		[FieldOffset(Offset = "0x60")]
		public string dataModelPath;

		[Token(Token = "0x6006B47")]
		[Address(RVA = "0x1042ADC", Offset = "0x1042ADC", VA = "0x1042ADC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B48")]
		[Address(RVA = "0x1042B4C", Offset = "0x1042B4C", VA = "0x1042B4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B49")]
		[Address(RVA = "0x1042D14", Offset = "0x1042D14", VA = "0x1042D14", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0x1042B88", Offset = "0x1042B88", VA = "0x1042B88")]
		private void SetValue()
		{
		}

		[Token(Token = "0x6006B4B")]
		[Address(RVA = "0x1042D18", Offset = "0x1042D18", VA = "0x1042D18")]
		private void FireVariableChanged(DataModel dataModel)
		{
		}

		[Token(Token = "0x6006B4C")]
		[Address(RVA = "0x104388C", Offset = "0x104388C", VA = "0x104388C")]
		public SetProperty()
		{
		}
	}
}
