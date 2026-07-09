using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABCD4", Offset = "0x5ABCD4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABCD4", Offset = "0x5ABCD4")]
	public class UiScrollbarSetNumberOfSteps : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x400575F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607738", Offset = "0x607738")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607738", Offset = "0x607738")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005760")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6077CC", Offset = "0x6077CC")]
		public FsmInt value;

		[Token(Token = "0x4005761")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607818", Offset = "0x607818")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005762")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607850", Offset = "0x607850")]
		public bool everyFrame;

		[Token(Token = "0x4005763")]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar scrollbar;

		[Token(Token = "0x4005764")]
		[FieldOffset(Offset = "0x90")]
		private int originalValue;

		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0xB96BC8", Offset = "0xB96BC8", VA = "0xB96BC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0xB96BD8", Offset = "0xB96BD8", VA = "0xB96BD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0xB96D34", Offset = "0xB96D34", VA = "0xB96D34", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0xB96C8C", Offset = "0xB96C8C", VA = "0xB96C8C")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0xB96D38", Offset = "0xB96D38", VA = "0xB96D38", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0xB96DE0", Offset = "0xB96DE0", VA = "0xB96DE0")]
		public UiScrollbarSetNumberOfSteps()
		{
		}
	}
}
