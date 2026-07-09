using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A95B8", Offset = "0x5A95B8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A95B8", Offset = "0x5A95B8")]
	public class TransformPoint : FsmStateAction
	{
		[Token(Token = "0x400549C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE09C", Offset = "0x5FE09C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400549D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE0E8", Offset = "0x5FE0E8")]
		[RequiredField]
		public FsmVector3 localPosition;

		[Token(Token = "0x400549E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE134", Offset = "0x5FE134")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE134", Offset = "0x5FE134")]
		public FsmVector3 storeResult;

		[Token(Token = "0x400549F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE194", Offset = "0x5FE194")]
		public bool everyFrame;

		[Token(Token = "0x6006857")]
		[Address(RVA = "0xC974C0", Offset = "0xC974C0", VA = "0xC974C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006858")]
		[Address(RVA = "0xC974D0", Offset = "0xC974D0", VA = "0xC974D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006859")]
		[Address(RVA = "0xC975EC", Offset = "0xC975EC", VA = "0xC975EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600685A")]
		[Address(RVA = "0xC9750C", Offset = "0xC9750C", VA = "0xC9750C")]
		private void DoTransformPoint()
		{
		}

		[Token(Token = "0x600685B")]
		[Address(RVA = "0xC975F0", Offset = "0xC975F0", VA = "0xC975F0")]
		public TransformPoint()
		{
		}
	}
}
