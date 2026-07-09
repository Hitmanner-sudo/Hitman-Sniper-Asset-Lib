using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ACF0", Offset = "0x59ACF0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ACF0", Offset = "0x59ACF0")]
	public class SetAnimatorLayerWeight : ComponentAction<Animator>
	{
		[Token(Token = "0x40046E4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8754", Offset = "0x5C8754")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8754", Offset = "0x5C8754")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046E5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C87E8", Offset = "0x5C87E8")]
		[RequiredField]
		public FsmInt layerIndex;

		[Token(Token = "0x40046E6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8834", Offset = "0x5C8834")]
		[RequiredField]
		public FsmFloat layerWeight;

		[Token(Token = "0x40046E7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8880", Offset = "0x5C8880")]
		public bool everyFrame;

		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x1036458", Offset = "0x1036458", VA = "0x1036458", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x1036468", Offset = "0x1036468", VA = "0x1036468", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x103655C", Offset = "0x103655C", VA = "0x103655C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x10364A4", Offset = "0x10364A4", VA = "0x10364A4")]
		private void DoLayerWeight()
		{
		}

		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x1036560", Offset = "0x1036560", VA = "0x1036560")]
		public SetAnimatorLayerWeight()
		{
		}
	}
}
