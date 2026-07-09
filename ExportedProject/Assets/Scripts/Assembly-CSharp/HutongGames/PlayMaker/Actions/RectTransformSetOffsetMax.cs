using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4E7C", Offset = "0x5A4E7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4E7C", Offset = "0x5A4E7C")]
	public class RectTransformSetOffsetMax : BaseUpdateAction
	{
		[Token(Token = "0x4005055")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF688", Offset = "0x5EF688")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF688", Offset = "0x5EF688")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005056")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF71C", Offset = "0x5EF71C")]
		public FsmVector2 offsetMax;

		[Token(Token = "0x4005057")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF754", Offset = "0x5EF754")]
		public FsmFloat x;

		[Token(Token = "0x4005058")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF78C", Offset = "0x5EF78C")]
		public FsmFloat y;

		[Token(Token = "0x4005059")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x961328", Offset = "0x961328", VA = "0x961328", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064F9")]
		[Address(RVA = "0x9613CC", Offset = "0x9613CC", VA = "0x9613CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064FA")]
		[Address(RVA = "0x96156C", Offset = "0x96156C", VA = "0x96156C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064FB")]
		[Address(RVA = "0x9614A8", Offset = "0x9614A8", VA = "0x9614A8")]
		private void DoSetOffsetMax()
		{
		}

		[Token(Token = "0x60064FC")]
		[Address(RVA = "0x961570", Offset = "0x961570", VA = "0x961570")]
		public RectTransformSetOffsetMax()
		{
		}
	}
}
