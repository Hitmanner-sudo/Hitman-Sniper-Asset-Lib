using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000083")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x591AD8", Offset = "0x591AD8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591AD8", Offset = "0x591AD8")]
[ExecuteInEditMode]
public class UICamera : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	public enum ClickNotification
	{
		[Token(Token = "0x40002FD")]
		None = 0,
		[Token(Token = "0x40002FE")]
		Always = 1,
		[Token(Token = "0x40002FF")]
		BasedOnDelta = 2
	}

	[Token(Token = "0x2000085")]
	public class MouseOrTouch
	{
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 delta;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 totalDelta;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x28")]
		public Camera pressedCam;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x30")]
		public GameObject current;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x38")]
		public GameObject pressed;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x40")]
		public GameObject dragged;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x48")]
		public float clickTime;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x4C")]
		public ClickNotification clickNotification;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x50")]
		public bool touchBegan;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x51")]
		public bool pressStarted;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x52")]
		public bool dragStarted;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA3AB9C", Offset = "0xA3AB9C", VA = "0xA3AB9C")]
		public MouseOrTouch()
		{
		}
	}

	[Token(Token = "0x2000086")]
	public enum EventType
	{
		[Token(Token = "0x400030D")]
		World = 0,
		[Token(Token = "0x400030E")]
		UI = 1
	}

	[Token(Token = "0x2000087")]
	private class Highlighted
	{
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		public int counter;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA3AB94", Offset = "0xA3AB94", VA = "0xA3AB94")]
		public Highlighted()
		{
		}
	}

	[Token(Token = "0x2000088")]
	public delegate void OnCustomInput();

	[Token(Token = "0x2000089")]
	private struct DepthEntry
	{
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x0")]
		public int depth;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x4")]
		public RaycastHit hit;
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591B6C", Offset = "0x591B6C")]
	private sealed class _003CChangeSelection_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x20")]
		public GameObject go;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x28")]
		public UICamera _003C_003E4__this;

		[Token(Token = "0x170000AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xA3AB44", Offset = "0xA3AB44", VA = "0xA3AB44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xA3AB8C", Offset = "0xA3AB8C", VA = "0xA3AB8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA3A8E4", Offset = "0xA3A8E4", VA = "0xA3A8E4")]
		[DebuggerHidden]
		public _003CChangeSelection_003Ed__58(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA3A910", Offset = "0xA3A910", VA = "0xA3A910", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA3A914", Offset = "0xA3A914", VA = "0xA3A914", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA3AB4C", Offset = "0xA3AB4C", VA = "0xA3AB4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591B7C", Offset = "0x591B7C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<DepthEntry> _003C_003E9__73_0;

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA3A8CC", Offset = "0xA3A8CC", VA = "0xA3A8CC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA3A8D4", Offset = "0xA3A8D4", VA = "0xA3A8D4")]
		internal int _003CRaycast_003Eb__73_0(DepthEntry r1, DepthEntry r2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x0")]
	public static List<UICamera> list;

	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x18")]
	public EventType eventType;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask eventReceiverMask;

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x20")]
	public bool debug;

	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x21")]
	public bool useMouse;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x22")]
	public bool useTouch;

	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x23")]
	public bool allowMultiTouch;

	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x24")]
	public bool useKeyboard;

	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x25")]
	public bool useController;

	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x26")]
	public bool stickyPress;

	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x27")]
	public bool stickyTooltip;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x28")]
	public float tooltipDelay;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x2C")]
	public float mouseDragThreshold;

	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x30")]
	public float mouseClickThreshold;

	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x34")]
	public float touchDragThreshold;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x38")]
	public float touchClickThreshold;

	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x3C")]
	public float rangeDistance;

	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x40")]
	public string scrollAxisName;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x48")]
	public string verticalAxisName;

	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x50")]
	public string horizontalAxisName;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x58")]
	public KeyCode submitKey0;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x5C")]
	public KeyCode submitKey1;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x60")]
	public KeyCode cancelKey0;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x64")]
	public KeyCode cancelKey1;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x8")]
	public static OnCustomInput onCustomInput;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x10")]
	public static bool showTooltips;

	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x14")]
	public static Vector2 lastTouchPosition;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x1C")]
	public static RaycastHit lastHit;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x48")]
	public static UICamera current;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x50")]
	public static Camera currentCamera;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x58")]
	public static int currentTouchID;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x60")]
	public static MouseOrTouch currentTouch;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x68")]
	public static bool inputHasFocus;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x70")]
	public static GameObject genericEventHandler;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x78")]
	public static GameObject fallThrough;

	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x80")]
	private static List<Highlighted> mHighlighted;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x88")]
	private static GameObject mCurrentSelection;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x90")]
	private static GameObject mNextSelection;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x98")]
	private static MouseOrTouch[] mMouse;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0xA0")]
	private static MouseOrTouch mController;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0xA8")]
	private static float mNextEvent;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0xB0")]
	private static Dictionary<int, MouseOrTouch> mTouches;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x68")]
	private GameObject mTooltip;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x70")]
	private Camera mCam;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0xB8")]
	public static bool isDragging;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0xC0")]
	public static GameObject hoveredObject;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0xC8")]
	private static DepthEntry mHit;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0xF8")]
	private static BetterList<DepthEntry> mHits;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x100")]
	private static RaycastHit mEmpty;

	[Token(Token = "0x170000A6")]
	private bool handlesEvents
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x157D674", Offset = "0x157D674", VA = "0x157D674")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A7")]
	public Camera cachedCamera
	{
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x157D8B0", Offset = "0x157D8B0", VA = "0x157D8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	public static GameObject selectedObject
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x157D994", Offset = "0x157D994", VA = "0x157D994")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x157BA8C", Offset = "0x157BA8C", VA = "0x157BA8C")]
		set
		{
		}
	}

	[Token(Token = "0x170000A9")]
	public static int touchCount
	{
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x157DF74", Offset = "0x157DF74", VA = "0x157DF74")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AA")]
	public static int dragCount
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x157E248", Offset = "0x157E248", VA = "0x157E248")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AB")]
	public static Camera mainCamera
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x157E5A0", Offset = "0x157E5A0", VA = "0x157E5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AC")]
	public static UICamera eventHandler
	{
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x157D714", Offset = "0x157D714", VA = "0x157D714")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x157DEFC", Offset = "0x157DEFC", VA = "0x157DEFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611B80", Offset = "0x611B80")]
	private IEnumerator ChangeSelection(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x157E51C", Offset = "0x157E51C", VA = "0x157E51C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x157E660", Offset = "0x157E660", VA = "0x157E660")]
	private int CompareFunc(UICamera a, UICamera b)
	{
		return default(int);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x157E7F0", Offset = "0x157E7F0", VA = "0x157E7F0")]
	public static bool Raycast(Vector3 inPos, out RaycastHit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x157F1DC", Offset = "0x157F1DC", VA = "0x157F1DC")]
	private static bool IsVisible(ref RaycastHit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x157F0C8", Offset = "0x157F0C8", VA = "0x157F0C8")]
	private static bool IsVisible(ref DepthEntry de)
	{
		return default(bool);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x157D9F8", Offset = "0x157D9F8", VA = "0x157D9F8")]
	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x157F2EC", Offset = "0x157F2EC", VA = "0x157F2EC")]
	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return default(int);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x157F32C", Offset = "0x157F32C", VA = "0x157F32C")]
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return default(int);
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x157F3A4", Offset = "0x157F3A4", VA = "0x157F3A4")]
	private static int GetDirection(string axis)
	{
		return default(int);
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x157B47C", Offset = "0x157B47C", VA = "0x157B47C")]
	public static bool IsHighlighted(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x157DB94", Offset = "0x157DB94", VA = "0x157DB94")]
	private static void Highlight(GameObject go, bool highlighted)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x157BE70", Offset = "0x157BE70", VA = "0x157BE70")]
	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x157F4B4", Offset = "0x157F4B4", VA = "0x157F4B4")]
	public static MouseOrTouch GetTouch(int id)
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x157F5E0", Offset = "0x157F5E0", VA = "0x157F5E0")]
	public static void RemoveTouch(int id)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x157F66C", Offset = "0x157F66C", VA = "0x157F66C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x157F8B4", Offset = "0x157F8B4", VA = "0x157F8B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x157F9D4", Offset = "0x157F9D4", VA = "0x157F9D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x157FAA8", Offset = "0x157FAA8", VA = "0x157FAA8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x157FC90", Offset = "0x157FC90", VA = "0x157FC90")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x158002C", Offset = "0x158002C", VA = "0x158002C")]
	public void ProcessTouches()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x1580628", Offset = "0x1580628", VA = "0x1580628")]
	public void ProcessOthers()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1580C40", Offset = "0x1580C40", VA = "0x1580C40")]
	public void ProcessTouch(bool pressed, bool unpressed)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x1580558", Offset = "0x1580558", VA = "0x1580558")]
	public void ShowTooltip(bool val)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x15818BC", Offset = "0x15818BC", VA = "0x15818BC")]
	public UICamera()
	{
	}
}
