using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000889")]
public static class Tags
{
	[Token(Token = "0x200088A")]
	[Flags]
	public enum Layers
	{
		[Token(Token = "0x4002FD9")]
		Default = 1,
		[Token(Token = "0x4002FDA")]
		TransparentFX = 2,
		[Token(Token = "0x4002FDB")]
		Ignore_Raycast = 4,
		[Token(Token = "0x4002FDC")]
		ReservedBuiltIn3 = 8,
		[Token(Token = "0x4002FDD")]
		Water = 0x10,
		[Token(Token = "0x4002FDE")]
		UI = 0x20,
		[Token(Token = "0x4002FDF")]
		ReservedBuiltIn6 = 0x40,
		[Token(Token = "0x4002FE0")]
		ReservedBuiltIn7 = 0x80,
		[Token(Token = "0x4002FE1")]
		DynamicObject = 0x100,
		[Token(Token = "0x4002FE2")]
		CharacterDetailed = 0x200,
		[Token(Token = "0x4002FE3")]
		Player = 0x400,
		[Token(Token = "0x4002FE4")]
		GUI = 0x800,
		[Token(Token = "0x4002FE5")]
		Geometry = 0x1000,
		[Token(Token = "0x4002FE6")]
		Gameplay = 0x2000,
		[Token(Token = "0x4002FE7")]
		InvisibleWall = 0x4000,
		[Token(Token = "0x4002FE8")]
		FirstPersonMesh = 0x8000,
		[Token(Token = "0x4002FE9")]
		Store3DAboveGUI = 0x10000,
		[Token(Token = "0x4002FEA")]
		CharacterCapsule = 0x20000,
		[Token(Token = "0x4002FEB")]
		TargetingSystem = 0x40000,
		[Token(Token = "0x4002FEC")]
		Background = 0x80000,
		[Token(Token = "0x4002FED")]
		SniperLens = 0x100000,
		[Token(Token = "0x4002FEE")]
		Instinct = 0x200000,
		[Token(Token = "0x4002FEF")]
		CharacterTrigger = 0x400000,
		[Token(Token = "0x4002FF0")]
		FirstPersonMeshInScope = 0x800000,
		[Token(Token = "0x4002FF1")]
		ScopeBackground = 0x1000000,
		[Token(Token = "0x4002FF2")]
		SniperSpot = 0x2000000,
		[Token(Token = "0x4002FF3")]
		InstinctDynamicObject = 0x4000000,
		[Token(Token = "0x4002FF4")]
		StoreUI = 0x8000000,
		[Token(Token = "0x4002FF5")]
		Store3DUI = 0x10000000,
		[Token(Token = "0x4002FF6")]
		InstinctDynamicObjectTransparent = 0x20000000,
		[Token(Token = "0x4002FF7")]
		AIVisionBlocker = 0x40000000,
		[Token(Token = "0x4002FF8")]
		PopupUI = int.MinValue
	}

	[Token(Token = "0x200088B")]
	[Flags]
	public enum Filters
	{
		[Token(Token = "0x4002FFA")]
		AIVisionBlockers = 0x44003100,
		[Token(Token = "0x4002FFB")]
		ExposionBlockers = 0x1000,
		[Token(Token = "0x4002FFC")]
		BulletCollisions = 0x24227100,
		[Token(Token = "0x4002FFD")]
		MortarCollisions = 0x24223100,
		[Token(Token = "0x4002FFE")]
		AllCharacterCollisions = 0x300
	}

	[Token(Token = "0x4002FC5")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string UNTAGGED;

	[Token(Token = "0x4002FC6")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string RESPAWN;

	[Token(Token = "0x4002FC7")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string FINISH;

	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string EDITOR_ONLY;

	[Token(Token = "0x4002FC9")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string MAIN_CAMERA;

	[Token(Token = "0x4002FCA")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string PLAYER;

	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string GAME_CONTROLLER;

	[Token(Token = "0x4002FCC")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string NO_CAM;

	[Token(Token = "0x4002FCD")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string BRIEFING;

	[Token(Token = "0x4002FCE")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string DEBRIEFING;

	[Token(Token = "0x4002FCF")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string BRIEFING_COMMON_BACKGROUND;

	[Token(Token = "0x4002FD0")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string SPAWNER_GIZMO;

	[Token(Token = "0x4002FD1")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string ASSET_BUNDLE;

	[Token(Token = "0x4002FD2")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string NGUI_DRAWCALL;

	[Token(Token = "0x4002FD3")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string FX_TEMPORAIRE;

	[Token(Token = "0x4002FD4")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string FIRE;

	[Token(Token = "0x4002FD5")]
	[FieldOffset(Offset = "0x80")]
	public static readonly string DO_NOT_HIDE_UI;

	[Token(Token = "0x4002FD6")]
	[FieldOffset(Offset = "0x88")]
	public static readonly string EXPLOSIVE_HOOK_ANCHOR;

	[Token(Token = "0x4002FD7")]
	[FieldOffset(Offset = "0x90")]
	public static readonly string JUST_CAUSE_POPUP_CHECK_MARK;

	[Token(Token = "0x60037BB")]
	[Address(RVA = "0xB4E314", Offset = "0xB4E314", VA = "0xB4E314")]
	public static bool HasLayers(this GameObject go, Layers layers)
	{
		return default(bool);
	}

	[Token(Token = "0x60037BC")]
	[Address(RVA = "0xB4E384", Offset = "0xB4E384", VA = "0xB4E384")]
	public static bool HasLayers(this GameObject go, int layers)
	{
		return default(bool);
	}

	[Token(Token = "0x60037BD")]
	[Address(RVA = "0xB4E3C0", Offset = "0xB4E3C0", VA = "0xB4E3C0")]
	public static void SetLayer(this GameObject go, Layers layerId, bool recursive = false)
	{
	}

	[Token(Token = "0x60037BE")]
	[Address(RVA = "0xB4E55C", Offset = "0xB4E55C", VA = "0xB4E55C")]
	public static void SetLayer(this GameObject go, string layerName, bool recursive = false)
	{
	}

	[Token(Token = "0x60037BF")]
	[Address(RVA = "0xB4E458", Offset = "0xB4E458", VA = "0xB4E458")]
	public static void SetLayer(this GameObject go, int layerId, bool recursive = false)
	{
	}

	[Token(Token = "0x60037C0")]
	[Address(RVA = "0xB4E5E8", Offset = "0xB4E5E8", VA = "0xB4E5E8")]
	public static void SetTag(this GameObject go, string tag, bool recursive = false)
	{
	}
}
