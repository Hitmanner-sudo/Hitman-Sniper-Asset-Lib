using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102F")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A0DD8", Offset = "0x5A0DD8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0DD8", Offset = "0x5A0DD8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0DD8", Offset = "0x5A0DD8")]
	public class GameObjectIsVisibleToCamera : ComponentAction<Renderer, Camera>
	{
		[Token(Token = "0x4004BFF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DCC9C", Offset = "0x5DCC9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCC9C", Offset = "0x5DCC9C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C00")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCD30", Offset = "0x5DCD30")]
		public FsmGameObject camera;

		[Token(Token = "0x4004C01")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCD68", Offset = "0x5DCD68")]
		public FsmBool useBounds;

		[Token(Token = "0x4004C02")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCDA0", Offset = "0x5DCDA0")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004C03")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCDD8", Offset = "0x5DCDD8")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004C04")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCE10", Offset = "0x5DCE10")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DCE10", Offset = "0x5DCE10")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C05")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCE60", Offset = "0x5DCE60")]
		public bool everyFrame;

		[Token(Token = "0x17000C3A")]
		private Camera cameraComponent
		{
			[Token(Token = "0x600610A")]
			[Address(RVA = "0xD9A014", Offset = "0xD9A014", VA = "0xD9A014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600610B")]
		[Address(RVA = "0xD9A01C", Offset = "0xD9A01C", VA = "0xD9A01C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600610C")]
		[Address(RVA = "0xD9A034", Offset = "0xD9A034", VA = "0xD9A034", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600610D")]
		[Address(RVA = "0xD9A170", Offset = "0xD9A170", VA = "0xD9A170", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600610E")]
		[Address(RVA = "0xD9A070", Offset = "0xD9A070", VA = "0xD9A070")]
		private void DoIsVisible()
		{
		}

		[Token(Token = "0x600610F")]
		[Address(RVA = "0xD9A174", Offset = "0xD9A174", VA = "0xD9A174")]
		public GameObjectIsVisibleToCamera()
		{
		}
	}
}
