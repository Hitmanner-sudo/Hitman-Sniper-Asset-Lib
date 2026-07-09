using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FAA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E2A8", Offset = "0x59E2A8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E2A8", Offset = "0x59E2A8")]
	public class GUILayoutBeginArea : FsmStateAction
	{
		[Token(Token = "0x40049D9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4264", Offset = "0x5D4264")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4264", Offset = "0x5D4264")]
		public FsmRect screenRect;

		[Token(Token = "0x40049DA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D42B4", Offset = "0x5D42B4")]
		public FsmFloat left;

		[Token(Token = "0x40049DB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D42EC", Offset = "0x5D42EC")]
		public FsmFloat top;

		[Token(Token = "0x40049DC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4324", Offset = "0x5D4324")]
		public FsmFloat width;

		[Token(Token = "0x40049DD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D435C", Offset = "0x5D435C")]
		public FsmFloat height;

		[Token(Token = "0x40049DE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4394", Offset = "0x5D4394")]
		public FsmBool normalized;

		[Token(Token = "0x40049DF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D43CC", Offset = "0x5D43CC")]
		public FsmString style;

		[Token(Token = "0x40049E0")]
		[FieldOffset(Offset = "0x88")]
		private Rect rect;

		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0xD8F2D4", Offset = "0xD8F2D4", VA = "0xD8F2D4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EF5")]
		[Address(RVA = "0xD8F388", Offset = "0xD8F388", VA = "0xD8F388", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0xD8F63C", Offset = "0xD8F63C", VA = "0xD8F63C")]
		public GUILayoutBeginArea()
		{
		}
	}
}
