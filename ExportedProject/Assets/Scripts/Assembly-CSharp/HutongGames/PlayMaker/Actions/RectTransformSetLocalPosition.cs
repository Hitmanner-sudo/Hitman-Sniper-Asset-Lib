using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4DBC", Offset = "0x5A4DBC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4DBC", Offset = "0x5A4DBC")]
	public class RectTransformSetLocalPosition : BaseUpdateAction
	{
		[Token(Token = "0x4005047")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF368", Offset = "0x5EF368")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF368", Offset = "0x5EF368")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005048")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF3FC", Offset = "0x5EF3FC")]
		public FsmVector2 position2d;

		[Token(Token = "0x4005049")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF434", Offset = "0x5EF434")]
		public FsmVector3 position;

		[Token(Token = "0x400504A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF46C", Offset = "0x5EF46C")]
		public FsmFloat x;

		[Token(Token = "0x400504B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF4A4", Offset = "0x5EF4A4")]
		public FsmFloat y;

		[Token(Token = "0x400504C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF4DC", Offset = "0x5EF4DC")]
		public FsmFloat z;

		[Token(Token = "0x400504D")]
		[FieldOffset(Offset = "0x80")]
		private GameObject cachedGameObject;

		[Token(Token = "0x400504E")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform _rt;

		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x960C04", Offset = "0x960C04", VA = "0x960C04", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x960D38", Offset = "0x960D38", VA = "0x960D38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x960FC0", Offset = "0x960FC0", VA = "0x960FC0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x960E28", Offset = "0x960E28", VA = "0x960E28")]
		private void DoSetValues()
		{
		}

		[Token(Token = "0x60064F2")]
		[Address(RVA = "0x960FC4", Offset = "0x960FC4", VA = "0x960FC4")]
		public RectTransformSetLocalPosition()
		{
		}
	}
}
