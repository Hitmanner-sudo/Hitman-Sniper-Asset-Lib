using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A37B4", Offset = "0x5A37B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A37B4", Offset = "0x5A37B4")]
	public class WakeAllRigidBodies2d : FsmStateAction
	{
		[Token(Token = "0x4004F20")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA404", Offset = "0x5EA404")]
		public bool everyFrame;

		[Token(Token = "0x60063BD")]
		[Address(RVA = "0x97C73C", Offset = "0x97C73C", VA = "0x97C73C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063BE")]
		[Address(RVA = "0x97C744", Offset = "0x97C744", VA = "0x97C744", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063BF")]
		[Address(RVA = "0x97C8B4", Offset = "0x97C8B4", VA = "0x97C8B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063C0")]
		[Address(RVA = "0x97C780", Offset = "0x97C780", VA = "0x97C780")]
		private void DoWakeAll()
		{
		}

		[Token(Token = "0x60063C1")]
		[Address(RVA = "0x97C8B8", Offset = "0x97C8B8", VA = "0x97C8B8")]
		public WakeAllRigidBodies2d()
		{
		}
	}
}
