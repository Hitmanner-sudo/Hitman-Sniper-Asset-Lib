using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000791")]
public class PointyTooltip : UIController
{
	[Token(Token = "0x2000792")]
	public enum TooltipArrowLocation
	{
		[Token(Token = "0x4002AAE")]
		BottomLeft = 0,
		[Token(Token = "0x4002AAF")]
		BottomRight = 1,
		[Token(Token = "0x4002AB0")]
		TopLeft = 2,
		[Token(Token = "0x4002AB1")]
		TopRight = 3
	}

	[Token(Token = "0x2000793")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5960D8", Offset = "0x5960D8")]
	private sealed class _003CDelayForwardEvent_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x20")]
		public PointyTooltip _003C_003E4__this;

		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x1700066A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003239")]
			[Address(RVA = "0x8AC6F0", Offset = "0x8AC6F0", VA = "0x8AC6F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600323B")]
			[Address(RVA = "0x8AC738", Offset = "0x8AC738", VA = "0x8AC738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003236")]
		[Address(RVA = "0x8AC4F0", Offset = "0x8AC4F0", VA = "0x8AC4F0")]
		[DebuggerHidden]
		public _003CDelayForwardEvent_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003237")]
		[Address(RVA = "0x8AC51C", Offset = "0x8AC51C", VA = "0x8AC51C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003238")]
		[Address(RVA = "0x8AC520", Offset = "0x8AC520", VA = "0x8AC520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600323A")]
		[Address(RVA = "0x8AC6F8", Offset = "0x8AC6F8", VA = "0x8AC6F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002A96")]
	[FieldOffset(Offset = "0x58")]
	public UISprite Background;

	[Token(Token = "0x4002A97")]
	[FieldOffset(Offset = "0x60")]
	public UISprite BackgroundHighlight;

	[Token(Token = "0x4002A98")]
	[FieldOffset(Offset = "0x68")]
	public UILabel Text;

	[Token(Token = "0x4002A99")]
	[FieldOffset(Offset = "0x70")]
	public TooltipArrowLocation ArrowLocation;

	[Token(Token = "0x4002A9A")]
	[FieldOffset(Offset = "0x74")]
	public bool SkipFadeOut;

	[Token(Token = "0x4002A9B")]
	[FieldOffset(Offset = "0x75")]
	public bool OnlyShowOnce;

	[Token(Token = "0x4002A9C")]
	[FieldOffset(Offset = "0x76")]
	public bool DestroyOnClick;

	[Token(Token = "0x4002A9D")]
	[FieldOffset(Offset = "0x77")]
	public bool CloseOnAnyInputs;

	[Token(Token = "0x4002A9E")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BAA88", Offset = "0x5BAA88")]
	public int ShapeRatio;

	[Token(Token = "0x4002A9F")]
	[FieldOffset(Offset = "0x7C")]
	public bool ForwardEventsToInputManager;

	[Token(Token = "0x4002AA0")]
	[FieldOffset(Offset = "0x80")]
	private ButtonHandler _buttonToDissapearOn;

	[Token(Token = "0x4002AA1")]
	[FieldOffset(Offset = "0x88")]
	private bool _canBeShown;

	[Token(Token = "0x4002AA2")]
	[FieldOffset(Offset = "0x90")]
	private List<TweenAlpha> _tweeners;

	[Token(Token = "0x4002AA3")]
	[FieldOffset(Offset = "0x98")]
	private ButtonHandler _buttonHandler;

	[Token(Token = "0x4002AA4")]
	[FieldOffset(Offset = "0xA0")]
	private BoxCollider _boxCollider;

	[Token(Token = "0x4002AA5")]
	[FieldOffset(Offset = "0xA8")]
	private List<TextLabel> _textLabels;

	[Token(Token = "0x4002AA6")]
	private const int TEXT_BORDER_X = 25;

	[Token(Token = "0x4002AA7")]
	private const int TEXT_BORDER_Y_TOP = 30;

	[Token(Token = "0x4002AA8")]
	private const int TEXT_BORDER_Y_BOT = 20;

	[Token(Token = "0x4002AA9")]
	private const float FADE_DURATION = 0.3f;

	[Token(Token = "0x4002AAA")]
	[FieldOffset(Offset = "0xB0")]
	private float _lastTouchTime;

	[Token(Token = "0x4002AAB")]
	[FieldOffset(Offset = "0xB4")]
	private int _touchID;

	[Token(Token = "0x4002AAC")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine _delayForwardEventCoroutine;

	[Token(Token = "0x17000669")]
	public ButtonHandler ButtonToDisappearOn
	{
		[Token(Token = "0x600321C")]
		[Address(RVA = "0xABFDE8", Offset = "0xABFDE8", VA = "0xABFDE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600321D")]
		[Address(RVA = "0xABFDF0", Offset = "0xABFDF0", VA = "0xABFDF0")]
		set
		{
		}
	}

	[Token(Token = "0x140000A9")]
	public event EventHandler OnClick
	{
		[Token(Token = "0x600321A")]
		[Address(RVA = "0xABFCA8", Offset = "0xABFCA8", VA = "0xABFCA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622440", Offset = "0x622440")]
		add
		{
		}
		[Token(Token = "0x600321B")]
		[Address(RVA = "0xABFD48", Offset = "0xABFD48", VA = "0xABFD48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622450", Offset = "0x622450")]
		remove
		{
		}
	}

	[Token(Token = "0x600321E")]
	[Address(RVA = "0xABFF78", Offset = "0xABFF78", VA = "0xABFF78", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600321F")]
	[Address(RVA = "0xAC0224", Offset = "0xAC0224", VA = "0xAC0224", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003220")]
	[Address(RVA = "0xAC0AB4", Offset = "0xAC0AB4", VA = "0xAC0AB4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003221")]
	[Address(RVA = "0xAC0DBC", Offset = "0xAC0DBC", VA = "0xAC0DBC")]
	public void SetVisibility(bool isVisible)
	{
	}

	[Token(Token = "0x6003222")]
	[Address(RVA = "0xAC0F5C", Offset = "0xAC0F5C", VA = "0xAC0F5C")]
	public void SetVisibilityOrFade(bool show)
	{
	}

	[Token(Token = "0x6003223")]
	[Address(RVA = "0xAC1200", Offset = "0xAC1200", VA = "0xAC1200")]
	public void SetTextData(string text)
	{
	}

	[Token(Token = "0x6003224")]
	[Address(RVA = "0xAC12E4", Offset = "0xAC12E4", VA = "0xAC12E4")]
	public void SetTextData(List<TooltipTextData> texts)
	{
	}

	[Token(Token = "0x6003225")]
	[Address(RVA = "0xAC0100", Offset = "0xAC0100", VA = "0xAC0100")]
	private BoxCollider GetBoxCollider()
	{
		return null;
	}

	[Token(Token = "0x6003226")]
	[Address(RVA = "0xAC1584", Offset = "0xAC1584", VA = "0xAC1584")]
	private void SetAllLabelsTextAndSize(List<TooltipTextData> textDatas, ref int textMaxWidth)
	{
	}

	[Token(Token = "0x6003227")]
	[Address(RVA = "0xAC1F4C", Offset = "0xAC1F4C", VA = "0xAC1F4C")]
	public static Vector2 GetPrintedSize(string text, UILabel uiLabel)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003228")]
	[Address(RVA = "0xAC1E10", Offset = "0xAC1E10", VA = "0xAC1E10")]
	private void SetBackgroundSize(int textWidth, int textHeight)
	{
	}

	[Token(Token = "0x6003229")]
	[Address(RVA = "0xAC0704", Offset = "0xAC0704", VA = "0xAC0704")]
	public void UpdateTextPosition()
	{
	}

	[Token(Token = "0x600322A")]
	[Address(RVA = "0xAC05E4", Offset = "0xAC05E4", VA = "0xAC05E4")]
	private void BindSelf()
	{
	}

	[Token(Token = "0x600322B")]
	[Address(RVA = "0xAC0CA0", Offset = "0xAC0CA0", VA = "0xAC0CA0")]
	private void UnbindSelf()
	{
	}

	[Token(Token = "0x600322C")]
	[Address(RVA = "0xAC1FE8", Offset = "0xAC1FE8", VA = "0xAC1FE8")]
	private void OnButtonPress(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600322D")]
	[Address(RVA = "0xAC2008", Offset = "0xAC2008", VA = "0xAC2008")]
	private void StartPress()
	{
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0xAC2118", Offset = "0xAC2118", VA = "0xAC2118")]
	private void EndPress()
	{
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0xAC22EC", Offset = "0xAC22EC", VA = "0xAC22EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622460", Offset = "0x622460")]
	private IEnumerator DelayForwardEvent()
	{
		return null;
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0xAC2358", Offset = "0xAC2358", VA = "0xAC2358")]
	private void OnButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003231")]
	[Address(RVA = "0xAC0FC0", Offset = "0xAC0FC0", VA = "0xAC0FC0")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6003232")]
	[Address(RVA = "0xAC2390", Offset = "0xAC2390", VA = "0xAC2390")]
	private void OnFadeFinished()
	{
	}

	[Token(Token = "0x6003233")]
	[Address(RVA = "0xAC23C0", Offset = "0xAC23C0", VA = "0xAC23C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0xAC24A4", Offset = "0xAC24A4", VA = "0xAC24A4")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x6003235")]
	[Address(RVA = "0xAC24FC", Offset = "0xAC24FC", VA = "0xAC24FC")]
	public PointyTooltip()
	{
	}
}
