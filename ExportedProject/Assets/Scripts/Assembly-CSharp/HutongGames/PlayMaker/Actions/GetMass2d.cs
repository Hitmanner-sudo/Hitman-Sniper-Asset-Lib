using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001093")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2CA0", Offset = "0x5A2CA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2CA0", Offset = "0x5A2CA0")]
	public class GetMass2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004DFF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5810", Offset = "0x5E5810")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E5810", Offset = "0x5E5810")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E00")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E58A4", Offset = "0x5E58A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E58A4", Offset = "0x5E58A4")]
		public FsmFloat storeResult;

		[Token(Token = "0x6006306")]
		[Address(RVA = "0x1063EF4", Offset = "0x1063EF4", VA = "0x1063EF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006307")]
		[Address(RVA = "0x1063EFC", Offset = "0x1063EFC", VA = "0x1063EFC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006308")]
		[Address(RVA = "0x1063F24", Offset = "0x1063F24", VA = "0x1063F24")]
		private void DoGetMass()
		{
		}

		[Token(Token = "0x6006309")]
		[Address(RVA = "0x1063FCC", Offset = "0x1063FCC", VA = "0x1063FCC")]
		public GetMass2d()
		{
		}
	}
}
