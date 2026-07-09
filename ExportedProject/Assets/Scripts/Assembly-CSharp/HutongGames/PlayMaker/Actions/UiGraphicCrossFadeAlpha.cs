using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001213")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAF64", Offset = "0x5AAF64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAF64", Offset = "0x5AAF64")]
	public class UiGraphicCrossFadeAlpha : ComponentAction<Graphic>
	{
		[Token(Token = "0x400567D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603E50", Offset = "0x603E50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603E50", Offset = "0x603E50")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400567E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603EE4", Offset = "0x603EE4")]
		public FsmFloat alpha;

		[Token(Token = "0x400567F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603F1C", Offset = "0x603F1C")]
		public FsmFloat duration;

		[Token(Token = "0x4005680")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603F54", Offset = "0x603F54")]
		public FsmBool ignoreTimeScale;

		[Token(Token = "0x4005681")]
		[FieldOffset(Offset = "0x88")]
		private Graphic uiComponent;

		[Token(Token = "0x6006A00")]
		[Address(RVA = "0xB8D694", Offset = "0xB8D694", VA = "0xB8D694", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A01")]
		[Address(RVA = "0xB8D6C4", Offset = "0xB8D6C4", VA = "0xB8D6C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A02")]
		[Address(RVA = "0xB8D7B0", Offset = "0xB8D7B0", VA = "0xB8D7B0")]
		public UiGraphicCrossFadeAlpha()
		{
		}
	}
}
