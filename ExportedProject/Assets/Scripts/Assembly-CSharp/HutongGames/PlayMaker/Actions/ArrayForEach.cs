using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F14")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B480", Offset = "0x59B480")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B480", Offset = "0x59B480")]
	public class ArrayForEach : RunFSMAction
	{
		[Token(Token = "0x4004739")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9F90", Offset = "0x5C9F90")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9F90", Offset = "0x5C9F90")]
		public FsmArray array;

		[Token(Token = "0x400473A")]
		[FieldOffset(Offset = "0x60")]
		[HideTypeFilter]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9FF0", Offset = "0x5C9FF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9FF0", Offset = "0x5C9FF0")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5C9FF0", Offset = "0x5C9FF0")]
		public FsmVar storeItem;

		[Token(Token = "0x400473B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA074", Offset = "0x5CA074")]
		[Attribute(Name = "ActionSection", RVA = "0x5CA074", Offset = "0x5CA074")]
		public FsmTemplateControl fsmTemplateControl;

		[Token(Token = "0x400473C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA0D4", Offset = "0x5CA0D4")]
		public FsmEvent finishEvent;

		[Token(Token = "0x400473D")]
		[FieldOffset(Offset = "0x78")]
		private int currentIndex;

		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0xBFCA40", Offset = "0xBFCA40", VA = "0xBFCA40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0xBFCAA8", Offset = "0xBFCAA8", VA = "0xBFCAA8", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0xBFCB60", Offset = "0xBFCB60", VA = "0xBFCB60", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0xBFCC14", Offset = "0xBFCC14", VA = "0xBFCC14", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0xBFCC80", Offset = "0xBFCC80", VA = "0xBFCC80", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0xBFCCDC", Offset = "0xBFCCDC", VA = "0xBFCCDC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0xBFCC70", Offset = "0xBFCC70", VA = "0xBFCC70")]
		private void StartNextFsm()
		{
		}

		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0xBFCB80", Offset = "0xBFCB80", VA = "0xBFCB80")]
		private void StartFsm()
		{
		}

		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0xBFCD38", Offset = "0xBFCD38", VA = "0xBFCD38")]
		private void DoStartFsm()
		{
		}

		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0xBFCDF8", Offset = "0xBFCDF8", VA = "0xBFCDF8", Slot = "62")]
		protected override void CheckIfFinished()
		{
		}

		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0xBFCDFC", Offset = "0xBFCDFC", VA = "0xBFCDFC")]
		public ArrayForEach()
		{
		}
	}
}
