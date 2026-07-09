using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8FA4", Offset = "0x5A8FA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8FA4", Offset = "0x5A8FA4")]
	public class GetRotation : FsmStateAction
	{
		[Token(Token = "0x4005402")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBE6C", Offset = "0x5FBE6C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005403")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBEB8", Offset = "0x5FBEB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBEB8", Offset = "0x5FBEB8")]
		public FsmQuaternion quaternion;

		[Token(Token = "0x4005404")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FBF08", Offset = "0x5FBF08")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBF08", Offset = "0x5FBF08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBF08", Offset = "0x5FBF08")]
		public FsmVector3 vector;

		[Token(Token = "0x4005405")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBF7C", Offset = "0x5FBF7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBF7C", Offset = "0x5FBF7C")]
		public FsmFloat xAngle;

		[Token(Token = "0x4005406")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FBFCC", Offset = "0x5FBFCC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FBFCC", Offset = "0x5FBFCC")]
		public FsmFloat yAngle;

		[Token(Token = "0x4005407")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC01C", Offset = "0x5FC01C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC01C", Offset = "0x5FC01C")]
		public FsmFloat zAngle;

		[Token(Token = "0x4005408")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC06C", Offset = "0x5FC06C")]
		public Space space;

		[Token(Token = "0x4005409")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC0A4", Offset = "0x5FC0A4")]
		public bool everyFrame;

		[Token(Token = "0x60067E2")]
		[Address(RVA = "0x1068BB8", Offset = "0x1068BB8", VA = "0x1068BB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067E3")]
		[Address(RVA = "0x1068BCC", Offset = "0x1068BCC", VA = "0x1068BCC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067E4")]
		[Address(RVA = "0x1068DA0", Offset = "0x1068DA0", VA = "0x1068DA0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067E5")]
		[Address(RVA = "0x1068C08", Offset = "0x1068C08", VA = "0x1068C08")]
		private void DoGetRotation()
		{
		}

		[Token(Token = "0x60067E6")]
		[Address(RVA = "0x1068DA4", Offset = "0x1068DA4", VA = "0x1068DA4")]
		public GetRotation()
		{
		}
	}
}
