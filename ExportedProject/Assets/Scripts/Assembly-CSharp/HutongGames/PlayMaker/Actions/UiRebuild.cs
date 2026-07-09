using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001236")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABA54", Offset = "0x5ABA54")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABA54", Offset = "0x5ABA54")]
	public class UiRebuild : ComponentAction<Graphic>
	{
		[Token(Token = "0x4005734")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606C4C", Offset = "0x606C4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606C4C", Offset = "0x606C4C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005735")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606CE0", Offset = "0x606CE0")]
		public CanvasUpdate canvasUpdate;

		[Token(Token = "0x4005736")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606D18", Offset = "0x606D18")]
		public bool rebuildOnExit;

		[Token(Token = "0x4005737")]
		[FieldOffset(Offset = "0x78")]
		private Graphic graphic;

		[Token(Token = "0x6006AAA")]
		[Address(RVA = "0xB95744", Offset = "0xB95744", VA = "0xB95744", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0xB95758", Offset = "0xB95758", VA = "0xB95758", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0xB957E8", Offset = "0xB957E8", VA = "0xB957E8")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006AAD")]
		[Address(RVA = "0xB95884", Offset = "0xB95884", VA = "0xB95884", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AAE")]
		[Address(RVA = "0xB95894", Offset = "0xB95894", VA = "0xB95894")]
		public UiRebuild()
		{
		}
	}
}
