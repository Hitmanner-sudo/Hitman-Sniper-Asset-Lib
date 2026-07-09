using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F75")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D218", Offset = "0x59D218")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D218", Offset = "0x59D218")]
	public class DrawDebugRay : FsmStateAction
	{
		[Token(Token = "0x40048EB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0C50", Offset = "0x5D0C50")]
		public FsmGameObject fromObject;

		[Token(Token = "0x40048EC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0C88", Offset = "0x5D0C88")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x40048ED")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0CC0", Offset = "0x5D0CC0")]
		public FsmVector3 direction;

		[Token(Token = "0x40048EE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0CF8", Offset = "0x5D0CF8")]
		public FsmColor color;

		[Token(Token = "0x6005E41")]
		[Address(RVA = "0xC1F80C", Offset = "0xC1F80C", VA = "0xC1F80C", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005E42")]
		[Address(RVA = "0xC1F814", Offset = "0xC1F814", VA = "0xC1F814", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xC1F8F4", Offset = "0xC1F8F4", VA = "0xC1F8F4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E44")]
		[Address(RVA = "0xC1F9BC", Offset = "0xC1F9BC", VA = "0xC1F9BC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005E45")]
		[Address(RVA = "0xC1FAE4", Offset = "0xC1FAE4", VA = "0xC1FAE4")]
		public DrawDebugRay()
		{
		}
	}
}
