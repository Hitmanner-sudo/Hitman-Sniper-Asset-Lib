using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C640", Offset = "0x59C640")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C640", Offset = "0x59C640")]
	public class ControllerSettings : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004843")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE1FC", Offset = "0x5CE1FC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CE1FC", Offset = "0x5CE1FC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004844")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE290", Offset = "0x5CE290")]
		public FsmFloat height;

		[Token(Token = "0x4004845")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE2C8", Offset = "0x5CE2C8")]
		public FsmFloat radius;

		[Token(Token = "0x4004846")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE300", Offset = "0x5CE300")]
		public FsmFloat slopeLimit;

		[Token(Token = "0x4004847")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE338", Offset = "0x5CE338")]
		public FsmFloat stepOffset;

		[Token(Token = "0x4004848")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE370", Offset = "0x5CE370")]
		public FsmVector3 center;

		[Token(Token = "0x4004849")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE3A8", Offset = "0x5CE3A8")]
		public FsmBool detectCollisions;

		[Token(Token = "0x400484A")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE3E0", Offset = "0x5CE3E0")]
		public bool everyFrame;

		[Token(Token = "0x17000C29")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D87")]
			[Address(RVA = "0xD7E848", Offset = "0xD7E848", VA = "0xD7E848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D88")]
		[Address(RVA = "0xD7E850", Offset = "0xD7E850", VA = "0xD7E850", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D89")]
		[Address(RVA = "0xD7E99C", Offset = "0xD7E99C", VA = "0xD7E99C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D8A")]
		[Address(RVA = "0xD7EBA4", Offset = "0xD7EBA4", VA = "0xD7EBA4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D8B")]
		[Address(RVA = "0xD7E9D8", Offset = "0xD7E9D8", VA = "0xD7E9D8")]
		private void DoControllerSettings()
		{
		}

		[Token(Token = "0x6005D8C")]
		[Address(RVA = "0xD7EBA8", Offset = "0xD7EBA8", VA = "0xD7EBA8")]
		public ControllerSettings()
		{
		}
	}
}
