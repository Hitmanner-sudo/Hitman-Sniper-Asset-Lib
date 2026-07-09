using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F19")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B610", Offset = "0x59B610")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B610", Offset = "0x59B610")]
	public class ArrayLength : FsmStateAction
	{
		[Token(Token = "0x4004756")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA7E4", Offset = "0x5CA7E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA7E4", Offset = "0x5CA7E4")]
		public FsmArray array;

		[Token(Token = "0x4004757")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA834", Offset = "0x5CA834")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA834", Offset = "0x5CA834")]
		public FsmInt length;

		[Token(Token = "0x4004758")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA884", Offset = "0x5CA884")]
		public bool everyFrame;

		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0xBFD3E8", Offset = "0xBFD3E8", VA = "0xBFD3E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0xBFD3F4", Offset = "0xBFD3F4", VA = "0xBFD3F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0xBFD44C", Offset = "0xBFD44C", VA = "0xBFD44C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0xBFD488", Offset = "0xBFD488", VA = "0xBFD488")]
		public ArrayLength()
		{
		}
	}
}
