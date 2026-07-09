using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F41")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C3C0", Offset = "0x59C3C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C3C0", Offset = "0x59C3C0")]
	public class SetMainCamera : FsmStateAction
	{
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CD11C", Offset = "0x5CD11C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD11C", Offset = "0x5CD11C")]
		public FsmGameObject gameObject;

		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x103F6EC", Offset = "0x103F6EC", VA = "0x103F6EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x103F6F4", Offset = "0x103F6F4", VA = "0x103F6F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x103F838", Offset = "0x103F838", VA = "0x103F838")]
		public SetMainCamera()
		{
		}
	}
}
