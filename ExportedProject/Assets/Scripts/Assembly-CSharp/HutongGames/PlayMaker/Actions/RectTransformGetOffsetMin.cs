using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A48DC", Offset = "0x5A48DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A48DC", Offset = "0x5A48DC")]
	public class RectTransformGetOffsetMin : BaseUpdateAction
	{
		[Token(Token = "0x4004FE3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDA24", Offset = "0x5EDA24")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EDA24", Offset = "0x5EDA24")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FE4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDAB8", Offset = "0x5EDAB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDAB8", Offset = "0x5EDAB8")]
		public FsmVector2 offsetMin;

		[Token(Token = "0x4004FE5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDB08", Offset = "0x5EDB08")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDB08", Offset = "0x5EDB08")]
		public FsmFloat x;

		[Token(Token = "0x4004FE6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDB58", Offset = "0x5EDB58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDB58", Offset = "0x5EDB58")]
		public FsmFloat y;

		[Token(Token = "0x4004FE7")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064AD")]
		[Address(RVA = "0xB459F8", Offset = "0xB459F8", VA = "0xB459F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064AE")]
		[Address(RVA = "0xB45A24", Offset = "0xB45A24", VA = "0xB45A24", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064AF")]
		[Address(RVA = "0xB45BB0", Offset = "0xB45BB0", VA = "0xB45BB0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064B0")]
		[Address(RVA = "0xB45B00", Offset = "0xB45B00", VA = "0xB45B00")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064B1")]
		[Address(RVA = "0xB45BB4", Offset = "0xB45BB4", VA = "0xB45BB4")]
		public RectTransformGetOffsetMin()
		{
		}
	}
}
