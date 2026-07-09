using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A481C", Offset = "0x5A481C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A481C", Offset = "0x5A481C")]
	public class RectTransformGetLocalRotation : BaseUpdateAction
	{
		[Token(Token = "0x4004FD8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ED72C", Offset = "0x5ED72C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED72C", Offset = "0x5ED72C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FD9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED7C0", Offset = "0x5ED7C0")]
		public FsmVector3 rotation;

		[Token(Token = "0x4004FDA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED7F8", Offset = "0x5ED7F8")]
		public FsmFloat x;

		[Token(Token = "0x4004FDB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED830", Offset = "0x5ED830")]
		public FsmFloat y;

		[Token(Token = "0x4004FDC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED868", Offset = "0x5ED868")]
		public FsmFloat z;

		[Token(Token = "0x4004FDD")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform _rt;

		[Token(Token = "0x60064A3")]
		[Address(RVA = "0xB45514", Offset = "0xB45514", VA = "0xB45514", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064A4")]
		[Address(RVA = "0xB45610", Offset = "0xB45610", VA = "0xB45610", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064A5")]
		[Address(RVA = "0xB45828", Offset = "0xB45828", VA = "0xB45828", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064A6")]
		[Address(RVA = "0xB456EC", Offset = "0xB456EC", VA = "0xB456EC")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064A7")]
		[Address(RVA = "0xB4582C", Offset = "0xB4582C", VA = "0xB4582C")]
		public RectTransformGetLocalRotation()
		{
		}
	}
}
