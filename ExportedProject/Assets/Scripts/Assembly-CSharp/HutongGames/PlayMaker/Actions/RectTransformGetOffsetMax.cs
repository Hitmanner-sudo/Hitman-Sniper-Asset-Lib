using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A487C", Offset = "0x5A487C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A487C", Offset = "0x5A487C")]
	public class RectTransformGetOffsetMax : BaseUpdateAction
	{
		[Token(Token = "0x4004FDE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ED8A0", Offset = "0x5ED8A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED8A0", Offset = "0x5ED8A0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FDF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED934", Offset = "0x5ED934")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED934", Offset = "0x5ED934")]
		public FsmVector2 offsetMax;

		[Token(Token = "0x4004FE0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED984", Offset = "0x5ED984")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED984", Offset = "0x5ED984")]
		public FsmFloat x;

		[Token(Token = "0x4004FE1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED9D4", Offset = "0x5ED9D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED9D4", Offset = "0x5ED9D4")]
		public FsmFloat y;

		[Token(Token = "0x4004FE2")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064A8")]
		[Address(RVA = "0xB45834", Offset = "0xB45834", VA = "0xB45834", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064A9")]
		[Address(RVA = "0xB45860", Offset = "0xB45860", VA = "0xB45860", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064AA")]
		[Address(RVA = "0xB459EC", Offset = "0xB459EC", VA = "0xB459EC", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064AB")]
		[Address(RVA = "0xB4593C", Offset = "0xB4593C", VA = "0xB4593C")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064AC")]
		[Address(RVA = "0xB459F0", Offset = "0xB459F0", VA = "0xB459F0")]
		public RectTransformGetOffsetMax()
		{
		}
	}
}
