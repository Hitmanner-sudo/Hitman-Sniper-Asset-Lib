using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4F3C", Offset = "0x5A4F3C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4F3C", Offset = "0x5A4F3C")]
	public class RectTransformSetPivot : BaseUpdateAction
	{
		[Token(Token = "0x400505F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF900", Offset = "0x5EF900")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF900", Offset = "0x5EF900")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005060")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF994", Offset = "0x5EF994")]
		public FsmVector2 pivot;

		[Token(Token = "0x4005061")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EF9CC", Offset = "0x5EF9CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF9CC", Offset = "0x5EF9CC")]
		public FsmFloat x;

		[Token(Token = "0x4005062")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFA20", Offset = "0x5EFA20")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EFA20", Offset = "0x5EFA20")]
		public FsmFloat y;

		[Token(Token = "0x4005063")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x6006502")]
		[Address(RVA = "0x9617C8", Offset = "0x9617C8", VA = "0x9617C8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006503")]
		[Address(RVA = "0x96186C", Offset = "0x96186C", VA = "0x96186C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006504")]
		[Address(RVA = "0x961A0C", Offset = "0x961A0C", VA = "0x961A0C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006505")]
		[Address(RVA = "0x961948", Offset = "0x961948", VA = "0x961948")]
		private void DoSetPivotPosition()
		{
		}

		[Token(Token = "0x6006506")]
		[Address(RVA = "0x961A10", Offset = "0x961A10", VA = "0x961A10")]
		public RectTransformSetPivot()
		{
		}
	}
}
