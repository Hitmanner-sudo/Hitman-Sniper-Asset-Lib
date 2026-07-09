using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8F54", Offset = "0x5A8F54")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8F54", Offset = "0x5A8F54")]
	public class GetPosition2d : ComponentAction<Transform>
	{
		[Token(Token = "0x40053FC")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBC9C", Offset = "0x5FBC9C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053FD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FBCE8", Offset = "0x5FBCE8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBCE8", Offset = "0x5FBCE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBCE8", Offset = "0x5FBCE8")]
		public FsmVector2 vector_2d;

		[Token(Token = "0x40053FE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBD5C", Offset = "0x5FBD5C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBD5C", Offset = "0x5FBD5C")]
		public FsmFloat x;

		[Token(Token = "0x40053FF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBDAC", Offset = "0x5FBDAC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBDAC", Offset = "0x5FBDAC")]
		public FsmFloat y;

		[Token(Token = "0x4005400")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBDFC", Offset = "0x5FBDFC")]
		public Space space;

		[Token(Token = "0x4005401")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBE34", Offset = "0x5FBE34")]
		public bool everyFrame;

		[Token(Token = "0x60067DD")]
		[Address(RVA = "0x1067308", Offset = "0x1067308", VA = "0x1067308", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067DE")]
		[Address(RVA = "0x106731C", Offset = "0x106731C", VA = "0x106731C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067DF")]
		[Address(RVA = "0x106741C", Offset = "0x106741C", VA = "0x106741C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067E0")]
		[Address(RVA = "0x1067358", Offset = "0x1067358", VA = "0x1067358")]
		private void DoGetPosition()
		{
		}

		[Token(Token = "0x60067E1")]
		[Address(RVA = "0x1067420", Offset = "0x1067420", VA = "0x1067420")]
		public GetPosition2d()
		{
		}
	}
}
