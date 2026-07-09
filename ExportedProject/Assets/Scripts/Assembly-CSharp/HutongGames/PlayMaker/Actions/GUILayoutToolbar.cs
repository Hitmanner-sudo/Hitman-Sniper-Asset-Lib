using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EB68", Offset = "0x59EB68")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EB68", Offset = "0x59EB68")]
	public class GUILayoutToolbar : GUILayoutAction
	{
		[Token(Token = "0x4004A39")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5958", Offset = "0x5D5958")]
		public FsmInt numButtons;

		[Token(Token = "0x4004A3A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5990", Offset = "0x5D5990")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5990", Offset = "0x5D5990")]
		public FsmInt selectedButton;

		[Token(Token = "0x4004A3B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D59E0", Offset = "0x5D59E0")]
		public FsmEvent[] buttonEventsArray;

		[Token(Token = "0x4004A3C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5A18", Offset = "0x5D5A18")]
		public FsmTexture[] imagesArray;

		[Token(Token = "0x4004A3D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5A50", Offset = "0x5D5A50")]
		public FsmString[] textsArray;

		[Token(Token = "0x4004A3E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5A88", Offset = "0x5D5A88")]
		public FsmString[] tooltipsArray;

		[Token(Token = "0x4004A3F")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5AC0", Offset = "0x5D5AC0")]
		public FsmString style;

		[Token(Token = "0x4004A40")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5AF8", Offset = "0x5D5AF8")]
		public bool everyFrame;

		[Token(Token = "0x4004A41")]
		[FieldOffset(Offset = "0xA0")]
		private GUIContent[] contents;

		[Token(Token = "0x17000C38")]
		public GUIContent[] Contents
		{
			[Token(Token = "0x6005F48")]
			[Address(RVA = "0xD92308", Offset = "0xD92308", VA = "0xD92308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F49")]
		[Address(RVA = "0xD92338", Offset = "0xD92338", VA = "0xD92338")]
		private void SetButtonsContent()
		{
		}

		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0xD925A8", Offset = "0xD925A8", VA = "0xD925A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0xD92684", Offset = "0xD92684", VA = "0xD92684", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0xD926E4", Offset = "0xD926E4", VA = "0xD926E4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0xD9291C", Offset = "0xD9291C", VA = "0xD9291C", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0xD92A78", Offset = "0xD92A78", VA = "0xD92A78")]
		public GUILayoutToolbar()
		{
		}
	}
}
