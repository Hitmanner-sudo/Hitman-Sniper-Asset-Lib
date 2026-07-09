using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF3")]
	[NoActionTargets]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FA14", Offset = "0x59FA14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FA14", Offset = "0x59FA14")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x59FA14", Offset = "0x59FA14")]
	public class GetAxisVector : FsmStateAction
	{
		[Token(Token = "0x2000FF4")]
		public enum AxisPlane
		{
			[Token(Token = "0x4004AEF")]
			XZ = 0,
			[Token(Token = "0x4004AF0")]
			XY = 1,
			[Token(Token = "0x4004AF1")]
			YZ = 2
		}

		[Token(Token = "0x4004AE7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D85AC", Offset = "0x5D85AC")]
		public FsmString horizontalAxis;

		[Token(Token = "0x4004AE8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D85E4", Offset = "0x5D85E4")]
		public FsmString verticalAxis;

		[Token(Token = "0x4004AE9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D861C", Offset = "0x5D861C")]
		public FsmFloat multiplier;

		[Token(Token = "0x4004AEA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8654", Offset = "0x5D8654")]
		public AxisPlane mapToPlane;

		[Token(Token = "0x4004AEB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D86A0", Offset = "0x5D86A0")]
		public FsmGameObject relativeTo;

		[Token(Token = "0x4004AEC")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D86D8", Offset = "0x5D86D8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D86D8", Offset = "0x5D86D8")]
		public FsmVector3 storeVector;

		[Token(Token = "0x4004AED")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8738", Offset = "0x5D8738")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8738", Offset = "0x5D8738")]
		public FsmFloat storeMagnitude;

		[Token(Token = "0x600600B")]
		[Address(RVA = "0x105D3EC", Offset = "0x105D3EC", VA = "0x105D3EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600600C")]
		[Address(RVA = "0x105D47C", Offset = "0x105D47C", VA = "0x105D47C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600600D")]
		[Address(RVA = "0x105D7A4", Offset = "0x105D7A4", VA = "0x105D7A4")]
		public GetAxisVector()
		{
		}
	}
}
