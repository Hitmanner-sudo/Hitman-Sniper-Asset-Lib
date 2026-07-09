using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000500")]
[Scope]
public class CalenderManager : GameSingleton<CalenderManager>
{
	[Token(Token = "0x2000501")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594EEC", Offset = "0x594EEC")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x10")]
		public string levelName;

		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x860E60", Offset = "0x860E60", VA = "0x860E60")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x860E68", Offset = "0x860E68", VA = "0x860E68")]
		internal bool _003CGetSceneName_003Eb__0(CalenderModel.AlternateLevel elem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000502")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594EFC", Offset = "0x594EFC")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x10")]
		public LazyCharacter characterPrefab;

		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x860E8C", Offset = "0x860E8C", VA = "0x860E8C")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x860E94", Offset = "0x860E94", VA = "0x860E94")]
		internal bool _003CGetEventSpecificCharacter_003Eb__0(CalenderModel.AlternateCharacter elem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000503")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F0C", Offset = "0x594F0C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x10")]
		public SoundContainer soundContainer;

		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x860EF8", Offset = "0x860EF8", VA = "0x860EF8")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x860F00", Offset = "0x860F00", VA = "0x860F00")]
		internal bool _003CGetReplacementSoundContainer_003Eb__0(CalenderModel.AlternateSoundContainer s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000504")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F1C", Offset = "0x594F1C")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x10")]
		public Texture texture;

		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x860F28", Offset = "0x860F28", VA = "0x860F28")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0x860F30", Offset = "0x860F30", VA = "0x860F30")]
		internal bool _003CGetReplacementTexture_003Eb__0(CalenderModel.AlternateTexture elem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000505")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F2C", Offset = "0x594F2C")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x10")]
		public Material sharedMaterial;

		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x860FA4", Offset = "0x860FA4", VA = "0x860FA4")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x860FAC", Offset = "0x860FAC", VA = "0x860FAC")]
		internal bool _003CGetReplacementMaterial_003Eb__0(CalenderModel.AlternateMaterial elem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001AAA")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0xA8C95C", Offset = "0xA8C95C", VA = "0xA8C95C")]
	public string GetSceneName(string levelName)
	{
		return null;
	}

	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0xA8CB48", Offset = "0xA8CB48", VA = "0xA8CB48")]
	public LazyCharacter GetEventSpecificCharacter(LazyCharacter characterPrefab)
	{
		return null;
	}

	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0xA8CD34", Offset = "0xA8CD34", VA = "0xA8CD34")]
	public List<LazyInventoryItem> GetEventInventoryItemsToAdd(Faction faction)
	{
		return null;
	}

	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0xA8CEC8", Offset = "0xA8CEC8", VA = "0xA8CEC8")]
	public SoundContainer GetEventSpecificSoundContainer(SoundContainer soundContainer)
	{
		return null;
	}

	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0xA8CFCC", Offset = "0xA8CFCC", VA = "0xA8CFCC")]
	public static SoundContainer GetReplacementSoundContainer(SoundContainer soundContainer, CalenderModel.AlternateSoundContainer[] alternates)
	{
		return null;
	}

	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0xA8D150", Offset = "0xA8D150", VA = "0xA8D150")]
	public CalenderModel.AlternateTexture? GetEventSpecificTexture(Texture texture)
	{
		return null;
	}

	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0xA8D24C", Offset = "0xA8D24C", VA = "0xA8D24C")]
	public static CalenderModel.AlternateTexture? GetReplacementTexture(Texture texture, CalenderModel.AlternateTexture[] alternates)
	{
		return null;
	}

	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0xA8D580", Offset = "0xA8D580", VA = "0xA8D580")]
	public LazyMaterial GetEventSpecificMaterial(Material sharedMaterial)
	{
		return null;
	}

	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0xA8D644", Offset = "0xA8D644", VA = "0xA8D644")]
	public static LazyMaterial GetReplacementMaterial(Material sharedMaterial, CalenderModel.AlternateMaterial[] alternates)
	{
		return null;
	}

	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0xA8D90C", Offset = "0xA8D90C", VA = "0xA8D90C")]
	public SpecialPopup[] GetEventSpecificSpecialPopup()
	{
		return null;
	}

	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0xA8D940", Offset = "0xA8D940", VA = "0xA8D940")]
	public LazyWeaponUnlockable[] GetEventSpecificArmoryWeapon()
	{
		return null;
	}

	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0xA8D974", Offset = "0xA8D974", VA = "0xA8D974")]
	public CalenderModel.ScoreItemData[] GetExtraScoreTallyItems()
	{
		return null;
	}

	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0xA8C92C", Offset = "0xA8C92C", VA = "0xA8C92C")]
	public CalenderModel.CalenderEvent GetCurrentEvent()
	{
		return null;
	}

	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0xA8DA1C", Offset = "0xA8DA1C", VA = "0xA8DA1C")]
	public CalenderModel.CalenderEvent GetEventByDate(DateTime date)
	{
		return null;
	}

	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0xA8DA9C", Offset = "0xA8DA9C", VA = "0xA8DA9C")]
	public CalenderModel.CalenderEvent[] GetEvents()
	{
		return null;
	}

	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0xA8DCD0", Offset = "0xA8DCD0", VA = "0xA8DCD0")]
	public bool IsDisplayEventVisual()
	{
		return default(bool);
	}

	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0xA8DDC0", Offset = "0xA8DDC0", VA = "0xA8DDC0")]
	public void SetHideEventVisualDate()
	{
	}

	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0xA8DE5C", Offset = "0xA8DE5C", VA = "0xA8DE5C")]
	public void ResetHideEventVisualDate()
	{
	}

	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0xA8D9A8", Offset = "0xA8D9A8", VA = "0xA8D9A8")]
	private DateTime GetValidDate()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0xA8DEDC", Offset = "0xA8DEDC", VA = "0xA8DEDC")]
	public CalenderManager()
	{
	}
}
