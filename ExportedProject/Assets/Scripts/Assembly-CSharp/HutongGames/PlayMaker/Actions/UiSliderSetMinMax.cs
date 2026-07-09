using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001248")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABFF4", Offset = "0x5ABFF4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABFF4", Offset = "0x5ABFF4")]
	public class UiSliderSetMinMax : ComponentAction<Slider>
	{
		[Token(Token = "0x4005791")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608498", Offset = "0x608498")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608498", Offset = "0x608498")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005792")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60852C", Offset = "0x60852C")]
		public FsmFloat minValue;

		[Token(Token = "0x4005793")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608564", Offset = "0x608564")]
		public FsmFloat maxValue;

		[Token(Token = "0x4005794")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60859C", Offset = "0x60859C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005795")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6085D4", Offset = "0x6085D4")]
		public bool everyFrame;

		[Token(Token = "0x4005796")]
		[FieldOffset(Offset = "0x90")]
		private Slider slider;

		[Token(Token = "0x4005797")]
		[FieldOffset(Offset = "0x98")]
		private float originalMinValue;

		[Token(Token = "0x4005798")]
		[FieldOffset(Offset = "0x9C")]
		private float originalMaxValue;

		[Token(Token = "0x6006B08")]
		[Address(RVA = "0xB98F98", Offset = "0xB98F98", VA = "0xB98F98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B09")]
		[Address(RVA = "0xB99034", Offset = "0xB99034", VA = "0xB99034", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0xB991EC", Offset = "0xB991EC", VA = "0xB991EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0xB990FC", Offset = "0xB990FC", VA = "0xB990FC")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0xB991F0", Offset = "0xB991F0", VA = "0xB991F0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0xB992AC", Offset = "0xB992AC", VA = "0xB992AC")]
		public UiSliderSetMinMax()
		{
		}
	}
}
