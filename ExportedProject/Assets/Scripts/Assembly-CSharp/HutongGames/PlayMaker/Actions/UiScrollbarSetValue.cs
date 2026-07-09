using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001240")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABD74", Offset = "0x5ABD74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABD74", Offset = "0x5ABD74")]
	public class UiScrollbarSetValue : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x400576B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6079F0", Offset = "0x6079F0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6079F0", Offset = "0x6079F0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400576C")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607A84", Offset = "0x607A84")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x607A84", Offset = "0x607A84")]
		public FsmFloat value;

		[Token(Token = "0x400576D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607AE8", Offset = "0x607AE8")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400576E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607B20", Offset = "0x607B20")]
		public bool everyFrame;

		[Token(Token = "0x400576F")]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar scrollbar;

		[Token(Token = "0x4005770")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0xB97098", Offset = "0xB97098", VA = "0xB97098", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AE2")]
		[Address(RVA = "0xB970A8", Offset = "0xB970A8", VA = "0xB970A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AE3")]
		[Address(RVA = "0xB97204", Offset = "0xB97204", VA = "0xB97204", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AE4")]
		[Address(RVA = "0xB97160", Offset = "0xB97160", VA = "0xB97160")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AE5")]
		[Address(RVA = "0xB97208", Offset = "0xB97208", VA = "0xB97208", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AE6")]
		[Address(RVA = "0xB972B0", Offset = "0xB972B0", VA = "0xB972B0")]
		public UiScrollbarSetValue()
		{
		}
	}
}
