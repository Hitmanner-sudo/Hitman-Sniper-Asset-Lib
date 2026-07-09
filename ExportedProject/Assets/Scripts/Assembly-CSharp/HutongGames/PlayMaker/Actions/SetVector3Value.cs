using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001270")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACC24", Offset = "0x5ACC24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACC24", Offset = "0x5ACC24")]
	public class SetVector3Value : FsmStateAction
	{
		[Token(Token = "0x400583C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60ACD4", Offset = "0x60ACD4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60ACD4", Offset = "0x60ACD4")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400583D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AD34", Offset = "0x60AD34")]
		[RequiredField]
		public FsmVector3 vector3Value;

		[Token(Token = "0x400583E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AD80", Offset = "0x60AD80")]
		public bool everyFrame;

		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x83C484", Offset = "0x83C484", VA = "0x83C484", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x83C490", Offset = "0x83C490", VA = "0x83C490", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x83C4EC", Offset = "0x83C4EC", VA = "0x83C4EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0x83C52C", Offset = "0x83C52C", VA = "0x83C52C")]
		public SetVector3Value()
		{
		}
	}
}
