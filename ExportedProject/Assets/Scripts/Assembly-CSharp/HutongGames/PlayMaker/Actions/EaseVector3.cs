using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599800", Offset = "0x599800")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599800", Offset = "0x599800")]
	public class EaseVector3 : EaseFsmAction
	{
		[Token(Token = "0x40045A2")]
		[FieldOffset(Offset = "0xC8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2060", Offset = "0x5C2060")]
		public FsmVector3 fromValue;

		[Token(Token = "0x40045A3")]
		[FieldOffset(Offset = "0xD0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C20AC", Offset = "0x5C20AC")]
		public FsmVector3 toValue;

		[Token(Token = "0x40045A4")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C20F8", Offset = "0x5C20F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C20F8", Offset = "0x5C20F8")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x40045A5")]
		[FieldOffset(Offset = "0xE0")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0xC24A04", Offset = "0xC24A04", VA = "0xC24A04", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0xC24A30", Offset = "0xC24A30", VA = "0xC24A30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0xC24C10", Offset = "0xC24C10", VA = "0xC24C10", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0xC24C14", Offset = "0xC24C14", VA = "0xC24C14", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0xC24DDC", Offset = "0xC24DDC", VA = "0xC24DDC")]
		public EaseVector3()
		{
		}
	}
}
