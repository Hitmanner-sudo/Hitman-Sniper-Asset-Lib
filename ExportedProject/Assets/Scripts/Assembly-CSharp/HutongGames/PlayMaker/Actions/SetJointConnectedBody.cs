using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001084")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2784", Offset = "0x5A2784")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2784", Offset = "0x5A2784")]
	public class SetJointConnectedBody : FsmStateAction
	{
		[Token(Token = "0x4004DB7")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4248", Offset = "0x5E4248")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4248", Offset = "0x5E4248")]
		public FsmOwnerDefault joint;

		[Token(Token = "0x4004DB8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E42DC", Offset = "0x5E42DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E42DC", Offset = "0x5E42DC")]
		public FsmGameObject rigidBody;

		[Token(Token = "0x60062A5")]
		[Address(RVA = "0x103EA34", Offset = "0x103EA34", VA = "0x103EA34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062A6")]
		[Address(RVA = "0x103EA3C", Offset = "0x103EA3C", VA = "0x103EA3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062A7")]
		[Address(RVA = "0x103EBC0", Offset = "0x103EBC0", VA = "0x103EBC0")]
		public SetJointConnectedBody()
		{
		}
	}
}
