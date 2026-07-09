using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001029")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0B90", Offset = "0x5A0B90")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0B90", Offset = "0x5A0B90")]
	public class GameObjectCompare : FsmStateAction
	{
		[Token(Token = "0x4004BDF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC3A0", Offset = "0x5DC3A0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC3A0", Offset = "0x5DC3A0")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5DC3A0", Offset = "0x5DC3A0")]
		public FsmOwnerDefault gameObjectVariable;

		[Token(Token = "0x4004BE0")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC424", Offset = "0x5DC424")]
		public FsmGameObject compareTo;

		[Token(Token = "0x4004BE1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC470", Offset = "0x5DC470")]
		public FsmEvent equalEvent;

		[Token(Token = "0x4004BE2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC4A8", Offset = "0x5DC4A8")]
		public FsmEvent notEqualEvent;

		[Token(Token = "0x4004BE3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC4E0", Offset = "0x5DC4E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC4E0", Offset = "0x5DC4E0")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BE4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC530", Offset = "0x5DC530")]
		public bool everyFrame;

		[Token(Token = "0x60060ED")]
		[Address(RVA = "0xD997D4", Offset = "0xD997D4", VA = "0xD997D4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060EE")]
		[Address(RVA = "0xD997E8", Offset = "0xD997E8", VA = "0xD997E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060EF")]
		[Address(RVA = "0xD99910", Offset = "0xD99910", VA = "0xD99910", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060F0")]
		[Address(RVA = "0xD99824", Offset = "0xD99824", VA = "0xD99824")]
		private void DoGameObjectCompare()
		{
		}

		[Token(Token = "0x60060F1")]
		[Address(RVA = "0xD99914", Offset = "0xD99914", VA = "0xD99914")]
		public GameObjectCompare()
		{
		}
	}
}
