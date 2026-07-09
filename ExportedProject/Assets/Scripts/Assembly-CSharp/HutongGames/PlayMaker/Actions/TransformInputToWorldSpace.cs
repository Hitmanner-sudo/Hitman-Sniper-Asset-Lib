using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001008")]
	[NoActionTargets]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0074", Offset = "0x5A0074")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0074", Offset = "0x5A0074")]
	public class TransformInputToWorldSpace : FsmStateAction
	{
		[Token(Token = "0x2001009")]
		public enum AxisPlane
		{
			[Token(Token = "0x4004B5A")]
			XZ = 0,
			[Token(Token = "0x4004B5B")]
			XY = 1,
			[Token(Token = "0x4004B5C")]
			YZ = 2
		}

		[Token(Token = "0x4004B52")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9F78", Offset = "0x5D9F78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9F78", Offset = "0x5D9F78")]
		public FsmFloat horizontalInput;

		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9FC8", Offset = "0x5D9FC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9FC8", Offset = "0x5D9FC8")]
		public FsmFloat verticalInput;

		[Token(Token = "0x4004B54")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA018", Offset = "0x5DA018")]
		public FsmFloat multiplier;

		[Token(Token = "0x4004B55")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA050", Offset = "0x5DA050")]
		[RequiredField]
		public AxisPlane mapToPlane;

		[Token(Token = "0x4004B56")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA09C", Offset = "0x5DA09C")]
		public FsmGameObject relativeTo;

		[Token(Token = "0x4004B57")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DA0D4", Offset = "0x5DA0D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA0D4", Offset = "0x5DA0D4")]
		public FsmVector3 storeVector;

		[Token(Token = "0x4004B58")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DA134", Offset = "0x5DA134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA134", Offset = "0x5DA134")]
		public FsmFloat storeMagnitude;

		[Token(Token = "0x6006061")]
		[Address(RVA = "0xC971AC", Offset = "0xC971AC", VA = "0xC971AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006062")]
		[Address(RVA = "0xC971E4", Offset = "0xC971E4", VA = "0xC971E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006063")]
		[Address(RVA = "0xC974B8", Offset = "0xC974B8", VA = "0xC974B8")]
		public TransformInputToWorldSpace()
		{
		}
	}
}
