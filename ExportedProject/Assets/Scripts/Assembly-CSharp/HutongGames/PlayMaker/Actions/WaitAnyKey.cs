using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A00D4", Offset = "0x5A00D4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A00D4", Offset = "0x5A00D4")]
	public class WaitAnyKey : FsmStateAction
	{
		[Token(Token = "0x4004B5D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA184", Offset = "0x5DA184")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4004B5E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA1BC", Offset = "0x5DA1BC")]
		public FsmEvent sendEvent;

		[Token(Token = "0x6006064")]
		[Address(RVA = "0x97C484", Offset = "0x97C484", VA = "0x97C484", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006065")]
		[Address(RVA = "0x97C48C", Offset = "0x97C48C", VA = "0x97C48C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006066")]
		[Address(RVA = "0x97C4E0", Offset = "0x97C4E0", VA = "0x97C4E0")]
		public WaitAnyKey()
		{
		}
	}
}
