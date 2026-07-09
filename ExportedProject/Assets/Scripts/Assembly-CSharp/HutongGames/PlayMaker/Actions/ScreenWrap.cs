using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001129")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5B90", Offset = "0x5A5B90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5B90", Offset = "0x5A5B90")]
	public class ScreenWrap : ComponentAction<Transform, Camera>
	{
		[Token(Token = "0x4005168")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3298", Offset = "0x5F3298")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005169")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F32E4", Offset = "0x5F32E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F32E4", Offset = "0x5F32E4")]
		public FsmGameObject camera;

		[Token(Token = "0x400516A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3368", Offset = "0x5F3368")]
		public FsmBool wrapLeft;

		[Token(Token = "0x400516B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F33A0", Offset = "0x5F33A0")]
		public FsmBool wrapRight;

		[Token(Token = "0x400516C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F33D8", Offset = "0x5F33D8")]
		public FsmBool wrapTop;

		[Token(Token = "0x400516D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3410", Offset = "0x5F3410")]
		public FsmBool wrapBottom;

		[Token(Token = "0x400516E")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3448", Offset = "0x5F3448")]
		public bool everyFrame;

		[Token(Token = "0x400516F")]
		[FieldOffset(Offset = "0xA9")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3480", Offset = "0x5F3480")]
		public bool lateUpdate;

		[Token(Token = "0x17000C41")]
		private Camera cameraComponent
		{
			[Token(Token = "0x60065BB")]
			[Address(RVA = "0xB677A0", Offset = "0xB677A0", VA = "0xB677A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C42")]
		private Transform cameraTransform
		{
			[Token(Token = "0x60065BC")]
			[Address(RVA = "0xB677A8", Offset = "0xB677A8", VA = "0xB677A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C43")]
		private Transform gameObjectTransform
		{
			[Token(Token = "0x60065BD")]
			[Address(RVA = "0xB677B0", Offset = "0xB677B0", VA = "0xB677B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60065BE")]
		[Address(RVA = "0xB677B8", Offset = "0xB677B8", VA = "0xB677B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065BF")]
		[Address(RVA = "0xB6789C", Offset = "0xB6789C", VA = "0xB6789C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60065C0")]
		[Address(RVA = "0xB678C8", Offset = "0xB678C8", VA = "0xB678C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xB67BA8", Offset = "0xB67BA8", VA = "0xB67BA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xB67BB8", Offset = "0xB67BB8", VA = "0xB67BB8", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xB67910", Offset = "0xB67910", VA = "0xB67910")]
		private void DoScreenWrap()
		{
		}

		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xB67C00", Offset = "0xB67C00", VA = "0xB67C00")]
		private static float Wrap01(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xB67C0C", Offset = "0xB67C0C", VA = "0xB67C0C")]
		private static float Wrap(float x, float xMin, float xMax)
		{
			return default(float);
		}

		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xB67C58", Offset = "0xB67C58", VA = "0xB67C58")]
		public ScreenWrap()
		{
		}
	}
}
