using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F47")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C550", Offset = "0x59C550")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C550", Offset = "0x59C550")]
	public class ControllerJump : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004827")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDAD0", Offset = "0x5CDAD0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CDAD0", Offset = "0x5CDAD0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004828")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDB64", Offset = "0x5CDB64")]
		public FsmFloat jumpHeight;

		[Token(Token = "0x4004829")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDB9C", Offset = "0x5CDB9C")]
		public Space space;

		[Token(Token = "0x400482A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDBD4", Offset = "0x5CDBD4")]
		public FsmFloat jumpSpeedMultiplier;

		[Token(Token = "0x400482B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDC0C", Offset = "0x5CDC0C")]
		public FsmFloat gravityMultiplier;

		[Token(Token = "0x400482C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDC44", Offset = "0x5CDC44")]
		public FsmFloat fallMultiplier;

		[Token(Token = "0x400482D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CDC7C", Offset = "0x5CDC7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDC7C", Offset = "0x5CDC7C")]
		[Attribute(Name = "ActionSection", RVA = "0x5CDC7C", Offset = "0x5CDC7C")]
		public FsmVector3 moveVector;

		[Token(Token = "0x400482E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDCF0", Offset = "0x5CDCF0")]
		public FsmFloat speed;

		[Token(Token = "0x400482F")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDD28", Offset = "0x5CDD28")]
		public FsmFloat maxSpeed;

		[Token(Token = "0x4004830")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDD60", Offset = "0x5CDD60")]
		[Attribute(Name = "ActionSection", RVA = "0x5CDD60", Offset = "0x5CDD60")]
		public FsmEvent landedEvent;

		[Token(Token = "0x4004831")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDDC0", Offset = "0x5CDDC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CDDC0", Offset = "0x5CDDC0")]
		public FsmFloat landingSpeed;

		[Token(Token = "0x4004832")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDE10", Offset = "0x5CDE10")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CDE10", Offset = "0x5CDE10")]
		public FsmVector3 landingMotion;

		[Token(Token = "0x4004833")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDE60", Offset = "0x5CDE60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CDE60", Offset = "0x5CDE60")]
		public FsmFloat fallDistance;

		[Token(Token = "0x4004834")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 startJumpPosition;

		[Token(Token = "0x4004835")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 totalJumpMovement;

		[Token(Token = "0x17000C27")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D7B")]
			[Address(RVA = "0xD7D944", Offset = "0xD7D944", VA = "0xD7D944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D7C")]
		[Address(RVA = "0xD7D94C", Offset = "0xD7D94C", VA = "0xD7D94C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0xD7DA7C", Offset = "0xD7DA7C", VA = "0xD7DA7C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0xD7DC8C", Offset = "0xD7DC8C", VA = "0xD7DC8C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D7F")]
		[Address(RVA = "0xD7DF94", Offset = "0xD7DF94", VA = "0xD7DF94")]
		public ControllerJump()
		{
		}
	}
}
