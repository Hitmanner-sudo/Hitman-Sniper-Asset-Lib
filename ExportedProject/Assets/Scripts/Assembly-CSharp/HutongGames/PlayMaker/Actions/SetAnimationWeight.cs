using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599C10", Offset = "0x599C10")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599C10", Offset = "0x599C10")]
	public class SetAnimationWeight : BaseAnimationAction
	{
		[Token(Token = "0x40045E7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3618", Offset = "0x5C3618")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3618", Offset = "0x5C3618")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045E8")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C36AC", Offset = "0x5C36AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C36AC", Offset = "0x5C36AC")]
		public FsmString animName;

		[Token(Token = "0x40045E9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C370C", Offset = "0x5C370C")]
		public FsmFloat weight;

		[Token(Token = "0x40045EA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3744", Offset = "0x5C3744")]
		public bool everyFrame;

		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0x1035000", Offset = "0x1035000", VA = "0x1035000", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x1035034", Offset = "0x1035034", VA = "0x1035034", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x10351EC", Offset = "0x10351EC", VA = "0x10351EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x10350A4", Offset = "0x10350A4", VA = "0x10350A4")]
		private void DoSetAnimationWeight(GameObject go)
		{
		}

		[Token(Token = "0x6005B32")]
		[Address(RVA = "0x103523C", Offset = "0x103523C", VA = "0x103523C")]
		public SetAnimationWeight()
		{
		}
	}
}
