using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011DF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA004", Offset = "0x5AA004")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA004", Offset = "0x5AA004")]
	public class UiCanvasEnableRaycast : ComponentAction<PlayMakerCanvasRaycastFilterProxy>
	{
		[Token(Token = "0x400557D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6000BC", Offset = "0x6000BC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400557E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600108", Offset = "0x600108")]
		public FsmBool enableRaycasting;

		[Token(Token = "0x400557F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600140", Offset = "0x600140")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005580")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600178", Offset = "0x600178")]
		public bool everyFrame;

		[Token(Token = "0x4005581")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PlayMakerCanvasRaycastFilterProxy raycastFilterProxy;

		[Token(Token = "0x4005582")]
		[FieldOffset(Offset = "0x90")]
		private bool originalValue;

		[Token(Token = "0x600691D")]
		[Address(RVA = "0x1177758", Offset = "0x1177758", VA = "0x1177758", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600691E")]
		[Address(RVA = "0x117778C", Offset = "0x117778C", VA = "0x117778C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600691F")]
		[Address(RVA = "0x1177838", Offset = "0x1177838", VA = "0x1177838", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006920")]
		[Address(RVA = "0x1177978", Offset = "0x1177978", VA = "0x1177978", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006921")]
		[Address(RVA = "0x11778E0", Offset = "0x11778E0", VA = "0x11778E0")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006922")]
		[Address(RVA = "0x117797C", Offset = "0x117797C", VA = "0x117797C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006923")]
		[Address(RVA = "0x1177A18", Offset = "0x1177A18", VA = "0x1177A18")]
		public UiCanvasEnableRaycast()
		{
		}
	}
}
