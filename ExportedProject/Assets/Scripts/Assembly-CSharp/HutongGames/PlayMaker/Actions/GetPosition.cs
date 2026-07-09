using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8F04", Offset = "0x5A8F04")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8F04", Offset = "0x5A8F04")]
	public class GetPosition : ComponentAction<Transform>
	{
		[Token(Token = "0x40053F5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBAA0", Offset = "0x5FBAA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053F6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBAEC", Offset = "0x5FBAEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBAEC", Offset = "0x5FBAEC")]
		public FsmVector3 vector;

		[Token(Token = "0x40053F7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBB3C", Offset = "0x5FBB3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBB3C", Offset = "0x5FBB3C")]
		public FsmFloat x;

		[Token(Token = "0x40053F8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBB8C", Offset = "0x5FBB8C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBB8C", Offset = "0x5FBB8C")]
		public FsmFloat y;

		[Token(Token = "0x40053F9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBBDC", Offset = "0x5FBBDC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBBDC", Offset = "0x5FBBDC")]
		public FsmFloat z;

		[Token(Token = "0x40053FA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBC2C", Offset = "0x5FBC2C")]
		public Space space;

		[Token(Token = "0x40053FB")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBC64", Offset = "0x5FBC64")]
		public bool everyFrame;

		[Token(Token = "0x60067D8")]
		[Address(RVA = "0x1067190", Offset = "0x1067190", VA = "0x1067190", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067D9")]
		[Address(RVA = "0x10671A8", Offset = "0x10671A8", VA = "0x10671A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067DA")]
		[Address(RVA = "0x10672B8", Offset = "0x10672B8", VA = "0x10672B8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067DB")]
		[Address(RVA = "0x10671E4", Offset = "0x10671E4", VA = "0x10671E4")]
		private void DoGetPosition()
		{
		}

		[Token(Token = "0x60067DC")]
		[Address(RVA = "0x10672BC", Offset = "0x10672BC", VA = "0x10672BC")]
		public GetPosition()
		{
		}
	}
}
