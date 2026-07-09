using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010EC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A49FC", Offset = "0x5A49FC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A49FC", Offset = "0x5A49FC")]
	public class RectTransformGetSizeDelta : BaseUpdateAction
	{
		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EDF50", Offset = "0x5EDF50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDF50", Offset = "0x5EDF50")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FF5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDFE4", Offset = "0x5EDFE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDFE4", Offset = "0x5EDFE4")]
		public FsmVector2 sizeDelta;

		[Token(Token = "0x4004FF6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE034", Offset = "0x5EE034")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE034", Offset = "0x5EE034")]
		public FsmFloat width;

		[Token(Token = "0x4004FF7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE084", Offset = "0x5EE084")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE084", Offset = "0x5EE084")]
		public FsmFloat height;

		[Token(Token = "0x4004FF8")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064BC")]
		[Address(RVA = "0xB460C0", Offset = "0xB460C0", VA = "0xB460C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064BD")]
		[Address(RVA = "0xB460EC", Offset = "0xB460EC", VA = "0xB460EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064BE")]
		[Address(RVA = "0xB46278", Offset = "0xB46278", VA = "0xB46278", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064BF")]
		[Address(RVA = "0xB461C8", Offset = "0xB461C8", VA = "0xB461C8")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064C0")]
		[Address(RVA = "0xB4627C", Offset = "0xB4627C", VA = "0xB4627C")]
		public RectTransformGetSizeDelta()
		{
		}
	}
}
