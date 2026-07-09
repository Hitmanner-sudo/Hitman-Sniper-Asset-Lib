using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A60E0", Offset = "0x5A60E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A60E0", Offset = "0x5A60E0")]
	public class SetSpriteColor : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051C8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4AEC", Offset = "0x5F4AEC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4AEC", Offset = "0x5F4AEC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051C9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4B80", Offset = "0x5F4B80")]
		public FsmColor color;

		[Token(Token = "0x40051CA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4BB8", Offset = "0x5F4BB8")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F4BB8", Offset = "0x5F4BB8")]
		public FsmFloat red;

		[Token(Token = "0x40051CB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F4C0C", Offset = "0x5F4C0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4C0C", Offset = "0x5F4C0C")]
		public FsmFloat green;

		[Token(Token = "0x40051CC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F4C60", Offset = "0x5F4C60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4C60", Offset = "0x5F4C60")]
		public FsmFloat blue;

		[Token(Token = "0x40051CD")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F4CB4", Offset = "0x5F4CB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4CB4", Offset = "0x5F4CB4")]
		public FsmFloat alpha;

		[Token(Token = "0x40051CE")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4D08", Offset = "0x5F4D08")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40051CF")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4D40", Offset = "0x5F4D40")]
		public bool everyFrame;

		[Token(Token = "0x40051D0")]
		[FieldOffset(Offset = "0xA4")]
		private Color originalColor;

		[Token(Token = "0x40051D1")]
		[FieldOffset(Offset = "0xB4")]
		private Color newColor;

		[Token(Token = "0x600660F")]
		[Address(RVA = "0x10450A0", Offset = "0x10450A0", VA = "0x10450A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006610")]
		[Address(RVA = "0x1045180", Offset = "0x1045180", VA = "0x1045180", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006611")]
		[Address(RVA = "0x1045398", Offset = "0x1045398", VA = "0x1045398", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006612")]
		[Address(RVA = "0x104522C", Offset = "0x104522C", VA = "0x104522C")]
		private void SetColor()
		{
		}

		[Token(Token = "0x6006613")]
		[Address(RVA = "0x104539C", Offset = "0x104539C", VA = "0x104539C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006614")]
		[Address(RVA = "0x1045440", Offset = "0x1045440", VA = "0x1045440")]
		public SetSpriteColor()
		{
		}
	}
}
