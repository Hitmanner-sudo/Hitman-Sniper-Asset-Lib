using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010EB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A499C", Offset = "0x5A499C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A499C", Offset = "0x5A499C")]
	public class RectTransformGetRect : BaseUpdateAction
	{
		[Token(Token = "0x4004FED")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EDD2C", Offset = "0x5EDD2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDD2C", Offset = "0x5EDD2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FEE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDDC0", Offset = "0x5EDDC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDDC0", Offset = "0x5EDDC0")]
		public FsmRect rect;

		[Token(Token = "0x4004FEF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDE10", Offset = "0x5EDE10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDE10", Offset = "0x5EDE10")]
		public FsmFloat x;

		[Token(Token = "0x4004FF0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDE60", Offset = "0x5EDE60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDE60", Offset = "0x5EDE60")]
		public FsmFloat y;

		[Token(Token = "0x4004FF1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDEB0", Offset = "0x5EDEB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDEB0", Offset = "0x5EDEB0")]
		public FsmFloat width;

		[Token(Token = "0x4004FF2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDF00", Offset = "0x5EDF00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDF00", Offset = "0x5EDF00")]
		public FsmFloat height;

		[Token(Token = "0x4004FF3")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform _rt;

		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xB45D80", Offset = "0xB45D80", VA = "0xB45D80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xB45E68", Offset = "0xB45E68", VA = "0xB45E68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064B9")]
		[Address(RVA = "0xB460B4", Offset = "0xB460B4", VA = "0xB460B4", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064BA")]
		[Address(RVA = "0xB45F44", Offset = "0xB45F44", VA = "0xB45F44")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064BB")]
		[Address(RVA = "0xB460B8", Offset = "0xB460B8", VA = "0xB460B8")]
		public RectTransformGetRect()
		{
		}
	}
}
