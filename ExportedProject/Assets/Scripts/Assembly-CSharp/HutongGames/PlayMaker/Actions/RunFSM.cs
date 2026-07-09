using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A78DC", Offset = "0x5A78DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A78DC", Offset = "0x5A78DC")]
	public class RunFSM : RunFSMAction
	{
		[Token(Token = "0x40052CA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F803C", Offset = "0x5F803C")]
		public FsmTemplateControl fsmTemplateControl;

		[Token(Token = "0x40052CB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8074", Offset = "0x5F8074")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40052CC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ActionSection", RVA = "0x5F80AC", Offset = "0x5F80AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F80AC", Offset = "0x5F80AC")]
		public bool everyFrame;

		[Token(Token = "0x40052CD")]
		[FieldOffset(Offset = "0x69")]
		private bool restart;

		[Token(Token = "0x60066DC")]
		[Address(RVA = "0xBA54D8", Offset = "0xBA54D8", VA = "0xBA54D8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066DD")]
		[Address(RVA = "0xBA553C", Offset = "0xBA553C", VA = "0xBA553C", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60066DE")]
		[Address(RVA = "0xBA560C", Offset = "0xBA560C", VA = "0xBA560C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066DF")]
		[Address(RVA = "0xBA5774", Offset = "0xBA5774", VA = "0xBA5774", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60066E0")]
		[Address(RVA = "0xBA5844", Offset = "0xBA5844", VA = "0xBA5844")]
		private void OnOutputEvent(FsmEvent fsmEvent)
		{
		}

		[Token(Token = "0x60066E1")]
		[Address(RVA = "0xBA58B0", Offset = "0xBA58B0", VA = "0xBA58B0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066E2")]
		[Address(RVA = "0xBA5944", Offset = "0xBA5944", VA = "0xBA5944", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60066E3")]
		[Address(RVA = "0xBA59AC", Offset = "0xBA59AC", VA = "0xBA59AC", Slot = "62")]
		protected override void CheckIfFinished()
		{
		}

		[Token(Token = "0x60066E4")]
		[Address(RVA = "0xBA5A28", Offset = "0xBA5A28", VA = "0xBA5A28")]
		public RunFSM()
		{
		}
	}
}
