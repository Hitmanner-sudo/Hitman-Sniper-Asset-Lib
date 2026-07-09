using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3CF8", Offset = "0x5A3CF8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3CF8", Offset = "0x5A3CF8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3CF8", Offset = "0x5A3CF8")]
	public class SetProceduralBoolean : FsmStateAction
	{
		[Token(Token = "0x4004F3A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAD10", Offset = "0x5EAD10")]
		[RequiredField]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F3B")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAD5C", Offset = "0x5EAD5C")]
		public FsmString boolProperty;

		[Token(Token = "0x4004F3C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EADA8", Offset = "0x5EADA8")]
		[RequiredField]
		public FsmBool boolValue;

		[Token(Token = "0x4004F3D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EADF4", Offset = "0x5EADF4")]
		public bool everyFrame;

		[Token(Token = "0x60063EC")]
		[Address(RVA = "0x10428C0", Offset = "0x10428C0", VA = "0x10428C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x104292C", Offset = "0x104292C", VA = "0x104292C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x1042944", Offset = "0x1042944", VA = "0x1042944", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x1042940", Offset = "0x1042940", VA = "0x1042940")]
		private void DoSetProceduralFloat()
		{
		}

		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x1042948", Offset = "0x1042948", VA = "0x1042948")]
		public SetProceduralBoolean()
		{
		}
	}
}
