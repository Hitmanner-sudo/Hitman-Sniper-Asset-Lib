using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3C14", Offset = "0x5A3C14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3C14", Offset = "0x5A3C14")]
	public class PlayerPrefsSetString : FsmStateAction
	{
		[Token(Token = "0x4004F35")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EAB78", Offset = "0x5EAB78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAB78", Offset = "0x5EAB78")]
		public FsmString[] keys;

		[Token(Token = "0x4004F36")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAC08", Offset = "0x5EAC08")]
		public FsmString[] values;

		[Token(Token = "0x60063E4")]
		[Address(RVA = "0xAABF50", Offset = "0xAABF50", VA = "0xAABF50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063E5")]
		[Address(RVA = "0xAABFB4", Offset = "0xAABFB4", VA = "0xAABFB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063E6")]
		[Address(RVA = "0xAAC128", Offset = "0xAAC128", VA = "0xAAC128")]
		public PlayerPrefsSetString()
		{
		}
	}
}
