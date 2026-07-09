using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E270", Offset = "0x59E270")]
	public abstract class GUILayoutAction : FsmStateAction
	{
		[Token(Token = "0x40049D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D422C", Offset = "0x5D422C")]
		public LayoutOption[] layoutOptions;

		[Token(Token = "0x40049D8")]
		[FieldOffset(Offset = "0x58")]
		private GUILayoutOption[] options;

		[Token(Token = "0x17000C37")]
		public GUILayoutOption[] LayoutOptions
		{
			[Token(Token = "0x6005EF1")]
			[Address(RVA = "0xD8F170", Offset = "0xD8F170", VA = "0xD8F170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0xD8F278", Offset = "0xD8F278", VA = "0xD8F278", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0xD8F2CC", Offset = "0xD8F2CC", VA = "0xD8F2CC")]
		protected GUILayoutAction()
		{
		}
	}
}
