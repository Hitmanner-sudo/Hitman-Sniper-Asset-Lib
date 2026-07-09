using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001209")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAC84", Offset = "0x5AAC84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAC84", Offset = "0x5AAC84")]
	public class UiSetIsInteractable : FsmStateAction
	{
		[Token(Token = "0x400564E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603288", Offset = "0x603288")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603288", Offset = "0x603288")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400564F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60331C", Offset = "0x60331C")]
		public FsmBool isInteractable;

		[Token(Token = "0x4005650")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603354", Offset = "0x603354")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005651")]
		[FieldOffset(Offset = "0x68")]
		private Selectable _selectable;

		[Token(Token = "0x4005652")]
		[FieldOffset(Offset = "0x70")]
		private bool _originalState;

		[Token(Token = "0x60069D3")]
		[Address(RVA = "0xB97C60", Offset = "0xB97C60", VA = "0xB97C60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069D4")]
		[Address(RVA = "0xB97C90", Offset = "0xB97C90", VA = "0xB97C90", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069D5")]
		[Address(RVA = "0xB97DD4", Offset = "0xB97DD4", VA = "0xB97DD4")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069D6")]
		[Address(RVA = "0xB97E7C", Offset = "0xB97E7C", VA = "0xB97E7C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069D7")]
		[Address(RVA = "0xB97F24", Offset = "0xB97F24", VA = "0xB97F24")]
		public UiSetIsInteractable()
		{
		}
	}
}
