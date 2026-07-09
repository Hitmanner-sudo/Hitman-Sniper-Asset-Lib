using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3380", Offset = "0x5A3380")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3380", Offset = "0x5A3380")]
	public class SetGravity2d : FsmStateAction
	{
		[Token(Token = "0x4004ECF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8E54", Offset = "0x5E8E54")]
		public FsmVector2 vector;

		[Token(Token = "0x4004ED0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8E8C", Offset = "0x5E8E8C")]
		public FsmFloat x;

		[Token(Token = "0x4004ED1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8EC4", Offset = "0x5E8EC4")]
		public FsmFloat y;

		[Token(Token = "0x4004ED2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8EFC", Offset = "0x5E8EFC")]
		public bool everyFrame;

		[Token(Token = "0x6006372")]
		[Address(RVA = "0x103DBD0", Offset = "0x103DBD0", VA = "0x103DBD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006373")]
		[Address(RVA = "0x103DC6C", Offset = "0x103DC6C", VA = "0x103DC6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006374")]
		[Address(RVA = "0x103DD78", Offset = "0x103DD78", VA = "0x103DD78", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006375")]
		[Address(RVA = "0x103DCA8", Offset = "0x103DCA8", VA = "0x103DCA8")]
		private void DoSetGravity()
		{
		}

		[Token(Token = "0x6006376")]
		[Address(RVA = "0x103DD7C", Offset = "0x103DD7C", VA = "0x103DD7C")]
		public SetGravity2d()
		{
		}
	}
}
