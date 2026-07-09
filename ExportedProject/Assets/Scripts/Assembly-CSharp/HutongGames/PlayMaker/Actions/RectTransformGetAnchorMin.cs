using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A469C", Offset = "0x5A469C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A469C", Offset = "0x5A469C")]
	public class RectTransformGetAnchorMin : BaseUpdateAction
	{
		[Token(Token = "0x4004FBB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECF74", Offset = "0x5ECF74")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ECF74", Offset = "0x5ECF74")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FBC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED008", Offset = "0x5ED008")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED008", Offset = "0x5ED008")]
		public FsmVector2 anchorMin;

		[Token(Token = "0x4004FBD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED058", Offset = "0x5ED058")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED058", Offset = "0x5ED058")]
		public FsmFloat x;

		[Token(Token = "0x4004FBE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED0A8", Offset = "0x5ED0A8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED0A8", Offset = "0x5ED0A8")]
		public FsmFloat y;

		[Token(Token = "0x4004FBF")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x600648F")]
		[Address(RVA = "0xB44C60", Offset = "0xB44C60", VA = "0xB44C60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006490")]
		[Address(RVA = "0xB44C8C", Offset = "0xB44C8C", VA = "0xB44C8C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006491")]
		[Address(RVA = "0xB44E18", Offset = "0xB44E18", VA = "0xB44E18", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006492")]
		[Address(RVA = "0xB44D68", Offset = "0xB44D68", VA = "0xB44D68")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x6006493")]
		[Address(RVA = "0xB44E1C", Offset = "0xB44E1C", VA = "0xB44E1C")]
		public RectTransformGetAnchorMin()
		{
		}
	}
}
