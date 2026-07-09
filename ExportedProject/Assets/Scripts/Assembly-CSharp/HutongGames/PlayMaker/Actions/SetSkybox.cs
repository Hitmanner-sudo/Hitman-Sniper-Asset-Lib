using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001106")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A52FC", Offset = "0x5A52FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A52FC", Offset = "0x5A52FC")]
	public class SetSkybox : FsmStateAction
	{
		[Token(Token = "0x4005091")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F041C", Offset = "0x5F041C")]
		public FsmMaterial skybox;

		[Token(Token = "0x4005092")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0454", Offset = "0x5F0454")]
		public bool everyFrame;

		[Token(Token = "0x600653A")]
		[Address(RVA = "0x1044EE8", Offset = "0x1044EE8", VA = "0x1044EE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600653B")]
		[Address(RVA = "0x1044EF0", Offset = "0x1044EF0", VA = "0x1044EF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600653C")]
		[Address(RVA = "0x1044F44", Offset = "0x1044F44", VA = "0x1044F44", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600653D")]
		[Address(RVA = "0x1044F6C", Offset = "0x1044F6C", VA = "0x1044F6C")]
		public SetSkybox()
		{
		}
	}
}
