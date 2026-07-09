using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F95")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DB94", Offset = "0x59DB94")]
	public abstract class GUIContentAction : GUIAction
	{
		[Token(Token = "0x400499D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3438", Offset = "0x5D3438")]
		public FsmTexture image;

		[Token(Token = "0x400499E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3470", Offset = "0x5D3470")]
		public FsmString text;

		[Token(Token = "0x400499F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D34A8", Offset = "0x5D34A8")]
		public FsmString tooltip;

		[Token(Token = "0x40049A0")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D34E0", Offset = "0x5D34E0")]
		public FsmString style;

		[Token(Token = "0x40049A1")]
		[FieldOffset(Offset = "0xB0")]
		internal GUIContent content;

		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0xD8E47C", Offset = "0xD8E47C", VA = "0xD8E47C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0xD8E33C", Offset = "0xD8E33C", VA = "0xD8E33C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0xD8E414", Offset = "0xD8E414", VA = "0xD8E414")]
		protected GUIContentAction()
		{
		}
	}
}
