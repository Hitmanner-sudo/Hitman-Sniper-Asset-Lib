using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001143")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A639C", Offset = "0x5A639C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A639C", Offset = "0x5A639C")]
	public abstract class BaseFsmVariableIndexAction : FsmStateAction
	{
		[Token(Token = "0x40051EA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5F54C4", Offset = "0x5F54C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F54C4", Offset = "0x5F54C4")]
		public FsmEvent indexOutOfRange;

		[Token(Token = "0x40051EB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5524", Offset = "0x5F5524")]
		public FsmEvent fsmNotFound;

		[Token(Token = "0x40051EC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F555C", Offset = "0x5F555C")]
		public FsmEvent variableNotFound;

		[Token(Token = "0x40051ED")]
		[FieldOffset(Offset = "0x68")]
		private GameObject cachedGameObject;

		[Token(Token = "0x40051EE")]
		[FieldOffset(Offset = "0x70")]
		private string cachedFsmName;

		[Token(Token = "0x40051EF")]
		[FieldOffset(Offset = "0x78")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x600662E")]
		[Address(RVA = "0xC0D03C", Offset = "0xC0D03C", VA = "0xC0D03C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600662F")]
		[Address(RVA = "0xC0D044", Offset = "0xC0D044", VA = "0xC0D044")]
		protected bool UpdateCache(GameObject go, string fsmName)
		{
			return default(bool);
		}

		[Token(Token = "0x6006630")]
		[Address(RVA = "0xC0D1E0", Offset = "0xC0D1E0", VA = "0xC0D1E0")]
		protected void DoVariableNotFound(string variableName)
		{
		}

		[Token(Token = "0x6006631")]
		[Address(RVA = "0xC0D264", Offset = "0xC0D264", VA = "0xC0D264")]
		protected BaseFsmVariableIndexAction()
		{
		}
	}
}
