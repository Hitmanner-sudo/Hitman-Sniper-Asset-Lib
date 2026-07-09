using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001271")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACC74", Offset = "0x5ACC74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACC74", Offset = "0x5ACC74")]
	public class SetVector3XYZ : FsmStateAction
	{
		[Token(Token = "0x400583F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60ADB8", Offset = "0x60ADB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60ADB8", Offset = "0x60ADB8")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005840")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60AE18", Offset = "0x60AE18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AE18", Offset = "0x60AE18")]
		public FsmVector3 vector3Value;

		[Token(Token = "0x4005841")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AE68", Offset = "0x60AE68")]
		public FsmFloat x;

		[Token(Token = "0x4005842")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AEA0", Offset = "0x60AEA0")]
		public FsmFloat y;

		[Token(Token = "0x4005843")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AED8", Offset = "0x60AED8")]
		public FsmFloat z;

		[Token(Token = "0x4005844")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AF10", Offset = "0x60AF10")]
		public bool everyFrame;

		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0x83C534", Offset = "0x83C534", VA = "0x83C534", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x83C5F4", Offset = "0x83C5F4", VA = "0x83C5F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BC6")]
		[Address(RVA = "0x83C734", Offset = "0x83C734", VA = "0x83C734", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BC7")]
		[Address(RVA = "0x83C630", Offset = "0x83C630", VA = "0x83C630")]
		private void DoSetVector3XYZ()
		{
		}

		[Token(Token = "0x6006BC8")]
		[Address(RVA = "0x83C738", Offset = "0x83C738", VA = "0x83C738")]
		public SetVector3XYZ()
		{
		}
	}
}
