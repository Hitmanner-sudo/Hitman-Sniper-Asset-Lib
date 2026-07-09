using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001107")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A534C", Offset = "0x5A534C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A534C", Offset = "0x5A534C")]
	public class AllowSceneActivation : FsmStateAction
	{
		[Token(Token = "0x4005093")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F048C", Offset = "0x5F048C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F048C", Offset = "0x5F048C")]
		public FsmInt aSynchOperationHashCode;

		[Token(Token = "0x4005094")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F04EC", Offset = "0x5F04EC")]
		public FsmBool allowSceneActivation;

		[Token(Token = "0x4005095")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ActionSection", RVA = "0x5F0524", Offset = "0x5F0524")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0524", Offset = "0x5F0524")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0524", Offset = "0x5F0524")]
		public FsmFloat progress;

		[Token(Token = "0x4005096")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0598", Offset = "0x5F0598")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0598", Offset = "0x5F0598")]
		public FsmBool isDone;

		[Token(Token = "0x4005097")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F05E8", Offset = "0x5F05E8")]
		public FsmEvent doneEvent;

		[Token(Token = "0x4005098")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0620", Offset = "0x5F0620")]
		public FsmEvent failureEvent;

		[Token(Token = "0x600653E")]
		[Address(RVA = "0xD5F95C", Offset = "0xD5F95C", VA = "0xD5F95C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600653F")]
		[Address(RVA = "0xD5F994", Offset = "0xD5F994", VA = "0xD5F994", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006540")]
		[Address(RVA = "0xD5FB48", Offset = "0xD5FB48", VA = "0xD5FB48", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006541")]
		[Address(RVA = "0xD5F998", Offset = "0xD5F998", VA = "0xD5F998")]
		private void DoAllowSceneActivation()
		{
		}

		[Token(Token = "0x6006542")]
		[Address(RVA = "0xD5FDA8", Offset = "0xD5FDA8", VA = "0xD5FDA8")]
		public AllowSceneActivation()
		{
		}
	}
}
