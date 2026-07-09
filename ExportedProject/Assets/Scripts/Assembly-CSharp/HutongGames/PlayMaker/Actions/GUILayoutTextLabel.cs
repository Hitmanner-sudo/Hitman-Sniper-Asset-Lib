using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EAC8", Offset = "0x59EAC8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EAC8", Offset = "0x59EAC8")]
	public class GUILayoutTextLabel : GUILayoutAction
	{
		[Token(Token = "0x4004A31")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5770", Offset = "0x5D5770")]
		public FsmString text;

		[Token(Token = "0x4004A32")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D57A8", Offset = "0x5D57A8")]
		public FsmString style;

		[Token(Token = "0x6005F42")]
		[Address(RVA = "0xD91E8C", Offset = "0xD91E8C", VA = "0xD91E8C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F43")]
		[Address(RVA = "0xD91EF8", Offset = "0xD91EF8", VA = "0xD91EF8", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F44")]
		[Address(RVA = "0xD9202C", Offset = "0xD9202C", VA = "0xD9202C")]
		public GUILayoutTextLabel()
		{
		}
	}
}
