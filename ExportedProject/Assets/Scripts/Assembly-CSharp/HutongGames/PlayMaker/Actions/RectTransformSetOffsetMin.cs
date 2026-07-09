using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4EDC", Offset = "0x5A4EDC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4EDC", Offset = "0x5A4EDC")]
	public class RectTransformSetOffsetMin : BaseUpdateAction
	{
		[Token(Token = "0x400505A")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF7C4", Offset = "0x5EF7C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF7C4", Offset = "0x5EF7C4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400505B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF858", Offset = "0x5EF858")]
		public FsmVector2 offsetMin;

		[Token(Token = "0x400505C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF890", Offset = "0x5EF890")]
		public FsmFloat x;

		[Token(Token = "0x400505D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF8C8", Offset = "0x5EF8C8")]
		public FsmFloat y;

		[Token(Token = "0x400505E")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064FD")]
		[Address(RVA = "0x961578", Offset = "0x961578", VA = "0x961578", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064FE")]
		[Address(RVA = "0x96161C", Offset = "0x96161C", VA = "0x96161C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x9617BC", Offset = "0x9617BC", VA = "0x9617BC", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006500")]
		[Address(RVA = "0x9616F8", Offset = "0x9616F8", VA = "0x9616F8")]
		private void DoSetOffsetMin()
		{
		}

		[Token(Token = "0x6006501")]
		[Address(RVA = "0x9617C0", Offset = "0x9617C0", VA = "0x9617C0")]
		public RectTransformSetOffsetMin()
		{
		}
	}
}
