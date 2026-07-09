using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EFE0", Offset = "0x59EFE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EFE0", Offset = "0x59EFE0")]
	public class DestroySelf : FsmStateAction
	{
		[Token(Token = "0x4004A77")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6748", Offset = "0x5D6748")]
		public FsmFloat delay;

		[Token(Token = "0x4004A78")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6780", Offset = "0x5D6780")]
		public FsmBool realTime;

		[Token(Token = "0x4004A79")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D67B8", Offset = "0x5D67B8")]
		public FsmBool detachChildren;

		[Token(Token = "0x4004A7A")]
		[FieldOffset(Offset = "0x68")]
		private float elapsedTime;

		[Token(Token = "0x6005F81")]
		[Address(RVA = "0xC1363C", Offset = "0xC1363C", VA = "0xC1363C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F82")]
		[Address(RVA = "0xC136A8", Offset = "0xC136A8", VA = "0xC136A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F83")]
		[Address(RVA = "0xC137E4", Offset = "0xC137E4", VA = "0xC137E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005F84")]
		[Address(RVA = "0xC13700", Offset = "0xC13700", VA = "0xC13700")]
		private void DoDestroySelf()
		{
		}

		[Token(Token = "0x6005F85")]
		[Address(RVA = "0xC13878", Offset = "0xC13878", VA = "0xC13878")]
		public DestroySelf()
		{
		}
	}
}
