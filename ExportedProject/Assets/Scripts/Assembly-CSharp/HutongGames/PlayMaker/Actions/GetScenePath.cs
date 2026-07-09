using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001112")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A56BC", Offset = "0x5A56BC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A56BC", Offset = "0x5A56BC")]
	public class GetScenePath : GetSceneActionBase
	{
		[Token(Token = "0x40050C5")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5F14BC", Offset = "0x5F14BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F14BC", Offset = "0x5F14BC")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F14BC", Offset = "0x5F14BC")]
		public FsmString path;

		[Token(Token = "0x600656E")]
		[Address(RVA = "0xC7DFBC", Offset = "0xC7DFBC", VA = "0xC7DFBC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600656F")]
		[Address(RVA = "0xC7DFE4", Offset = "0xC7DFE4", VA = "0xC7DFE4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006570")]
		[Address(RVA = "0xC7E018", Offset = "0xC7E018", VA = "0xC7E018")]
		private void DoGetScenePath()
		{
		}

		[Token(Token = "0x6006571")]
		[Address(RVA = "0xC7E088", Offset = "0xC7E088", VA = "0xC7E088")]
		public GetScenePath()
		{
		}
	}
}
