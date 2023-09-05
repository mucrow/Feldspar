namespace Feldspar {
  /**
   * ToolType isn't really used for any calculations or game conditions. Categorizing weapons just
   * seems helpful for the player.
   */
  public enum ToolType {
    /** includes curved swords, piercing swords, butcher's knives, and machetes */
    Sword = 100,

    /** includes curved greatswords */
    GreatSword = 200,

    /** includes hatchets */
    Axe = 300,

    GreatAxe = 400,

    /** i.e. blunt weapons; includes maces, clubs, bats, flails, keyblades, and frying pans */
    Hammer = 500,

    GiantHammer = 600,

    /** includes heavier spears, tridents, and pitchforks */
    Spear = 700,

    /** includes heavier polearms (i.e., there is no GiantPolearm classification) */
    Polearm = 800,

    /** includes curved daggers and knives */
    Dagger = 900,

    /** includes sickles */
    Scythe = 1000,

    /** includes chains, chain whips */
    Whip = 1100,

    /** includes brass knuckles, claws, and katars */
    Fist = 1200,

    /** includes longbows and greatbows */
    Bow = 1300,

    /** includes giant crossbows */
    Crossbow = 1400,

    /** includes pistols, rifles, shotguns, cannons, and flamethrowers */
    Gun = 1500,

    /**
     * includes kunai, throwing stars, bombs, javelins, throwing urns, splash potions, throwing
     * axes, throwing knives
     */
    Thrown = 1600,

    Wand = 1700,

    Staff = 1800,

    /**
     * includes crosses, magical books, talismans, totems, relics, seals, regalia, sigils, tablets,
     * cards, hourglasses, non-wand catalysts, and fetishes
     */
    MagicalObject = 1900,

    /** includes bells, chimes, and music boxes */
    MusicalInstrument = 2000,

    /**
     * includes torches, boomerangs, yoyos, nunchuks, slingshots, chainsaws, blowpipes,
     * [and more???]
     */
    Unconventional = 2100,

    Buckler = 2200,

    /** includes mirror shields */
    Shield = 2300,

    GreatShield = 2400,
  }
}
