using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EAE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5996C8", Offset = "0x5996C8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5996C8", Offset = "0x5996C8")]
	public class EaseColor : EaseFsmAction
	{
		[Token(Token = "0x4004563")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1C0C", Offset = "0x5C1C0C")]
		[RequiredField]
		public FsmColor fromValue;

		[Token(Token = "0x4004564")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1C58", Offset = "0x5C1C58")]
		[RequiredField]
		public FsmColor toValue;

		[Token(Token = "0x4004565")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1CA4", Offset = "0x5C1CA4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C1CA4", Offset = "0x5C1CA4")]
		public FsmColor colorVariable;

		[Token(Token = "0x4004566")]
		[FieldOffset(Offset = "0xE0")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0xC229AC", Offset = "0xC229AC", VA = "0xC229AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0xC22B20", Offset = "0xC22B20", VA = "0xC22B20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0xC22DD8", Offset = "0xC22DD8", VA = "0xC22DD8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0xC22DE0", Offset = "0xC22DE0", VA = "0xC22DE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0xC23270", Offset = "0xC23270", VA = "0xC23270")]
		public EaseColor()
		{
		}
	}
}
