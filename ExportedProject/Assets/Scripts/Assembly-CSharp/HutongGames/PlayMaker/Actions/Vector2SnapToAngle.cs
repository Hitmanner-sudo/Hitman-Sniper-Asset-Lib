using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACA44", Offset = "0x5ACA44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACA44", Offset = "0x5ACA44")]
	public class Vector2SnapToAngle : FsmStateAction
	{
		[Token(Token = "0x4005827")]
		[FieldOffset(Offset = "0x0")]
		private static bool showPreview;

		[Token(Token = "0x4005828")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A68C", Offset = "0x60A68C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A68C", Offset = "0x60A68C")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x4005829")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A6EC", Offset = "0x60A6EC")]
		[Attribute(Name = "PreviewFieldAttribute", RVA = "0x60A6EC", Offset = "0x60A6EC")]
		public FsmFloat snapAngle;

		[Token(Token = "0x400582A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A74C", Offset = "0x60A74C")]
		public bool everyFrame;

		[Token(Token = "0x6006BA4")]
		[Address(RVA = "0x13C73AC", Offset = "0x13C73AC", VA = "0x13C73AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BA5")]
		[Address(RVA = "0x13C73E0", Offset = "0x13C73E0", VA = "0x13C73E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BA6")]
		[Address(RVA = "0x13C7550", Offset = "0x13C7550", VA = "0x13C7550", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BA7")]
		[Address(RVA = "0x13C741C", Offset = "0x13C741C", VA = "0x13C741C")]
		private void DoSnapToAngle()
		{
		}

		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x13C7554", Offset = "0x13C7554", VA = "0x13C7554")]
		public Vector2SnapToAngle()
		{
		}
	}
}
