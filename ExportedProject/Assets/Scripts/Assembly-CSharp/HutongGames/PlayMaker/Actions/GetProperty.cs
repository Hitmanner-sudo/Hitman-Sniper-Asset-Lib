using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001252")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC314", Offset = "0x5AC314")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC314", Offset = "0x5AC314")]
	public class GetProperty : FsmStateAction
	{
		[Token(Token = "0x40057C7")]
		[FieldOffset(Offset = "0x50")]
		public FsmProperty targetProperty;

		[Token(Token = "0x40057C8")]
		[FieldOffset(Offset = "0x58")]
		public bool everyFrame;

		[Token(Token = "0x40057C9")]
		[FieldOffset(Offset = "0x60")]
		public string dataModelPath;

		[Token(Token = "0x6006B3E")]
		[Address(RVA = "0x10674B4", Offset = "0x10674B4", VA = "0x10674B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0x1067520", Offset = "0x1067520", VA = "0x1067520", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B40")]
		[Address(RVA = "0x10676C0", Offset = "0x10676C0", VA = "0x10676C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B41")]
		[Address(RVA = "0x106755C", Offset = "0x106755C", VA = "0x106755C")]
		private void GetValue()
		{
		}

		[Token(Token = "0x6006B42")]
		[Address(RVA = "0x10676C4", Offset = "0x10676C4", VA = "0x10676C4")]
		public GetProperty()
		{
		}
	}
}
