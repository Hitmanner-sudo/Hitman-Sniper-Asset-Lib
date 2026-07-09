using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FCC8", Offset = "0x59FCC8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FCC8", Offset = "0x59FCC8")]
	public class GetMouseButtonDown : FsmStateAction
	{
		[Token(Token = "0x4004B07")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8D84", Offset = "0x5D8D84")]
		[RequiredField]
		public MouseButton button;

		[Token(Token = "0x4004B08")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8DD0", Offset = "0x5D8DD0")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B09")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8E08", Offset = "0x5D8E08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8E08", Offset = "0x5D8E08")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B0A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8E58", Offset = "0x5D8E58")]
		public bool inUpdateOnly;

		[Token(Token = "0x6006029")]
		[Address(RVA = "0x1064984", Offset = "0x1064984", VA = "0x1064984", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600602A")]
		[Address(RVA = "0x106499C", Offset = "0x106499C", VA = "0x106499C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600602B")]
		[Address(RVA = "0x1064A08", Offset = "0x1064A08", VA = "0x1064A08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600602C")]
		[Address(RVA = "0x10649AC", Offset = "0x10649AC", VA = "0x10649AC")]
		private void DoGetMouseButtonDown()
		{
		}

		[Token(Token = "0x600602D")]
		[Address(RVA = "0x1064A0C", Offset = "0x1064A0C", VA = "0x1064A0C")]
		public GetMouseButtonDown()
		{
		}
	}
}
