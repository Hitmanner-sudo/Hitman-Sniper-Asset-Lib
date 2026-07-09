using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000059")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200005A")]
		public enum AxisOption
		{
			[Token(Token = "0x40001AE")]
			Both = 0,
			[Token(Token = "0x40001AF")]
			OnlyHorizontal = 1,
			[Token(Token = "0x40001B0")]
			OnlyVertical = 2
		}

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10EFA04", Offset = "0x10EFA04", VA = "0x10EFA04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x10EFB3C", Offset = "0x10EFB3C", VA = "0x10EFB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10EFB78", Offset = "0x10EFB78", VA = "0x10EFB78")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x10EFA08", Offset = "0x10EFA08", VA = "0x10EFA08")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x10EFBDC", Offset = "0x10EFBDC", VA = "0x10EFBDC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x10EFD00", Offset = "0x10EFD00", VA = "0x10EFD00", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x10EFD48", Offset = "0x10EFD48", VA = "0x10EFD48", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x10EFD4C", Offset = "0x10EFD4C", VA = "0x10EFD4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x10EFDA4", Offset = "0x10EFDA4", VA = "0x10EFDA4")]
		public Joystick()
		{
		}
	}
}
