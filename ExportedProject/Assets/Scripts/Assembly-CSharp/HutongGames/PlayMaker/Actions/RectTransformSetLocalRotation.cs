using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4E1C", Offset = "0x5A4E1C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4E1C", Offset = "0x5A4E1C")]
	public class RectTransformSetLocalRotation : BaseUpdateAction
	{
		[Token(Token = "0x400504F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF514", Offset = "0x5EF514")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF514", Offset = "0x5EF514")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005050")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF5A8", Offset = "0x5EF5A8")]
		public FsmVector3 rotation;

		[Token(Token = "0x4005051")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF5E0", Offset = "0x5EF5E0")]
		public FsmFloat x;

		[Token(Token = "0x4005052")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF618", Offset = "0x5EF618")]
		public FsmFloat y;

		[Token(Token = "0x4005053")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF650", Offset = "0x5EF650")]
		public FsmFloat z;

		[Token(Token = "0x4005054")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform _rt;

		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x960FCC", Offset = "0x960FCC", VA = "0x960FCC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064F4")]
		[Address(RVA = "0x9610C8", Offset = "0x9610C8", VA = "0x9610C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x96131C", Offset = "0x96131C", VA = "0x96131C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064F6")]
		[Address(RVA = "0x9611A4", Offset = "0x9611A4", VA = "0x9611A4")]
		private void DoSetValues()
		{
		}

		[Token(Token = "0x60064F7")]
		[Address(RVA = "0x961320", Offset = "0x961320", VA = "0x961320")]
		public RectTransformSetLocalRotation()
		{
		}
	}
}
