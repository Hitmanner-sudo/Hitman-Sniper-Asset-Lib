using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8EB4", Offset = "0x5A8EB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8EB4", Offset = "0x5A8EB4")]
	public class GetAngleToTarget : FsmStateAction
	{
		[Token(Token = "0x40053EF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB914", Offset = "0x5FB914")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053F0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB960", Offset = "0x5FB960")]
		public FsmGameObject targetObject;

		[Token(Token = "0x40053F1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB998", Offset = "0x5FB998")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x40053F2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB9D0", Offset = "0x5FB9D0")]
		public FsmBool ignoreHeight;

		[Token(Token = "0x40053F3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBA08", Offset = "0x5FBA08")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBA08", Offset = "0x5FBA08")]
		public FsmFloat storeAngle;

		[Token(Token = "0x40053F4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBA68", Offset = "0x5FBA68")]
		public bool everyFrame;

		[Token(Token = "0x60067D3")]
		[Address(RVA = "0xDA1AB8", Offset = "0xDA1AB8", VA = "0xDA1AB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067D4")]
		[Address(RVA = "0xDA1B3C", Offset = "0xDA1B3C", VA = "0xDA1B3C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60067D5")]
		[Address(RVA = "0xDA1B5C", Offset = "0xDA1B5C", VA = "0xDA1B5C", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60067D6")]
		[Address(RVA = "0xDA1B98", Offset = "0xDA1B98", VA = "0xDA1B98")]
		private void DoGetAngleToTarget()
		{
		}

		[Token(Token = "0x60067D7")]
		[Address(RVA = "0xDA1DFC", Offset = "0xDA1DFC", VA = "0xDA1DFC")]
		public GetAngleToTarget()
		{
		}
	}
}
