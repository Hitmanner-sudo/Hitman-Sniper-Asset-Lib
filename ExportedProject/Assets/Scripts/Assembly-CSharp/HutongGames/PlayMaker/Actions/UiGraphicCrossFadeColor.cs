using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001214")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAFB4", Offset = "0x5AAFB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAFB4", Offset = "0x5AAFB4")]
	public class UiGraphicCrossFadeColor : ComponentAction<Graphic>
	{
		[Token(Token = "0x4005682")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603F8C", Offset = "0x603F8C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603F8C", Offset = "0x603F8C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005683")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604020", Offset = "0x604020")]
		public FsmColor color;

		[Token(Token = "0x4005684")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604058", Offset = "0x604058")]
		public FsmFloat red;

		[Token(Token = "0x4005685")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604090", Offset = "0x604090")]
		public FsmFloat green;

		[Token(Token = "0x4005686")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6040C8", Offset = "0x6040C8")]
		public FsmFloat blue;

		[Token(Token = "0x4005687")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604100", Offset = "0x604100")]
		public FsmFloat alpha;

		[Token(Token = "0x4005688")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604138", Offset = "0x604138")]
		public FsmFloat duration;

		[Token(Token = "0x4005689")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604170", Offset = "0x604170")]
		public FsmBool ignoreTimeScale;

		[Token(Token = "0x400568A")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6041A8", Offset = "0x6041A8")]
		public FsmBool useAlpha;

		[Token(Token = "0x400568B")]
		[FieldOffset(Offset = "0xB0")]
		private Graphic uiComponent;

		[Token(Token = "0x6006A03")]
		[Address(RVA = "0xB8D7FC", Offset = "0xB8D7FC", VA = "0xB8D7FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A04")]
		[Address(RVA = "0xB8D8EC", Offset = "0xB8D8EC", VA = "0xB8D8EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A05")]
		[Address(RVA = "0xB8DAF4", Offset = "0xB8DAF4", VA = "0xB8DAF4")]
		public UiGraphicCrossFadeColor()
		{
		}
	}
}
