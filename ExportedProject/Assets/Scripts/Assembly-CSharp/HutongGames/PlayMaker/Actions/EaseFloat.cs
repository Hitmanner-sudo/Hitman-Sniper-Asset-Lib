using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EAF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599718", Offset = "0x599718")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599718", Offset = "0x599718")]
	public class EaseFloat : EaseFsmAction
	{
		[Token(Token = "0x4004567")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1CF4", Offset = "0x5C1CF4")]
		[RequiredField]
		public FsmFloat fromValue;

		[Token(Token = "0x4004568")]
		[FieldOffset(Offset = "0xD0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1D40", Offset = "0x5C1D40")]
		public FsmFloat toValue;

		[Token(Token = "0x4004569")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1D8C", Offset = "0x5C1D8C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C1D8C", Offset = "0x5C1D8C")]
		public FsmFloat floatVariable;

		[Token(Token = "0x400456A")]
		[FieldOffset(Offset = "0xE0")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0xC232F8", Offset = "0xC232F8", VA = "0xC232F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0xC23324", Offset = "0xC23324", VA = "0xC23324", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0xC23460", Offset = "0xC23460", VA = "0xC23460", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0xC23464", Offset = "0xC23464", VA = "0xC23464", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0xC23578", Offset = "0xC23578", VA = "0xC23578")]
		public EaseFloat()
		{
		}
	}
}
