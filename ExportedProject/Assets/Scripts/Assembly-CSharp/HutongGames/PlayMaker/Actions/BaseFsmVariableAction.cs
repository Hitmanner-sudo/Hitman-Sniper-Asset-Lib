using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001142")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6310", Offset = "0x5A6310")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6310", Offset = "0x5A6310")]
	public abstract class BaseFsmVariableAction : FsmStateAction
	{
		[Token(Token = "0x40051E5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5F542C", Offset = "0x5F542C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F542C", Offset = "0x5F542C")]
		public FsmEvent fsmNotFound;

		[Token(Token = "0x40051E6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F548C", Offset = "0x5F548C")]
		public FsmEvent variableNotFound;

		[Token(Token = "0x40051E7")]
		[FieldOffset(Offset = "0x60")]
		private GameObject cachedGameObject;

		[Token(Token = "0x40051E8")]
		[FieldOffset(Offset = "0x68")]
		private string cachedFsmName;

		[Token(Token = "0x40051E9")]
		[FieldOffset(Offset = "0x70")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x600662A")]
		[Address(RVA = "0xC0CE0C", Offset = "0xC0CE0C", VA = "0xC0CE0C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600662B")]
		[Address(RVA = "0xC0CE14", Offset = "0xC0CE14", VA = "0xC0CE14")]
		protected bool UpdateCache(GameObject go, string fsmName)
		{
			return default(bool);
		}

		[Token(Token = "0x600662C")]
		[Address(RVA = "0xC0CFB0", Offset = "0xC0CFB0", VA = "0xC0CFB0")]
		protected void DoVariableNotFound(string variableName)
		{
		}

		[Token(Token = "0x600662D")]
		[Address(RVA = "0xC0D034", Offset = "0xC0D034", VA = "0xC0D034")]
		protected BaseFsmVariableAction()
		{
		}
	}
}
