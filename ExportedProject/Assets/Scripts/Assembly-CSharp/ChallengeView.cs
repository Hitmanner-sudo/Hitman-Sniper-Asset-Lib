using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000646")]
public class ChallengeView : View
{
	[Token(Token = "0x400228F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UITexture _contractLocationTexture;

	[Token(Token = "0x4002290")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UITexture _contractLocationTexturePhone;

	[Token(Token = "0x4002291")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _zombieDifficultyPrefab;

	[Token(Token = "0x4002292")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UIGrid _levelsParentUIGrid;

	[Token(Token = "0x4002293")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _missionTitleUILabel;

	[Token(Token = "0x4002294")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UITexture _missionTitleBackgroundUITexture;

	[Token(Token = "0x4002295")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UILabel _missionDescriptionUILabel;

	[Token(Token = "0x4002296")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private LazyUITexture _locationTexture;

	[Token(Token = "0x4002297")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyUITexture _locationTexturePhone;

	[Token(Token = "0x4002298")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private int _spacebetweenDifficulties;

	[Token(Token = "0x4002299")]
	[FieldOffset(Offset = "0xB0")]
	private List<ChallengeDifficultyView> _challengeDifficultyViews;

	[Token(Token = "0x6002888")]
	[Address(RVA = "0xAF66BC", Offset = "0xAF66BC", VA = "0xAF66BC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0xAF6850", Offset = "0xAF6850", VA = "0xAF6850", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0xAF69F0", Offset = "0xAF69F0", VA = "0xAF69F0")]
	private void OnActiveDifficultyTypeChanged(ContractDataModel.DifficultyType difficultyType)
	{
	}

	[Token(Token = "0x600288B")]
	[Address(RVA = "0xAF6758", Offset = "0xAF6758", VA = "0xAF6758")]
	private void OnChallengeDataChanged(ContractDataModel contractDataModel)
	{
	}

	[Token(Token = "0x600288C")]
	[Address(RVA = "0xAF6E3C", Offset = "0xAF6E3C", VA = "0xAF6E3C")]
	private void SetLevels(ChallengeData challengeData)
	{
	}

	[Token(Token = "0x600288D")]
	[Address(RVA = "0xAF6D18", Offset = "0xAF6D18", VA = "0xAF6D18")]
	private void UpdateContractImage(ChallengeData challengeData)
	{
	}

	[Token(Token = "0x600288E")]
	[Address(RVA = "0xAF7588", Offset = "0xAF7588", VA = "0xAF7588")]
	private void SetContractImage(LazyUITexture currentContractTexture, UITexture texture)
	{
	}

	[Token(Token = "0x600288F")]
	[Address(RVA = "0xAF6B3C", Offset = "0xAF6B3C", VA = "0xAF6B3C")]
	private void SetDifficultyHeader(string titleKey, string descKey)
	{
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0xAF76A0", Offset = "0xAF76A0", VA = "0xAF76A0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0xAF77DC", Offset = "0xAF77DC", VA = "0xAF77DC")]
	public ChallengeView()
	{
	}
}
