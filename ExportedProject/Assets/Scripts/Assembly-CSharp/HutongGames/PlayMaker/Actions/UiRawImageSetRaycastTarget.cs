using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001234")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB9B4", Offset = "0x5AB9B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB9B4", Offset = "0x5AB9B4")]
	public class UiRawImageSetRaycastTarget : ComponentAction<RawImage>
	{
		[Token(Token = "0x400572B")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606A1C", Offset = "0x606A1C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606A1C", Offset = "0x606A1C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400572C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606AB0", Offset = "0x606AB0")]
		[RequiredField]
		public FsmBool raycastTarget;

		[Token(Token = "0x400572D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606AFC", Offset = "0x606AFC")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400572E")]
		[FieldOffset(Offset = "0x80")]
		private bool originalBool;

		[Token(Token = "0x6006AA0")]
		[Address(RVA = "0xB9533C", Offset = "0xB9533C", VA = "0xB9533C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AA1")]
		[Address(RVA = "0xB9536C", Offset = "0xB9536C", VA = "0xB9536C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AA2")]
		[Address(RVA = "0xB9540C", Offset = "0xB9540C", VA = "0xB9540C")]
		private void DoSetRaycastTarget()
		{
		}

		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0xB95458", Offset = "0xB95458", VA = "0xB95458", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0xB954B0", Offset = "0xB954B0", VA = "0xB954B0")]
		public UiRawImageSetRaycastTarget()
		{
		}
	}
}
