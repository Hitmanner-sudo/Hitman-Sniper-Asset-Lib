using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A17A0", Offset = "0x5A17A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A17A0", Offset = "0x5A17A0")]
	public class FloatDeltaAngle : FsmStateAction
	{
		[Token(Token = "0x4004C89")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF554", Offset = "0x5DF554")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF554", Offset = "0x5DF554")]
		[RequiredField]
		public FsmFloat fromAngle;

		[Token(Token = "0x4004C8A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF5B4", Offset = "0x5DF5B4")]
		[RequiredField]
		public FsmFloat toAngle;

		[Token(Token = "0x4004C8B")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF600", Offset = "0x5DF600")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF600", Offset = "0x5DF600")]
		public FsmFloat deltaAngle;

		[Token(Token = "0x4004C8C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF660", Offset = "0x5DF660")]
		public bool everyFrame;

		[Token(Token = "0x600619B")]
		[Address(RVA = "0x959054", Offset = "0x959054", VA = "0x959054", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600619C")]
		[Address(RVA = "0x959064", Offset = "0x959064", VA = "0x959064", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600619D")]
		[Address(RVA = "0x959108", Offset = "0x959108", VA = "0x959108", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600619E")]
		[Address(RVA = "0x9590A0", Offset = "0x9590A0", VA = "0x9590A0")]
		private void DoDeltaAngle()
		{
		}

		[Token(Token = "0x600619F")]
		[Address(RVA = "0x95910C", Offset = "0x95910C", VA = "0x95910C")]
		public FloatDeltaAngle()
		{
		}
	}
}
