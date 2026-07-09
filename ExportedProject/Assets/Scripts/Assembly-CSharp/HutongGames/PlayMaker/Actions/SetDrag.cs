using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001081")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2670", Offset = "0x5A2670")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2670", Offset = "0x5A2670")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x5A2670", Offset = "0x5A2670")]
	public class SetDrag : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DAD")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E3F20", Offset = "0x5E3F20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3F20", Offset = "0x5E3F20")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DAE")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E3FB4", Offset = "0x5E3FB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3FB4", Offset = "0x5E3FB4")]
		public FsmFloat drag;

		[Token(Token = "0x4004DAF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4018", Offset = "0x5E4018")]
		public bool everyFrame;

		[Token(Token = "0x6006297")]
		[Address(RVA = "0x1038FA0", Offset = "0x1038FA0", VA = "0x1038FA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006298")]
		[Address(RVA = "0x1038FD0", Offset = "0x1038FD0", VA = "0x1038FD0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006299")]
		[Address(RVA = "0x10390CC", Offset = "0x10390CC", VA = "0x10390CC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600629A")]
		[Address(RVA = "0x103900C", Offset = "0x103900C", VA = "0x103900C")]
		private void DoSetDrag()
		{
		}

		[Token(Token = "0x600629B")]
		[Address(RVA = "0x10390D0", Offset = "0x10390D0", VA = "0x10390D0")]
		public SetDrag()
		{
		}
	}
}
