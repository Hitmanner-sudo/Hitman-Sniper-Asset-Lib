using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001047")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A15C0", Offset = "0x5A15C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A15C0", Offset = "0x5A15C0")]
	public class SetVisibility : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C76")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DEFEC", Offset = "0x5DEFEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEFEC", Offset = "0x5DEFEC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C77")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF080", Offset = "0x5DF080")]
		public FsmBool toggle;

		[Token(Token = "0x4004C78")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF0B8", Offset = "0x5DF0B8")]
		public FsmBool visible;

		[Token(Token = "0x4004C79")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF0F0", Offset = "0x5DF0F0")]
		public bool resetOnExit;

		[Token(Token = "0x4004C7A")]
		[FieldOffset(Offset = "0x81")]
		private bool initialVisibility;

		[Token(Token = "0x600617E")]
		[Address(RVA = "0x83CE58", Offset = "0x83CE58", VA = "0x83CE58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600617F")]
		[Address(RVA = "0x83CEA0", Offset = "0x83CEA0", VA = "0x83CEA0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006180")]
		[Address(RVA = "0x83CEE8", Offset = "0x83CEE8", VA = "0x83CEE8")]
		private void DoSetVisibility(GameObject go)
		{
		}

		[Token(Token = "0x6006181")]
		[Address(RVA = "0x83D008", Offset = "0x83D008", VA = "0x83D008", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006182")]
		[Address(RVA = "0x83D018", Offset = "0x83D018", VA = "0x83D018")]
		private void ResetVisibility()
		{
		}

		[Token(Token = "0x6006183")]
		[Address(RVA = "0x83D0E4", Offset = "0x83D0E4", VA = "0x83D0E4")]
		public SetVisibility()
		{
		}
	}
}
