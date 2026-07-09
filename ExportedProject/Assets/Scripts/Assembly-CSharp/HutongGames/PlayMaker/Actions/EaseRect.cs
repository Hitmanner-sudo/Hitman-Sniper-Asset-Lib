using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5997A0", Offset = "0x5997A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5997A0", Offset = "0x5997A0")]
	public class EaseRect : EaseFsmAction
	{
		[Token(Token = "0x400459E")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1F78", Offset = "0x5C1F78")]
		[RequiredField]
		public FsmRect fromValue;

		[Token(Token = "0x400459F")]
		[FieldOffset(Offset = "0xD0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1FC4", Offset = "0x5C1FC4")]
		public FsmRect toValue;

		[Token(Token = "0x40045A0")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2010", Offset = "0x5C2010")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2010", Offset = "0x5C2010")]
		public FsmRect rectVariable;

		[Token(Token = "0x40045A1")]
		[FieldOffset(Offset = "0xE0")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0xC244B8", Offset = "0xC244B8", VA = "0xC244B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0xC244E4", Offset = "0xC244E4", VA = "0xC244E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0xC24770", Offset = "0xC24770", VA = "0xC24770", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0xC24774", Offset = "0xC24774", VA = "0xC24774", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0xC24A00", Offset = "0xC24A00", VA = "0xC24A00")]
		public EaseRect()
		{
		}
	}
}
