using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1700", Offset = "0x5A1700")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1700", Offset = "0x5A1700")]
	public class FloatAddMultiple : FsmStateAction
	{
		[Token(Token = "0x4004C82")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF33C", Offset = "0x5DF33C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF33C", Offset = "0x5DF33C")]
		public FsmFloat[] floatVariables;

		[Token(Token = "0x4004C83")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF38C", Offset = "0x5DF38C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF38C", Offset = "0x5DF38C")]
		[RequiredField]
		public FsmFloat addTo;

		[Token(Token = "0x4004C84")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF3EC", Offset = "0x5DF3EC")]
		public bool everyFrame;

		[Token(Token = "0x6006191")]
		[Address(RVA = "0x958AF0", Offset = "0x958AF0", VA = "0x958AF0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006192")]
		[Address(RVA = "0x958AFC", Offset = "0x958AFC", VA = "0x958AFC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006193")]
		[Address(RVA = "0x958BE0", Offset = "0x958BE0", VA = "0x958BE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006194")]
		[Address(RVA = "0x958B38", Offset = "0x958B38", VA = "0x958B38")]
		private void DoFloatAdd()
		{
		}

		[Token(Token = "0x6006195")]
		[Address(RVA = "0x958BE4", Offset = "0x958BE4", VA = "0x958BE4")]
		public FloatAddMultiple()
		{
		}
	}
}
