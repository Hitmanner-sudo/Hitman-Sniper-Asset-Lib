using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3420", Offset = "0x5A3420")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3420", Offset = "0x5A3420")]
	public class SetHingeJoint2dProperties : FsmStateAction
	{
		[Token(Token = "0x4004ED5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9014", Offset = "0x5E9014")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9014", Offset = "0x5E9014")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004ED6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ActionSection", RVA = "0x5E90A8", Offset = "0x5E90A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E90A8", Offset = "0x5E90A8")]
		public FsmBool useLimits;

		[Token(Token = "0x4004ED7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9108", Offset = "0x5E9108")]
		public FsmFloat min;

		[Token(Token = "0x4004ED8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9140", Offset = "0x5E9140")]
		public FsmFloat max;

		[Token(Token = "0x4004ED9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9178", Offset = "0x5E9178")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9178", Offset = "0x5E9178")]
		public FsmBool useMotor;

		[Token(Token = "0x4004EDA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E91D8", Offset = "0x5E91D8")]
		public FsmFloat motorSpeed;

		[Token(Token = "0x4004EDB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9210", Offset = "0x5E9210")]
		public FsmFloat maxMotorTorque;

		[Token(Token = "0x4004EDC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9248", Offset = "0x5E9248")]
		public bool everyFrame;

		[Token(Token = "0x4004EDD")]
		[FieldOffset(Offset = "0x90")]
		private HingeJoint2D _joint;

		[Token(Token = "0x4004EDE")]
		[FieldOffset(Offset = "0x98")]
		private JointMotor2D _motor;

		[Token(Token = "0x4004EDF")]
		[FieldOffset(Offset = "0xA0")]
		private JointAngleLimits2D _limits;

		[Token(Token = "0x600637B")]
		[Address(RVA = "0x103DF88", Offset = "0x103DF88", VA = "0x103DF88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600637C")]
		[Address(RVA = "0x103E0C4", Offset = "0x103E0C4", VA = "0x103E0C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600637D")]
		[Address(RVA = "0x103E41C", Offset = "0x103E41C", VA = "0x103E41C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600637E")]
		[Address(RVA = "0x103E204", Offset = "0x103E204", VA = "0x103E204")]
		private void SetProperties()
		{
		}

		[Token(Token = "0x600637F")]
		[Address(RVA = "0x103E420", Offset = "0x103E420", VA = "0x103E420")]
		public SetHingeJoint2dProperties()
		{
		}
	}
}
