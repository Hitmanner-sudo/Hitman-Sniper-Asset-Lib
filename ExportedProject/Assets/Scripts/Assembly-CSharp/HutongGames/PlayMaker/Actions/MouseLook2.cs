using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001002")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FE58", Offset = "0x59FE58")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59FE58", Offset = "0x59FE58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FE58", Offset = "0x59FE58")]
	public class MouseLook2 : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x2001003")]
		public enum RotationAxes
		{
			[Token(Token = "0x4004B30")]
			MouseXAndY = 0,
			[Token(Token = "0x4004B31")]
			MouseX = 1,
			[Token(Token = "0x4004B32")]
			MouseY = 2
		}

		[Token(Token = "0x4004B24")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9400", Offset = "0x5D9400")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B25")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D944C", Offset = "0x5D944C")]
		public RotationAxes axes;

		[Token(Token = "0x4004B26")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9484", Offset = "0x5D9484")]
		public FsmFloat sensitivityX;

		[Token(Token = "0x4004B27")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D94D0", Offset = "0x5D94D0")]
		public FsmFloat sensitivityY;

		[Token(Token = "0x4004B28")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D951C", Offset = "0x5D951C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D951C", Offset = "0x5D951C")]
		public FsmFloat minimumX;

		[Token(Token = "0x4004B29")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9588", Offset = "0x5D9588")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D9588", Offset = "0x5D9588")]
		[RequiredField]
		public FsmFloat maximumX;

		[Token(Token = "0x4004B2A")]
		[FieldOffset(Offset = "0x98")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D95F4", Offset = "0x5D95F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D95F4", Offset = "0x5D95F4")]
		public FsmFloat minimumY;

		[Token(Token = "0x4004B2B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9660", Offset = "0x5D9660")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D9660", Offset = "0x5D9660")]
		[RequiredField]
		public FsmFloat maximumY;

		[Token(Token = "0x4004B2C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D96CC", Offset = "0x5D96CC")]
		public bool everyFrame;

		[Token(Token = "0x4004B2D")]
		[FieldOffset(Offset = "0xAC")]
		private float rotationX;

		[Token(Token = "0x4004B2E")]
		[FieldOffset(Offset = "0xB0")]
		private float rotationY;

		[Token(Token = "0x6006045")]
		[Address(RVA = "0xA2CE00", Offset = "0xA2CE00", VA = "0xA2CE00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006046")]
		[Address(RVA = "0xA2CEA8", Offset = "0xA2CEA8", VA = "0xA2CEA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006047")]
		[Address(RVA = "0xA2D150", Offset = "0xA2D150", VA = "0xA2D150", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006048")]
		[Address(RVA = "0xA2CFFC", Offset = "0xA2CFFC", VA = "0xA2CFFC")]
		private void DoMouseLook()
		{
		}

		[Token(Token = "0x6006049")]
		[Address(RVA = "0xA2D1E0", Offset = "0xA2D1E0", VA = "0xA2D1E0")]
		private float GetXRotation()
		{
			return default(float);
		}

		[Token(Token = "0x600604A")]
		[Address(RVA = "0xA2D154", Offset = "0xA2D154", VA = "0xA2D154")]
		private float GetYRotation()
		{
			return default(float);
		}

		[Token(Token = "0x600604B")]
		[Address(RVA = "0xA2D26C", Offset = "0xA2D26C", VA = "0xA2D26C")]
		private static float ClampAngle(float angle, FsmFloat min, FsmFloat max)
		{
			return default(float);
		}

		[Token(Token = "0x600604C")]
		[Address(RVA = "0xA2D314", Offset = "0xA2D314", VA = "0xA2D314")]
		public MouseLook2()
		{
		}
	}
}
