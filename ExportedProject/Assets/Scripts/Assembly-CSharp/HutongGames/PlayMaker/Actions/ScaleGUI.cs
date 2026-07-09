using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F9D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DE20", Offset = "0x59DE20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DE20", Offset = "0x59DE20")]
	public class ScaleGUI : FsmStateAction
	{
		[Token(Token = "0x40049BD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3BD4", Offset = "0x5D3BD4")]
		public FsmFloat scaleX;

		[Token(Token = "0x40049BE")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3C20", Offset = "0x5D3C20")]
		public FsmFloat scaleY;

		[Token(Token = "0x40049BF")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3C6C", Offset = "0x5D3C6C")]
		public FsmFloat pivotX;

		[Token(Token = "0x40049C0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3CB8", Offset = "0x5D3CB8")]
		[RequiredField]
		public FsmFloat pivotY;

		[Token(Token = "0x40049C1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3D04", Offset = "0x5D3D04")]
		public bool normalized;

		[Token(Token = "0x40049C2")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3D3C", Offset = "0x5D3D3C")]
		public bool applyGlobally;

		[Token(Token = "0x40049C3")]
		[FieldOffset(Offset = "0x72")]
		private bool applied;

		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0xBB1AC0", Offset = "0xBB1AC0", VA = "0xBB1AC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0xBB1B34", Offset = "0xBB1B34", VA = "0xBB1B34", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0xBB1DF8", Offset = "0xBB1DF8", VA = "0xBB1DF8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0xBB1E00", Offset = "0xBB1E00", VA = "0xBB1E00")]
		public ScaleGUI()
		{
		}
	}
}
