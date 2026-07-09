using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001249")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC044", Offset = "0x5AC044")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC044", Offset = "0x5AC044")]
	public class UiSliderSetNormalizedValue : ComponentAction<Slider>
	{
		[Token(Token = "0x4005799")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60860C", Offset = "0x60860C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60860C", Offset = "0x60860C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400579A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6086A0", Offset = "0x6086A0")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x6086A0", Offset = "0x6086A0")]
		[RequiredField]
		public FsmFloat value;

		[Token(Token = "0x400579B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608704", Offset = "0x608704")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400579C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60873C", Offset = "0x60873C")]
		public bool everyFrame;

		[Token(Token = "0x400579D")]
		[FieldOffset(Offset = "0x88")]
		private Slider slider;

		[Token(Token = "0x400579E")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0xB992F8", Offset = "0xB992F8", VA = "0xB992F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0xB99308", Offset = "0xB99308", VA = "0xB99308", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B10")]
		[Address(RVA = "0xB99464", Offset = "0xB99464", VA = "0xB99464", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B11")]
		[Address(RVA = "0xB993C0", Offset = "0xB993C0", VA = "0xB993C0")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B12")]
		[Address(RVA = "0xB99468", Offset = "0xB99468", VA = "0xB99468", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B13")]
		[Address(RVA = "0xB99510", Offset = "0xB99510", VA = "0xB99510")]
		public UiSliderSetNormalizedValue()
		{
		}
	}
}
