using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200119A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8CD4", Offset = "0x5A8CD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8CD4", Offset = "0x5A8CD4")]
	public class RandomWait : FsmStateAction
	{
		[Token(Token = "0x40053B7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB0B4", Offset = "0x5FB0B4")]
		[RequiredField]
		public FsmFloat min;

		[Token(Token = "0x40053B8")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB100", Offset = "0x5FB100")]
		public FsmFloat max;

		[Token(Token = "0x40053B9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB14C", Offset = "0x5FB14C")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40053BA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB184", Offset = "0x5FB184")]
		public bool realTime;

		[Token(Token = "0x40053BB")]
		[FieldOffset(Offset = "0x6C")]
		private float startTime;

		[Token(Token = "0x40053BC")]
		[FieldOffset(Offset = "0x70")]
		private float timer;

		[Token(Token = "0x40053BD")]
		[FieldOffset(Offset = "0x74")]
		private float time;

		[Token(Token = "0x60067B1")]
		[Address(RVA = "0xB3EF38", Offset = "0xB3EF38", VA = "0xB3EF38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067B2")]
		[Address(RVA = "0xB3EF78", Offset = "0xB3EF78", VA = "0xB3EF78", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067B3")]
		[Address(RVA = "0xB3F01C", Offset = "0xB3F01C", VA = "0xB3F01C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067B4")]
		[Address(RVA = "0xB3F0B0", Offset = "0xB3F0B0", VA = "0xB3F0B0")]
		public RandomWait()
		{
		}
	}
}
