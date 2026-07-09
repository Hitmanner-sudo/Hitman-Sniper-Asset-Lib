using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9428", Offset = "0x5A9428")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9428", Offset = "0x5A9428")]
	public class SimpleLook : ComponentAction<Transform>
	{
		[Token(Token = "0x4005468")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD620", Offset = "0x5FD620")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005469")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD66C", Offset = "0x5FD66C")]
		public new FsmGameObject camera;

		[Token(Token = "0x400546A")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD6A4", Offset = "0x5FD6A4")]
		public FsmVector2 vector2Input;

		[Token(Token = "0x400546B")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD6F0", Offset = "0x5FD6F0")]
		public FsmFloat sensitivityX;

		[Token(Token = "0x400546C")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD73C", Offset = "0x5FD73C")]
		public FsmFloat sensitivityY;

		[Token(Token = "0x400546D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FD788", Offset = "0x5FD788")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD788", Offset = "0x5FD788")]
		public FsmFloat minimumX;

		[Token(Token = "0x400546E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FD7E4", Offset = "0x5FD7E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD7E4", Offset = "0x5FD7E4")]
		public FsmFloat maximumX;

		[Token(Token = "0x400546F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD840", Offset = "0x5FD840")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FD840", Offset = "0x5FD840")]
		public FsmFloat minimumY;

		[Token(Token = "0x4005470")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FD89C", Offset = "0x5FD89C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD89C", Offset = "0x5FD89C")]
		public FsmFloat maximumY;

		[Token(Token = "0x4005471")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD8F8", Offset = "0x5FD8F8")]
		public bool everyFrame;

		[Token(Token = "0x4005472")]
		[FieldOffset(Offset = "0xB4")]
		private float rotationX;

		[Token(Token = "0x4005473")]
		[FieldOffset(Offset = "0xB8")]
		private float rotationY;

		[Token(Token = "0x4005474")]
		[FieldOffset(Offset = "0xC0")]
		private Transform cachedCameraTransform;

		[Token(Token = "0x6006839")]
		[Address(RVA = "0x845948", Offset = "0x845948", VA = "0x845948", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600683A")]
		[Address(RVA = "0x845A70", Offset = "0x845A70", VA = "0x845A70", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600683B")]
		[Address(RVA = "0x845E14", Offset = "0x845E14", VA = "0x845E14", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600683C")]
		[Address(RVA = "0x845CA0", Offset = "0x845CA0", VA = "0x845CA0")]
		private void DoLookRotate()
		{
		}

		[Token(Token = "0x600683D")]
		[Address(RVA = "0x845E94", Offset = "0x845E94", VA = "0x845E94")]
		private float GetXRotation()
		{
			return default(float);
		}

		[Token(Token = "0x600683E")]
		[Address(RVA = "0x845E18", Offset = "0x845E18", VA = "0x845E18")]
		private float GetYRotation(float invert = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x600683F")]
		[Address(RVA = "0x845F00", Offset = "0x845F00", VA = "0x845F00")]
		private static float ClampAngle(float angle, FsmFloat min, FsmFloat max)
		{
			return default(float);
		}

		[Token(Token = "0x6006840")]
		[Address(RVA = "0x845FD4", Offset = "0x845FD4", VA = "0x845FD4")]
		public SimpleLook()
		{
		}
	}
}
