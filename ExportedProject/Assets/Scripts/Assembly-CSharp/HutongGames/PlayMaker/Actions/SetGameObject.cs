using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FEA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F710", Offset = "0x59F710")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F710", Offset = "0x59F710")]
	public class SetGameObject : FsmStateAction
	{
		[Token(Token = "0x4004ACC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7F0C", Offset = "0x5D7F0C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7F0C", Offset = "0x5D7F0C")]
		public FsmGameObject variable;

		[Token(Token = "0x4004ACD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7F6C", Offset = "0x5D7F6C")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004ACE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7FA4", Offset = "0x5D7FA4")]
		public bool everyFrame;

		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x103D884", Offset = "0x103D884", VA = "0x103D884", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0x103D890", Offset = "0x103D890", VA = "0x103D890", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x103D8F4", Offset = "0x103D8F4", VA = "0x103D8F4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0x103D938", Offset = "0x103D938", VA = "0x103D938")]
		public SetGameObject()
		{
		}
	}
}
