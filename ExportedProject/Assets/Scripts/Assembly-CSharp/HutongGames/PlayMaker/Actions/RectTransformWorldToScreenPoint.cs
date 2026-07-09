using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A50BC", Offset = "0x5A50BC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A50BC", Offset = "0x5A50BC")]
	public class RectTransformWorldToScreenPoint : BaseUpdateAction
	{
		[Token(Token = "0x400507D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EFED8", Offset = "0x5EFED8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFED8", Offset = "0x5EFED8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400507E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EFF6C", Offset = "0x5EFF6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFF6C", Offset = "0x5EFF6C")]
		public FsmOwnerDefault camera;

		[Token(Token = "0x400507F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EFFF0", Offset = "0x5EFFF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFFF0", Offset = "0x5EFFF0")]
		public FsmVector3 screenPoint;

		[Token(Token = "0x4005080")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0040", Offset = "0x5F0040")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0040", Offset = "0x5F0040")]
		public FsmFloat screenX;

		[Token(Token = "0x4005081")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0090", Offset = "0x5F0090")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0090", Offset = "0x5F0090")]
		public FsmFloat screenY;

		[Token(Token = "0x4005082")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F00E0", Offset = "0x5F00E0")]
		public FsmBool normalize;

		[Token(Token = "0x4005083")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform _rt;

		[Token(Token = "0x4005084")]
		[FieldOffset(Offset = "0x88")]
		private Camera _cam;

		[Token(Token = "0x6006518")]
		[Address(RVA = "0x9625E8", Offset = "0x9625E8", VA = "0x9625E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006519")]
		[Address(RVA = "0x9626B4", Offset = "0x9626B4", VA = "0x9626B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600651A")]
		[Address(RVA = "0x962918", Offset = "0x962918", VA = "0x962918", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x600651B")]
		[Address(RVA = "0x96280C", Offset = "0x96280C", VA = "0x96280C")]
		private void DoWorldToScreenPoint()
		{
		}

		[Token(Token = "0x600651C")]
		[Address(RVA = "0x96291C", Offset = "0x96291C", VA = "0x96291C")]
		public RectTransformWorldToScreenPoint()
		{
		}
	}
}
