using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001179")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7CBC", Offset = "0x5A7CBC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7CBC", Offset = "0x5A7CBC")]
	public class SetEventStringData : FsmStateAction
	{
		[Token(Token = "0x40052F8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8984", Offset = "0x5F8984")]
		public FsmString stringData;

		[Token(Token = "0x600671C")]
		[Address(RVA = "0x1039864", Offset = "0x1039864", VA = "0x1039864", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600671D")]
		[Address(RVA = "0x103986C", Offset = "0x103986C", VA = "0x103986C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600671E")]
		[Address(RVA = "0x10398FC", Offset = "0x10398FC", VA = "0x10398FC")]
		public SetEventStringData()
		{
		}
	}
}
