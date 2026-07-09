using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599B70", Offset = "0x599B70")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599B70", Offset = "0x599B70")]
	public class SetAnimationSpeed : BaseAnimationAction
	{
		[Token(Token = "0x40045DE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3318", Offset = "0x5C3318")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3318", Offset = "0x5C3318")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045DF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C33AC", Offset = "0x5C33AC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C33AC", Offset = "0x5C33AC")]
		[RequiredField]
		public FsmString animName;

		[Token(Token = "0x40045E0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C340C", Offset = "0x5C340C")]
		public FsmFloat speed;

		[Token(Token = "0x40045E1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3444", Offset = "0x5C3444")]
		public bool everyFrame;

		[Token(Token = "0x6005B24")]
		[Address(RVA = "0x1034B10", Offset = "0x1034B10", VA = "0x1034B10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B25")]
		[Address(RVA = "0x1034B44", Offset = "0x1034B44", VA = "0x1034B44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B26")]
		[Address(RVA = "0x1034CFC", Offset = "0x1034CFC", VA = "0x1034CFC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B27")]
		[Address(RVA = "0x1034BB4", Offset = "0x1034BB4", VA = "0x1034BB4")]
		private void DoSetAnimationSpeed(GameObject go)
		{
		}

		[Token(Token = "0x6005B28")]
		[Address(RVA = "0x1034D4C", Offset = "0x1034D4C", VA = "0x1034D4C")]
		public SetAnimationSpeed()
		{
		}
	}
}
