using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001082")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A26E4", Offset = "0x5A26E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A26E4", Offset = "0x5A26E4")]
	public class SetGravity : FsmStateAction
	{
		[Token(Token = "0x4004DB0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4050", Offset = "0x5E4050")]
		public FsmVector3 vector;

		[Token(Token = "0x4004DB1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4088", Offset = "0x5E4088")]
		public FsmFloat x;

		[Token(Token = "0x4004DB2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E40C0", Offset = "0x5E40C0")]
		public FsmFloat y;

		[Token(Token = "0x4004DB3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E40F8", Offset = "0x5E40F8")]
		public FsmFloat z;

		[Token(Token = "0x4004DB4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4130", Offset = "0x5E4130")]
		public bool everyFrame;

		[Token(Token = "0x600629C")]
		[Address(RVA = "0x103D9F4", Offset = "0x103D9F4", VA = "0x103D9F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600629D")]
		[Address(RVA = "0x103DAB4", Offset = "0x103DAB4", VA = "0x103DAB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600629E")]
		[Address(RVA = "0x103DBC4", Offset = "0x103DBC4", VA = "0x103DBC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600629F")]
		[Address(RVA = "0x103DAF0", Offset = "0x103DAF0", VA = "0x103DAF0")]
		private void DoSetGravity()
		{
		}

		[Token(Token = "0x60062A0")]
		[Address(RVA = "0x103DBC8", Offset = "0x103DBC8", VA = "0x103DBC8")]
		public SetGravity()
		{
		}
	}
}
