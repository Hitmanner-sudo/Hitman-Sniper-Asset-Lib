using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F49")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C5F0", Offset = "0x59C5F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C5F0", Offset = "0x59C5F0")]
	public class ControllerMoveInAir : ComponentAction<CharacterController>
	{
		[Token(Token = "0x400483C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CE000", Offset = "0x5CE000")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE000", Offset = "0x5CE000")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400483D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE094", Offset = "0x5CE094")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE094", Offset = "0x5CE094")]
		public FsmVector3 moveVector;

		[Token(Token = "0x400483E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE0E4", Offset = "0x5CE0E4")]
		public FsmFloat maxMoveSpeed;

		[Token(Token = "0x400483F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE11C", Offset = "0x5CE11C")]
		public FsmFloat gravityMultiplier;

		[Token(Token = "0x4004840")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE154", Offset = "0x5CE154")]
		public FsmFloat fallMultiplier;

		[Token(Token = "0x4004841")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE18C", Offset = "0x5CE18C")]
		public Space space;

		[Token(Token = "0x4004842")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE1C4", Offset = "0x5CE1C4")]
		public FsmEvent landedEvent;

		[Token(Token = "0x17000C28")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D83")]
			[Address(RVA = "0xD7E288", Offset = "0xD7E288", VA = "0xD7E288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D84")]
		[Address(RVA = "0xD7E290", Offset = "0xD7E290", VA = "0xD7E290", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D85")]
		[Address(RVA = "0xD7E330", Offset = "0xD7E330", VA = "0xD7E330", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D86")]
		[Address(RVA = "0xD7E60C", Offset = "0xD7E60C", VA = "0xD7E60C")]
		public ControllerMoveInAir()
		{
		}
	}
}
