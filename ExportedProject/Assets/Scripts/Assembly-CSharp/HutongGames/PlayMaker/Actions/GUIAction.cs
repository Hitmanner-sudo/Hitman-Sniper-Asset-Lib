using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F92")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DABC", Offset = "0x59DABC")]
	public abstract class GUIAction : FsmStateAction
	{
		[Token(Token = "0x4004994")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3234", Offset = "0x5D3234")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D3234", Offset = "0x5D3234")]
		public FsmRect screenRect;

		[Token(Token = "0x4004995")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3284", Offset = "0x5D3284")]
		public FsmFloat left;

		[Token(Token = "0x4004996")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D32BC", Offset = "0x5D32BC")]
		public FsmFloat top;

		[Token(Token = "0x4004997")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D32F4", Offset = "0x5D32F4")]
		public FsmFloat width;

		[Token(Token = "0x4004998")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D332C", Offset = "0x5D332C")]
		public FsmFloat height;

		[Token(Token = "0x4004999")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3364", Offset = "0x5D3364")]
		[RequiredField]
		public FsmBool normalized;

		[Token(Token = "0x400499A")]
		[FieldOffset(Offset = "0x80")]
		internal Rect rect;

		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0x95EF88", Offset = "0x95EF88", VA = "0x95EF88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EB2")]
		[Address(RVA = "0x95F004", Offset = "0x95F004", VA = "0x95F004", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x95F1F8", Offset = "0x95F1F8", VA = "0x95F1F8")]
		protected GUIAction()
		{
		}
	}
}
