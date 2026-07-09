using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3D7C", Offset = "0x5A3D7C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3D7C", Offset = "0x5A3D7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3D7C", Offset = "0x5A3D7C")]
	public class SetProceduralColor : FsmStateAction
	{
		[Token(Token = "0x4004F3E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAE2C", Offset = "0x5EAE2C")]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F3F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAE78", Offset = "0x5EAE78")]
		public FsmString colorProperty;

		[Token(Token = "0x4004F40")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAEC4", Offset = "0x5EAEC4")]
		[RequiredField]
		public FsmColor colorValue;

		[Token(Token = "0x4004F41")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAF10", Offset = "0x5EAF10")]
		public bool everyFrame;

		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x1042950", Offset = "0x1042950", VA = "0x1042950", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063F2")]
		[Address(RVA = "0x10429C0", Offset = "0x10429C0", VA = "0x10429C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x10429D8", Offset = "0x10429D8", VA = "0x10429D8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063F4")]
		[Address(RVA = "0x10429D4", Offset = "0x10429D4", VA = "0x10429D4")]
		private void DoSetProceduralFloat()
		{
		}

		[Token(Token = "0x60063F5")]
		[Address(RVA = "0x10429DC", Offset = "0x10429DC", VA = "0x10429DC")]
		public SetProceduralColor()
		{
		}
	}
}
