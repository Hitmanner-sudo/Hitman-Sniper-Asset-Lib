using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1C50", Offset = "0x5A1C50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1C50", Offset = "0x5A1C50")]
	public class SampleCurve : FsmStateAction
	{
		[Token(Token = "0x4004CD8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0678", Offset = "0x5E0678")]
		[RequiredField]
		public FsmAnimationCurve curve;

		[Token(Token = "0x4004CD9")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E06C4", Offset = "0x5E06C4")]
		public FsmFloat sampleAt;

		[Token(Token = "0x4004CDA")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0710", Offset = "0x5E0710")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0710", Offset = "0x5E0710")]
		public FsmFloat storeValue;

		[Token(Token = "0x4004CDB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0770", Offset = "0x5E0770")]
		public bool everyFrame;

		[Token(Token = "0x60061DD")]
		[Address(RVA = "0xBA95B4", Offset = "0xBA95B4", VA = "0xBA95B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061DE")]
		[Address(RVA = "0xBA95C4", Offset = "0xBA95C4", VA = "0xBA95C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061DF")]
		[Address(RVA = "0xBA9654", Offset = "0xBA9654", VA = "0xBA9654", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061E0")]
		[Address(RVA = "0xBA9600", Offset = "0xBA9600", VA = "0xBA9600")]
		private void DoSampleCurve()
		{
		}

		[Token(Token = "0x60061E1")]
		[Address(RVA = "0xBA9658", Offset = "0xBA9658", VA = "0xBA9658")]
		public SampleCurve()
		{
		}
	}
}
