using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001030")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0E90", Offset = "0x5A0E90")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0E90", Offset = "0x5A0E90")]
	public class GameObjectTagSwitch : FsmStateAction
	{
		[Token(Token = "0x4004C06")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DCE98", Offset = "0x5DCE98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCE98", Offset = "0x5DCE98")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004C07")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DCEF8", Offset = "0x5DCEF8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DCEF8", Offset = "0x5DCEF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCEF8", Offset = "0x5DCEF8")]
		public FsmString[] compareTo;

		[Token(Token = "0x4004C08")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCF9C", Offset = "0x5DCF9C")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004C09")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCFD4", Offset = "0x5DCFD4")]
		public bool everyFrame;

		[Token(Token = "0x6006110")]
		[Address(RVA = "0xD9A1C0", Offset = "0xD9A1C0", VA = "0xD9A1C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006111")]
		[Address(RVA = "0xD9A240", Offset = "0xD9A240", VA = "0xD9A240", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006112")]
		[Address(RVA = "0xD9A3D0", Offset = "0xD9A3D0", VA = "0xD9A3D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006113")]
		[Address(RVA = "0xD9A27C", Offset = "0xD9A27C", VA = "0xD9A27C")]
		private void DoTagSwitch()
		{
		}

		[Token(Token = "0x6006114")]
		[Address(RVA = "0xD9A3D4", Offset = "0xD9A3D4", VA = "0xD9A3D4")]
		public GameObjectTagSwitch()
		{
		}
	}
}
