using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A505C", Offset = "0x5A505C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A505C", Offset = "0x5A505C")]
	public class RectTransformSetSizeDelta : BaseUpdateAction
	{
		[Token(Token = "0x4005078")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFD9C", Offset = "0x5EFD9C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EFD9C", Offset = "0x5EFD9C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005079")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFE30", Offset = "0x5EFE30")]
		public FsmVector2 sizeDelta;

		[Token(Token = "0x400507A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFE68", Offset = "0x5EFE68")]
		public FsmFloat x;

		[Token(Token = "0x400507B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFEA0", Offset = "0x5EFEA0")]
		public FsmFloat y;

		[Token(Token = "0x400507C")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x6006513")]
		[Address(RVA = "0x962398", Offset = "0x962398", VA = "0x962398", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006514")]
		[Address(RVA = "0x96243C", Offset = "0x96243C", VA = "0x96243C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006515")]
		[Address(RVA = "0x9625DC", Offset = "0x9625DC", VA = "0x9625DC", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006516")]
		[Address(RVA = "0x962518", Offset = "0x962518", VA = "0x962518")]
		private void DoSetSizeDelta()
		{
		}

		[Token(Token = "0x6006517")]
		[Address(RVA = "0x9625E0", Offset = "0x9625E0", VA = "0x9625E0")]
		public RectTransformSetSizeDelta()
		{
		}
	}
}
