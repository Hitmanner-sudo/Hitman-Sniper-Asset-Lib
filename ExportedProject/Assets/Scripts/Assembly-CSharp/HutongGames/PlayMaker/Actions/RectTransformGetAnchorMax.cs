using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A463C", Offset = "0x5A463C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A463C", Offset = "0x5A463C")]
	public class RectTransformGetAnchorMax : BaseUpdateAction
	{
		[Token(Token = "0x4004FB6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECDF0", Offset = "0x5ECDF0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ECDF0", Offset = "0x5ECDF0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FB7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ECE84", Offset = "0x5ECE84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECE84", Offset = "0x5ECE84")]
		public FsmVector2 anchorMax;

		[Token(Token = "0x4004FB8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ECED4", Offset = "0x5ECED4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECED4", Offset = "0x5ECED4")]
		public FsmFloat x;

		[Token(Token = "0x4004FB9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ECF24", Offset = "0x5ECF24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECF24", Offset = "0x5ECF24")]
		public FsmFloat y;

		[Token(Token = "0x4004FBA")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x600648A")]
		[Address(RVA = "0xB44A9C", Offset = "0xB44A9C", VA = "0xB44A9C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600648B")]
		[Address(RVA = "0xB44AC8", Offset = "0xB44AC8", VA = "0xB44AC8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600648C")]
		[Address(RVA = "0xB44C54", Offset = "0xB44C54", VA = "0xB44C54", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x600648D")]
		[Address(RVA = "0xB44BA4", Offset = "0xB44BA4", VA = "0xB44BA4")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x600648E")]
		[Address(RVA = "0xB44C58", Offset = "0xB44C58", VA = "0xB44C58")]
		public RectTransformGetAnchorMax()
		{
		}
	}
}
