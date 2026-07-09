using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4BDC", Offset = "0x5A4BDC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4BDC", Offset = "0x5A4BDC")]
	public class RectTransformSetAnchorMax : BaseUpdateAction
	{
		[Token(Token = "0x400501E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EEB0C", Offset = "0x5EEB0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEB0C", Offset = "0x5EEB0C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400501F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEBA0", Offset = "0x5EEBA0")]
		public FsmVector2 anchorMax;

		[Token(Token = "0x4005020")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEBD8", Offset = "0x5EEBD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEBD8", Offset = "0x5EEBD8")]
		public FsmFloat x;

		[Token(Token = "0x4005021")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEC2C", Offset = "0x5EEC2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEC2C", Offset = "0x5EEC2C")]
		public FsmFloat y;

		[Token(Token = "0x4005022")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064D5")]
		[Address(RVA = "0xB4717C", Offset = "0xB4717C", VA = "0xB4717C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064D6")]
		[Address(RVA = "0xB47220", Offset = "0xB47220", VA = "0xB47220", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064D7")]
		[Address(RVA = "0xB473C0", Offset = "0xB473C0", VA = "0xB473C0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064D8")]
		[Address(RVA = "0xB472FC", Offset = "0xB472FC", VA = "0xB472FC")]
		private void DoSetAnchorMax()
		{
		}

		[Token(Token = "0x60064D9")]
		[Address(RVA = "0xB473C4", Offset = "0xB473C4", VA = "0xB473C4")]
		public RectTransformSetAnchorMax()
		{
		}
	}
}
