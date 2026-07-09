using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F34")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C038", Offset = "0x59C038")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C038", Offset = "0x59C038")]
	public class SetGameVolume : FsmStateAction
	{
		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC48C", Offset = "0x5CC48C")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CC48C", Offset = "0x5CC48C")]
		public FsmFloat volume;

		[Token(Token = "0x40047BF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC4F0", Offset = "0x5CC4F0")]
		public bool everyFrame;

		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x103D940", Offset = "0x103D940", VA = "0x103D940", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x103D970", Offset = "0x103D970", VA = "0x103D970", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D27")]
		[Address(RVA = "0x103D9C4", Offset = "0x103D9C4", VA = "0x103D9C4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D28")]
		[Address(RVA = "0x103D9EC", Offset = "0x103D9EC", VA = "0x103D9EC")]
		public SetGameVolume()
		{
		}
	}
}
