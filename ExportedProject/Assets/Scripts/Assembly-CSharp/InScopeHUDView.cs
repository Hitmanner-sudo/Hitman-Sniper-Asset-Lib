using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000678")]
public class InScopeHUDView : View
{
	[Token(Token = "0x4002405")]
	[FieldOffset(Offset = "0x60")]
	public GameObject[] ControlsToHideOnGameFinished;

	[Token(Token = "0x4002406")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ZoomLabel;

	[Token(Token = "0x4002407")]
	[FieldOffset(Offset = "0x70")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4002408")]
	[FieldOffset(Offset = "0x78")]
	public UITexture ScopeTexture;

	[Token(Token = "0x4002409")]
	[FieldOffset(Offset = "0x80")]
	public Transform AlertLevelParent;

	[Token(Token = "0x400240A")]
	[FieldOffset(Offset = "0x88")]
	public TweenAlpha InScopeTweener;

	[Token(Token = "0x400240B")]
	[FieldOffset(Offset = "0x90")]
	public TweenAlpha OutOfScopeTweener;

	[Token(Token = "0x400240C")]
	[FieldOffset(Offset = "0x98")]
	public Transform ScopePanel;

	[Token(Token = "0x400240D")]
	[FieldOffset(Offset = "0xA0")]
	public Transform ScopeLight;

	[Token(Token = "0x400240E")]
	[FieldOffset(Offset = "0xA8")]
	public UITexture ScopeLightTexture;

	[Token(Token = "0x400240F")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject SlowMotionGO;

	[Token(Token = "0x4002410")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite SlowMotionBackground;

	[Token(Token = "0x4002411")]
	[FieldOffset(Offset = "0xC0")]
	public UICircleProgressBar SlowMotionProgress;

	[Token(Token = "0x4002412")]
	[FieldOffset(Offset = "0xC8")]
	public PointyTooltip SlowMotionTooltip;

	[Token(Token = "0x4002413")]
	[FieldOffset(Offset = "0xD0")]
	public LazyTexture2D ScopeLightLowEnd;

	[Token(Token = "0x4002414")]
	[FieldOffset(Offset = "0xD8")]
	public LazyTexture2D ScopeLightHighEnd;

	[Token(Token = "0x4002415")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 _initialScale;

	[Token(Token = "0x4002416")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 _initialDir;

	[Token(Token = "0x4002417")]
	[FieldOffset(Offset = "0xF8")]
	private Transform _scopeTransform;

	[Token(Token = "0x4002418")]
	[FieldOffset(Offset = "0x100")]
	private Camera _fpsCamera;

	[Token(Token = "0x4002419")]
	[FieldOffset(Offset = "0x108")]
	private string _distanceText;

	[Token(Token = "0x400241A")]
	[FieldOffset(Offset = "0x110")]
	private int _activeHeight;

	[Token(Token = "0x400241B")]
	[FieldOffset(Offset = "0x118")]
	private readonly StringBuilder _distanceBuilder;

	[Token(Token = "0x6002A38")]
	[Address(RVA = "0xB07260", Offset = "0xB07260", VA = "0xB07260", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002A39")]
	[Address(RVA = "0xB07360", Offset = "0xB07360", VA = "0xB07360", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0xB07A30", Offset = "0xB07A30", VA = "0xB07A30", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0xB07DC0", Offset = "0xB07DC0", VA = "0xB07DC0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0xB07F9C", Offset = "0xB07F9C", VA = "0xB07F9C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0xB080C4", Offset = "0xB080C4", VA = "0xB080C4", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0xB0791C", Offset = "0xB0791C", VA = "0xB0791C")]
	private void OnAimingAngleChanged(float angle)
	{
	}

	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0xB07C34", Offset = "0xB07C34", VA = "0xB07C34")]
	private void OnScopeTextureChanged(LazyTexture2D texture)
	{
	}

	[Token(Token = "0x6002A40")]
	[Address(RVA = "0xB07D34", Offset = "0xB07D34", VA = "0xB07D34")]
	private void SetScopeLightTexture(LazyTexture2D texture)
	{
	}

	[Token(Token = "0x6002A41")]
	[Address(RVA = "0xB07CC0", Offset = "0xB07CC0", VA = "0xB07CC0")]
	private void OnScopeTextureColorChanged(Color color)
	{
	}

	[Token(Token = "0x6002A42")]
	[Address(RVA = "0xB0786C", Offset = "0xB0786C", VA = "0xB0786C")]
	private void OnHUDColorChanged(Color color)
	{
	}

	[Token(Token = "0x6002A43")]
	[Address(RVA = "0xB08D14", Offset = "0xB08D14", VA = "0xB08D14")]
	private void OnFPSCameraChanged(Camera c)
	{
	}

	[Token(Token = "0x6002A44")]
	[Address(RVA = "0xB07B64", Offset = "0xB07B64", VA = "0xB07B64")]
	private void OnScopeTransformChanged(Transform t)
	{
	}

	[Token(Token = "0x6002A45")]
	[Address(RVA = "0xB08D1C", Offset = "0xB08D1C", VA = "0xB08D1C")]
	private Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002A46")]
	[Address(RVA = "0xB08DD8", Offset = "0xB08DD8", VA = "0xB08DD8", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0xB075F8", Offset = "0xB075F8", VA = "0xB075F8")]
	private void OnZoomChanged(float zoom)
	{
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0xB09038", Offset = "0xB09038", VA = "0xB09038")]
	private void OnShowDistanceChanged(bool isVisible)
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0xB0769C", Offset = "0xB0769C", VA = "0xB0769C")]
	private void OnDistanceChanged(float distance)
	{
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0xB0784C", Offset = "0xB0784C", VA = "0xB0784C")]
	private void OnSlowMotionProgressChanged(float progress)
	{
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0xB0778C", Offset = "0xB0778C", VA = "0xB0778C")]
	private void OnShowHoldBreathTooltipChanged(bool show)
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0xB07900", Offset = "0xB07900", VA = "0xB07900")]
	private void OnSetHoldBreathTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0xB078E0", Offset = "0xB078E0", VA = "0xB078E0")]
	private void OnHoldBreathDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0xB08AE8", Offset = "0xB08AE8", VA = "0xB08AE8")]
	private void OnPauseMenuStateChanged(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0xB07970", Offset = "0xB07970", VA = "0xB07970")]
	private void OnHoldBreathHighlightActiveChanged(bool active)
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0xB08BAC", Offset = "0xB08BAC", VA = "0xB08BAC")]
	private void OnSlowMotionEnabledChanged(bool isEnabled)
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0xB09058", Offset = "0xB09058", VA = "0xB09058")]
	public InScopeHUDView()
	{
	}
}
