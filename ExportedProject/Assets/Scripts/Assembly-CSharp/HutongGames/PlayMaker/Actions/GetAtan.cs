using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A96F8", Offset = "0x5A96F8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A96F8", Offset = "0x5A96F8")]
	public class GetAtan : FsmStateAction
	{
		[Token(Token = "0x40054B2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE670", Offset = "0x5FE670")]
		[RequiredField]
		public FsmFloat Value;

		[Token(Token = "0x40054B3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE6BC", Offset = "0x5FE6BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE6BC", Offset = "0x5FE6BC")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x40054B4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE71C", Offset = "0x5FE71C")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054B5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE754", Offset = "0x5FE754")]
		public bool everyFrame;

		[Token(Token = "0x600686E")]
		[Address(RVA = "0x105CE28", Offset = "0x105CE28", VA = "0x105CE28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600686F")]
		[Address(RVA = "0x105CE5C", Offset = "0x105CE5C", VA = "0x105CE5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006870")]
		[Address(RVA = "0x105CF08", Offset = "0x105CF08", VA = "0x105CF08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006871")]
		[Address(RVA = "0x105CE98", Offset = "0x105CE98", VA = "0x105CE98")]
		private void DoATan()
		{
		}

		[Token(Token = "0x6006872")]
		[Address(RVA = "0x105CF0C", Offset = "0x105CF0C", VA = "0x105CF0C")]
		public GetAtan()
		{
		}
	}
}
