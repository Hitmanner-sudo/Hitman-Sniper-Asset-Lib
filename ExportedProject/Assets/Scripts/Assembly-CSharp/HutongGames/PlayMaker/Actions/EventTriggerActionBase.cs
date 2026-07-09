using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E5")]
	public abstract class EventTriggerActionBase : ComponentAction<EventTrigger>
	{
		[Token(Token = "0x400559D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600754", Offset = "0x600754")]
		[Attribute(Name = "DisplayOrderAttribute", RVA = "0x600754", Offset = "0x600754")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400559E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DisplayOrderAttribute", RVA = "0x6007B4", Offset = "0x6007B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6007B4", Offset = "0x6007B4")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x400559F")]
		[FieldOffset(Offset = "0x78")]
		protected EventTrigger trigger;

		[Token(Token = "0x40055A0")]
		[FieldOffset(Offset = "0x80")]
		protected EventTrigger.Entry entry;

		[Token(Token = "0x600693C")]
		[Address(RVA = "0xE1D1A4", Offset = "0xE1D1A4", VA = "0xE1D1A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600693D")]
		[Address(RVA = "0xE1D1AC", Offset = "0xE1D1AC", VA = "0xE1D1AC")]
		protected void Init(EventTriggerType eventTriggerType, UnityAction<BaseEventData> call)
		{
		}

		[Token(Token = "0x600693E")]
		[Address(RVA = "0xE1D2E0", Offset = "0xE1D2E0", VA = "0xE1D2E0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x600693F")]
		[Address(RVA = "0xE1D3C0", Offset = "0xE1D3C0", VA = "0xE1D3C0")]
		protected EventTriggerActionBase()
		{
		}
	}
}
