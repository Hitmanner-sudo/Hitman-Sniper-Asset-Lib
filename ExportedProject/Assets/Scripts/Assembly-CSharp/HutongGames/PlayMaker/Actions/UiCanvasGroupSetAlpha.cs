using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA0A4", Offset = "0x5AA0A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA0A4", Offset = "0x5AA0A4")]
	public class UiCanvasGroupSetAlpha : ComponentAction<CanvasGroup>
	{
		[Token(Token = "0x4005583")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6001C0", Offset = "0x6001C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6001C0", Offset = "0x6001C0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005584")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600254", Offset = "0x600254")]
		public FsmFloat alpha;

		[Token(Token = "0x4005585")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6002A0", Offset = "0x6002A0")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005586")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6002D8", Offset = "0x6002D8")]
		public bool everyFrame;

		[Token(Token = "0x4005587")]
		[FieldOffset(Offset = "0x88")]
		private CanvasGroup component;

		[Token(Token = "0x4005588")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006926")]
		[Address(RVA = "0x1177A98", Offset = "0x1177A98", VA = "0x1177A98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006927")]
		[Address(RVA = "0x1177AA8", Offset = "0x1177AA8", VA = "0x1177AA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006928")]
		[Address(RVA = "0x1177C04", Offset = "0x1177C04", VA = "0x1177C04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006929")]
		[Address(RVA = "0x1177B60", Offset = "0x1177B60", VA = "0x1177B60")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x600692A")]
		[Address(RVA = "0x1177C08", Offset = "0x1177C08", VA = "0x1177C08", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x600692B")]
		[Address(RVA = "0x1177CB0", Offset = "0x1177CB0", VA = "0x1177CB0")]
		public UiCanvasGroupSetAlpha()
		{
		}
	}
}
