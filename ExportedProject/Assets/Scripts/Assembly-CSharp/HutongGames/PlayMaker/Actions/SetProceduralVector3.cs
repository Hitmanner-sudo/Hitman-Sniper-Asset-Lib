using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3F08", Offset = "0x5A3F08")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3F08", Offset = "0x5A3F08")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3F08", Offset = "0x5A3F08")]
	public class SetProceduralVector3 : FsmStateAction
	{
		[Token(Token = "0x4004F4A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB180", Offset = "0x5EB180")]
		[RequiredField]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F4B")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB1CC", Offset = "0x5EB1CC")]
		public FsmString vector3Property;

		[Token(Token = "0x4004F4C")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB218", Offset = "0x5EB218")]
		public FsmVector3 vector3Value;

		[Token(Token = "0x4004F4D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB264", Offset = "0x5EB264")]
		public bool everyFrame;

		[Token(Token = "0x6006400")]
		[Address(RVA = "0x1042AA8", Offset = "0x1042AA8", VA = "0x1042AA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006401")]
		[Address(RVA = "0x1042AB8", Offset = "0x1042AB8", VA = "0x1042AB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006402")]
		[Address(RVA = "0x1042AD0", Offset = "0x1042AD0", VA = "0x1042AD0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006403")]
		[Address(RVA = "0x1042ACC", Offset = "0x1042ACC", VA = "0x1042ACC")]
		private void DoSetProceduralVector()
		{
		}

		[Token(Token = "0x6006404")]
		[Address(RVA = "0x1042AD4", Offset = "0x1042AD4", VA = "0x1042AD4")]
		public SetProceduralVector3()
		{
		}
	}
}
