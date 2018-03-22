// Copyright (C) 2016-2017 David Pol. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

using System.Collections;

using UnityEngine;
using UnityEngine.Assertions;

using DG.Tweening;
using TMPro;

/// <summary>
/// This class wraps the game scene's user interface and it is mostly updated when the server
/// sends updated information to the client.
/// </summary>
public class GameUI : MonoBehaviour
{
    public GameObject playerActiveBackground;
    public GameObject playerInactiveBackground;
    public GameObject opponentActiveBackground;
    public GameObject opponentInactiveBackground;
    public GameObject playerAvatarBorder;
    public GameObject playerAvatarGlow;
    public GameObject opponentAvatarBorder;
    public GameObject opponentAvatarGlow;

    public TextMeshPro playerNameText;
    public TextMeshPro opponentNameText;

    public TextMeshPro playerCastleText;
    public TextMeshPro opponentCastleText;

    public TextMeshPro playerDeckText;
    public TextMeshPro opponentDeckText;
    public TextMeshPro playerHandText;
    public TextMeshPro opponentHandText;
    public TextMeshPro playerGraveyardText;
    public TextMeshPro opponentGraveyardText;

    public PlayerManaBar playerManaBar;
    public TextMeshPro opponentManaText;

    public TextMeshPro playerDefenseText;
    public TextMeshPro opponentDefenseText;
    //public TextMeshPro playerGenhpText;
    //public TextMeshPro opponentGenhpText;

    public TextMeshPro playerWorkersText;
    public TextMeshPro opponentWorkersText;
    public TextMeshPro playerBricksText;
    public TextMeshPro opponentBricksText;
    public TextMeshPro playerSoldiersText;
    public TextMeshPro opponentSoldiersText;
    public TextMeshPro playerWeaponText;
    public TextMeshPro opponentWeaponText;
    public TextMeshPro playerMagicText;
    public TextMeshPro opponentMagicText;
    public TextMeshPro playerCrystalsText;
    public TextMeshPro opponentCrystalsText;


    public SpriteRenderer endTurnSprite;
    public TextMeshPro endTurnTitleText;
    public TextMeshPro endTurnTimeText;
    public EndTurnButton endTurnButton;

    private void Awake()
    {
        Assert.IsNotNull(playerActiveBackground);
        Assert.IsNotNull(playerInactiveBackground);
        Assert.IsNotNull(opponentActiveBackground);
        Assert.IsNotNull(opponentInactiveBackground);
        Assert.IsNotNull(playerAvatarBorder);
        Assert.IsNotNull(playerAvatarGlow);
        Assert.IsNotNull(opponentAvatarBorder);
        Assert.IsNotNull(opponentAvatarGlow);
        Assert.IsNotNull(playerNameText);
        Assert.IsNotNull(opponentNameText);
        Assert.IsNotNull(playerCastleText);
        Assert.IsNotNull(opponentCastleText);
        Assert.IsNotNull(playerDeckText);
        Assert.IsNotNull(opponentDeckText);
        Assert.IsNotNull(playerHandText);
        Assert.IsNotNull(opponentHandText);
        Assert.IsNotNull(playerGraveyardText);
        Assert.IsNotNull(opponentGraveyardText);
        Assert.IsNotNull(playerManaBar);
        Assert.IsNotNull(opponentManaText);
        Assert.IsNotNull(endTurnSprite);
        Assert.IsNotNull(endTurnTitleText);
        Assert.IsNotNull(endTurnTimeText);
        Assert.IsNotNull(endTurnButton);

        Assert.IsNotNull(playerDefenseText);
        Assert.IsNotNull(opponentDefenseText);
        //Assert.IsNotNull(playerGenhpText);
        //Assert.IsNotNull(opponentGenhpText);

        Assert.IsNotNull(playerWorkersText);
        Assert.IsNotNull(opponentWorkersText);
        Assert.IsNotNull(playerBricksText);
        Assert.IsNotNull(opponentBricksText);
        Assert.IsNotNull(playerSoldiersText);
        Assert.IsNotNull(opponentSoldiersText);
        Assert.IsNotNull(playerWeaponText);
        Assert.IsNotNull(opponentWeaponText);
        Assert.IsNotNull(playerMagicText);
        Assert.IsNotNull(opponentMagicText);
        Assert.IsNotNull(playerCrystalsText);
        Assert.IsNotNull(opponentCrystalsText);
    }

    public void SetPlayerActive(bool active)
    {
        playerActiveBackground.SetActive(active);
        playerInactiveBackground.SetActive(!active);
        playerAvatarBorder.SetActive(active);
        playerAvatarGlow.SetActive(active);
    }

    public void SetOpponentActive(bool active)
    {
        opponentActiveBackground.SetActive(active);
        opponentInactiveBackground.SetActive(!active);
        opponentAvatarBorder.SetActive(active);
        opponentAvatarGlow.SetActive(active);
    }

    public void SetPlayerName(string text)
    {
        playerNameText.text = text;
    }

    public void SetOpponentName(string text)
    {
        opponentNameText.text = text;
    }

    public void SetPlayerCastle(int castle)
    {
        playerCastleText.text = castle.ToString();
    }

    public void SetOpponentCastle(int castle)
    {
        opponentCastleText.text = castle.ToString();
    }

    public void SetPlayerDeckCards(int cards)
    {
        playerDeckText.text = cards.ToString();
    }

    public void SetPlayerHandCards(int cards)
    {
        playerHandText.text = cards.ToString();
    }

    public void SetPlayerGraveyardCards(int cards)
    {
        playerGraveyardText.text = cards.ToString();
    }

    public void SetOpponentDeckCards(int cards)
    {
        opponentDeckText.text = cards.ToString();
    }

    public void SetOpponentHandCards(int cards)
    {
        opponentHandText.text = cards.ToString();
    }

    public void SetOpponentGraveyardCards(int cards)
    {
        opponentGraveyardText.text = cards.ToString();
    }

    public void SetPlayerMana(int mana)
    {
        playerManaBar.SetMana(mana);
    }

    public void SetOpponentMana(int mana)
    {
        opponentManaText.text = mana + "/10";
    }

    public void SetPlayerDefense(int defense)
    {
        playerDefenseText.text = defense.ToString();
    }

    public void SetOpponentDefense(int defense)
    {
        opponentDefenseText.text = defense.ToString();
    }
    /*
    public void SetPlayerGenhp(int genhp)
    {
        playerGenhpText.text = "GenHP: " + genhp;
    }

    public void SetOpponentGenhp(int genhp)
    {
        opponentGenhpText.text = "GenHP: " + genhp;
    }
    */
    public void SetPlayerWorkers(int workers)
    {
        playerWorkersText.text = workers.ToString();
    }

    public void SetOpponentWorkers(int workers)
    {
        opponentWorkersText.text = workers.ToString();
    }

    public void SetPlayerBricks(int bricks)
    {
        playerBricksText.text = bricks.ToString();
    }

    public void SetOpponentBricks(int bricks)
    {
        opponentBricksText.text = bricks.ToString();
    }

    public void SetPlayerSoldiers(int soldiers)
    {
        playerSoldiersText.text = soldiers.ToString();
    }

    public void SetOpponentSoldiers(int soldiers)
    {
        opponentSoldiersText.text = soldiers.ToString();
    }

    public void SetPlayerWeapon(int weapon)
    {
        playerWeaponText.text = weapon.ToString();
    }

    public void SetOpponentWeapon(int weapon)
    {
        opponentWeaponText.text = weapon.ToString();
    }

    public void SetPlayerMagic(int magic)
    {
        playerMagicText.text = magic.ToString();
    }

    public void SetOpponentMagic(int magic)
    {
        opponentMagicText.text = magic.ToString();
    }

    public void SetPlayerCrystals(int crystals)
    {
        playerCrystalsText.text = crystals.ToString();
    }

    public void SetOpponentCrystals(int crystals)
    {
        opponentCrystalsText.text = crystals.ToString();
    }

    public void SetEndTurnButtonEnabled(bool enabled)
    {
        endTurnButton.SetEnabled(enabled);
    }

    public void StartTurnCountdown(int time)
    {
        endTurnSprite.DOFade(1.0f, 0.3f);
        endTurnTitleText.DOFade(1.0f, 0.3f);
        endTurnTimeText.DOFade(1.0f, 0.3f);
        StartCoroutine(StartCountdown(time));
    }

    public void HideTurnCountdown()
    {
        endTurnSprite.DOFade(0.0f, 0.2f);
        endTurnTitleText.DOFade(0.0f, 0.2f);
        endTurnTimeText.DOFade(0.0f, 0.2f);
    }

    private IEnumerator StartCountdown(int time)
    {
        while (time >= 0)
        {
            endTurnTimeText.text = time.ToString();
            yield return new WaitForSeconds(1.0f);
            time -= 1;
        }
    }

    public void StopCountdown()
    {
        StopAllCoroutines();
    }
}
