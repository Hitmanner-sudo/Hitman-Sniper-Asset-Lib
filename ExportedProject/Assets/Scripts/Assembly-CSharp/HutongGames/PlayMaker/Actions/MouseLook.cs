using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001000")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FE08", Offset = "0x59FE08")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FE08", Offset = "0x59FE08")]
	public class MouseLook : ComponentAction<Transform>
	{
		[Token(Token = "0x2001001")]
		public enum RotationAxes
		{
			[Token(Token = "0x4004B21")]
			MouseXAndY = 0,
			[Token(Token = "0x4004B22")]
			MouseX = 1,
			[Token(Token = "0x4004B23")]
			MouseY = 2
		}

		[Token(Token = "0x4004B15")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D913C", Offset = "0x5D913C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B16")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9188", Offset = "0x5D9188")]
		public RotationAxes axes;

		[Token(Token = "0x4004B17")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D91C0", Offset = "0x5D91C0")]
		[RequiredField]
		public FsmFloat sensitivityX;

		[Token(Token = "0x4004B18")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D920C", Offset = "0x5D920C")]
		public FsmFloat sensitivityY;

		[Token(Token = "0x4004B19")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9258", Offset = "0x5D9258")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D9258", Offset = "0x5D9258")]
		public FsmFloat minimumX;

		[Token(Token = "0x4004B1A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D92B4", Offset = "0x5D92B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D92B4", Offset = "0x5D92B4")]
		public FsmFloat maximumX;

		[Token(Token = "0x4004B1B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D9310", Offset = "0x5D9310")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9310", Offset = "0x5D9310")]
		public FsmFloat minimumY;

		[Token(Token = "0x4004B1C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D936C", Offset = "0x5D936C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D936C", Offset = "0x5D936C")]
		public FsmFloat maximumY;

		[Token(Token = "0x4004B1D")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D93C8", Offset = "0x5D93C8")]
		public bool everyFrame;

		[Token(Token = "0x4004B1E")]
		[FieldOffset(Offset = "0xAC")]
		private float rotationX;

		[Token(Token = "0x4004B1F")]
		[FieldOffset(Offset = "0xB0")]
		private float rotationY;

		[Token(Token = "0x600603D")]
		[Address(RVA = "0xA2C7E4", Offset = "0xA2C7E4", VA = "0xA2C7E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600603E")]
		[Address(RVA = "0xA2C8D8", Offset = "0xA2C8D8", VA = "0xA2C8D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600603F")]
		[Address(RVA = "0xA2CB9C", Offset = "0xA2CB9C", VA = "0xA2CB9C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006040")]
		[Address(RVA = "0xA2CA4C", Offset = "0xA2CA4C", VA = "0xA2CA4C")]
		private void DoMouseLook()
		{
		}

		[Token(Token = "0x6006041")]
		[Address(RVA = "0xA2CC48", Offset = "0xA2CC48", VA = "0xA2CC48")]
		private float GetXRotation()
		{
			return default(float);
		}

		[Token(Token = "0x6006042")]
		[Address(RVA = "0xA2CBA0", Offset = "0xA2CBA0", VA = "0xA2CBA0")]
		private float GetYRotation(float invert = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6006043")]
		[Address(RVA = "0xA2CCE0", Offset = "0xA2CCE0", VA = "0xA2CCE0")]
		private static float ClampAngle(float angle, FsmFloat min, FsmFloat max)
		{
			return default(float);
		}

		[Token(Token = "0x6006044")]
		[Address(RVA = "0xA2CDB4", Offset = "0xA2CDB4", VA = "0xA2CDB4")]
		public MouseLook()
		{
		}
	}
}
