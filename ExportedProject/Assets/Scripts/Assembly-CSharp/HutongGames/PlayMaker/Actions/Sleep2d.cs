using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3624", Offset = "0x5A3624")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3624", Offset = "0x5A3624")]
	public class Sleep2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EF8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E998C", Offset = "0x5E998C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E998C", Offset = "0x5E998C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6006398")]
		[Address(RVA = "0x846C7C", Offset = "0x846C7C", VA = "0x846C7C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006399")]
		[Address(RVA = "0x846C84", Offset = "0x846C84", VA = "0x846C84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600639A")]
		[Address(RVA = "0x846CAC", Offset = "0x846CAC", VA = "0x846CAC")]
		private void DoSleep()
		{
		}

		[Token(Token = "0x600639B")]
		[Address(RVA = "0x846D50", Offset = "0x846D50", VA = "0x846D50")]
		public Sleep2d()
		{
		}
	}
}
