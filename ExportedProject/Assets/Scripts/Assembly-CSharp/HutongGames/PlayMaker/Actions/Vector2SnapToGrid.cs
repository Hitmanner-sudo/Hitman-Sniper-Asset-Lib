using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACA94", Offset = "0x5ACA94")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACA94", Offset = "0x5ACA94")]
	public class Vector2SnapToGrid : FsmStateAction
	{
		[Token(Token = "0x400582B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A784", Offset = "0x60A784")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A784", Offset = "0x60A784")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x400582C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A7E4", Offset = "0x60A7E4")]
		public FsmFloat gridSize;

		[Token(Token = "0x400582D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A81C", Offset = "0x60A81C")]
		public bool everyFrame;

		[Token(Token = "0x6006BA9")]
		[Address(RVA = "0x13C755C", Offset = "0x13C755C", VA = "0x13C755C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0x13C75CC", Offset = "0x13C75CC", VA = "0x13C75CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BAB")]
		[Address(RVA = "0x13C777C", Offset = "0x13C777C", VA = "0x13C777C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BAC")]
		[Address(RVA = "0x13C7608", Offset = "0x13C7608", VA = "0x13C7608")]
		private void DoSnapToGrid()
		{
		}

		[Token(Token = "0x6006BAD")]
		[Address(RVA = "0x13C7780", Offset = "0x13C7780", VA = "0x13C7780")]
		public Vector2SnapToGrid()
		{
		}
	}
}
