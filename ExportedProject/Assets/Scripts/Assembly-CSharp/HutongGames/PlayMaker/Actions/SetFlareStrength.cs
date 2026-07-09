using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001102")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A51BC", Offset = "0x5A51BC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A51BC", Offset = "0x5A51BC")]
	public class SetFlareStrength : FsmStateAction
	{
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F020C", Offset = "0x5F020C")]
		public FsmFloat flareStrength;

		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0258", Offset = "0x5F0258")]
		public bool everyFrame;

		[Token(Token = "0x6006526")]
		[Address(RVA = "0x1039974", Offset = "0x1039974", VA = "0x1039974", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006527")]
		[Address(RVA = "0x10399A8", Offset = "0x10399A8", VA = "0x10399A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006528")]
		[Address(RVA = "0x1039A0C", Offset = "0x1039A0C", VA = "0x1039A0C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006529")]
		[Address(RVA = "0x10399E4", Offset = "0x10399E4", VA = "0x10399E4")]
		private void DoSetFlareStrength()
		{
		}

		[Token(Token = "0x600652A")]
		[Address(RVA = "0x1039A10", Offset = "0x1039A10", VA = "0x1039A10")]
		public SetFlareStrength()
		{
		}
	}
}
