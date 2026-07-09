using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200119C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8D74", Offset = "0x5A8D74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8D74", Offset = "0x5A8D74")]
	public class Wait : FsmStateAction
	{
		[Token(Token = "0x40053C1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB290", Offset = "0x5FB290")]
		[RequiredField]
		public FsmFloat time;

		[Token(Token = "0x40053C2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB2DC", Offset = "0x5FB2DC")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40053C3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB314", Offset = "0x5FB314")]
		public bool realTime;

		[Token(Token = "0x40053C4")]
		[FieldOffset(Offset = "0x64")]
		private float startTime;

		[Token(Token = "0x40053C5")]
		[FieldOffset(Offset = "0x68")]
		private float timer;

		[Token(Token = "0x60067BA")]
		[Address(RVA = "0x97C33C", Offset = "0x97C33C", VA = "0x97C33C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067BB")]
		[Address(RVA = "0x97C36C", Offset = "0x97C36C", VA = "0x97C36C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067BC")]
		[Address(RVA = "0x97C3DC", Offset = "0x97C3DC", VA = "0x97C3DC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067BD")]
		[Address(RVA = "0x97C47C", Offset = "0x97C47C", VA = "0x97C47C")]
		public Wait()
		{
		}
	}
}
