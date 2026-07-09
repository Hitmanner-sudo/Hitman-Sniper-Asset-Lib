using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC094", Offset = "0x5AC094")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC094", Offset = "0x5AC094")]
	public class UiSliderSetValue : ComponentAction<Slider>
	{
		[Token(Token = "0x400579F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608774", Offset = "0x608774")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608774", Offset = "0x608774")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057A0")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608808", Offset = "0x608808")]
		public FsmFloat value;

		[Token(Token = "0x40057A1")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608854", Offset = "0x608854")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40057A2")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60888C", Offset = "0x60888C")]
		public bool everyFrame;

		[Token(Token = "0x40057A3")]
		[FieldOffset(Offset = "0x88")]
		private Slider slider;

		[Token(Token = "0x40057A4")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006B14")]
		[Address(RVA = "0xB9955C", Offset = "0xB9955C", VA = "0xB9955C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B15")]
		[Address(RVA = "0xB9956C", Offset = "0xB9956C", VA = "0xB9956C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B16")]
		[Address(RVA = "0xB996CC", Offset = "0xB996CC", VA = "0xB996CC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B17")]
		[Address(RVA = "0xB99620", Offset = "0xB99620", VA = "0xB99620")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B18")]
		[Address(RVA = "0xB996D0", Offset = "0xB996D0", VA = "0xB996D0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B19")]
		[Address(RVA = "0xB99780", Offset = "0xB99780", VA = "0xB99780")]
		public UiSliderSetValue()
		{
		}
	}
}
