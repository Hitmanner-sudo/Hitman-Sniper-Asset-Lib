using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB194", Offset = "0x5AB194")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB194", Offset = "0x5AB194")]
	public class UiImageSetRaycastTarget : ComponentAction<Image>
	{
		[Token(Token = "0x40056A5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6048C0", Offset = "0x6048C0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6048C0", Offset = "0x6048C0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056A6")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604954", Offset = "0x604954")]
		public FsmBool raycastTarget;

		[Token(Token = "0x40056A7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6049A0", Offset = "0x6049A0")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40056A8")]
		[FieldOffset(Offset = "0x80")]
		private bool originalBool;

		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0xB8E5E0", Offset = "0xB8E5E0", VA = "0xB8E5E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A20")]
		[Address(RVA = "0xB8E610", Offset = "0xB8E610", VA = "0xB8E610", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A21")]
		[Address(RVA = "0xB8E6B0", Offset = "0xB8E6B0", VA = "0xB8E6B0")]
		private void DoSetRaycastTarget()
		{
		}

		[Token(Token = "0x6006A22")]
		[Address(RVA = "0xB8E6FC", Offset = "0xB8E6FC", VA = "0xB8E6FC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A23")]
		[Address(RVA = "0xB8E754", Offset = "0xB8E754", VA = "0xB8E754")]
		public UiImageSetRaycastTarget()
		{
		}
	}
}
