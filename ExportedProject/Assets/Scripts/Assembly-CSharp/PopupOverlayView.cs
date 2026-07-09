using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000739")]
public class PopupOverlayView : PopupOverlayViewBase
{
	[Token(Token = "0x40028E1")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BA21C", Offset = "0x5BA21C")]
	[SerializeField]
	private UITexture _image;

	[Token(Token = "0x40028E2")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BA268", Offset = "0x5BA268")]
	private UIWidget _background;

	[Token(Token = "0x40028E3")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BA2B4", Offset = "0x5BA2B4")]
	private Camera _weaponCamera;

	[Token(Token = "0x40028E4")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BA300", Offset = "0x5BA300")]
	private Light _weaponLight;

	[Token(Token = "0x40028E5")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BA34C", Offset = "0x5BA34C")]
	private Transform _weaponHolder;

	[Token(Token = "0x40028E6")]
	[FieldOffset(Offset = "0xE8")]
	private readonly List<Material[]> _weaponInitMaterials;

	[Token(Token = "0x40028E7")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject _weapon;

	[Token(Token = "0x40028E8")]
	[FieldOffset(Offset = "0xF8")]
	private List<Renderer> _weaponRenderers;

	[Token(Token = "0x17000630")]
	public UITexture Image
	{
		[Token(Token = "0x600302B")]
		[Address(RVA = "0x939070", Offset = "0x939070", VA = "0x939070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600302C")]
	[Address(RVA = "0x9315AC", Offset = "0x9315AC", VA = "0x9315AC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600302D")]
	[Address(RVA = "0x93138C", Offset = "0x93138C", VA = "0x93138C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600302E")]
	[Address(RVA = "0x939078", Offset = "0x939078", VA = "0x939078", Slot = "18")]
	protected override void CleanUp()
	{
	}

	[Token(Token = "0x600302F")]
	[Address(RVA = "0x939198", Offset = "0x939198", VA = "0x939198")]
	private void DestroyWeapon()
	{
	}

	[Token(Token = "0x6003030")]
	[Address(RVA = "0x937C50", Offset = "0x937C50", VA = "0x937C50")]
	public void SetupPopupOverlay(Transform tParent, string title, string message, PopupButton okButton, PopupButton cancelButton, WeaponUnlockable weaponUnlockable, bool showRedLight, int descriptionPosYOffset)
	{
	}

	[Token(Token = "0x6003031")]
	[Address(RVA = "0x930EB8", Offset = "0x930EB8", VA = "0x930EB8")]
	public void SetupPopupOverlay(Transform tParent, string title, string message, PopupButton okButton, PopupButton cancelButton, Texture texture, int width, int height, int imagePosYOffset, Texture background, bool showBackground)
	{
	}

	[Token(Token = "0x6003032")]
	[Address(RVA = "0x939440", Offset = "0x939440", VA = "0x939440", Slot = "17")]
	protected override void InternalSetupPopupOverlay(Transform parent, string title, string message, PopupButton okButton, PopupButton cancelButton)
	{
	}

	[Token(Token = "0x6003033")]
	[Address(RVA = "0x939268", Offset = "0x939268", VA = "0x939268")]
	protected bool InternalSetupWeapon(WeaponUnlockable weaponUnlockable, bool showRedLight)
	{
		return default(bool);
	}

	[Token(Token = "0x6003034")]
	[Address(RVA = "0x937128", Offset = "0x937128", VA = "0x937128")]
	protected void CancelPopup()
	{
	}

	[Token(Token = "0x6003035")]
	[Address(RVA = "0x92D534", Offset = "0x92D534", VA = "0x92D534")]
	public PopupOverlayView()
	{
	}
}
