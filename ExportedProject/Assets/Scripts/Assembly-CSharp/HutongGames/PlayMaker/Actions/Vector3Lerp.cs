using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001279")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACEF4", Offset = "0x5ACEF4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACEF4", Offset = "0x5ACEF4")]
	public class Vector3Lerp : FsmStateAction
	{
		[Token(Token = "0x4005863")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B6C0", Offset = "0x60B6C0")]
		public FsmVector3 fromVector;

		[Token(Token = "0x4005864")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B70C", Offset = "0x60B70C")]
		public FsmVector3 toVector;

		[Token(Token = "0x4005865")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B758", Offset = "0x60B758")]
		public FsmFloat amount;

		[Token(Token = "0x4005866")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B7A4", Offset = "0x60B7A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B7A4", Offset = "0x60B7A4")]
		public FsmVector3 storeResult;

		[Token(Token = "0x4005867")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B804", Offset = "0x60B804")]
		public bool everyFrame;

		[Token(Token = "0x6006BE9")]
		[Address(RVA = "0x13C848C", Offset = "0x13C848C", VA = "0x13C848C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BEA")]
		[Address(RVA = "0x13C8528", Offset = "0x13C8528", VA = "0x13C8528", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BEB")]
		[Address(RVA = "0x13C8620", Offset = "0x13C8620", VA = "0x13C8620", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BEC")]
		[Address(RVA = "0x13C8564", Offset = "0x13C8564", VA = "0x13C8564")]
		private void DoVector3Lerp()
		{
		}

		[Token(Token = "0x6006BED")]
		[Address(RVA = "0x13C8624", Offset = "0x13C8624", VA = "0x13C8624")]
		public Vector3Lerp()
		{
		}
	}
}
