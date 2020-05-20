module Cards
open Keywords
open Effects

type CardType =
    | Creature
    | Action
    | Item
    | Support

type CardAttributes =
    | Strength
    | Intelligence
    | Willpower
    | Agility
    | Endurance
    | Neutral

type DualCardClasses =
    | Archer
    | Assassin
    | Battlemage
    | Crusader
    | Mage
    | Monk
    | Scout
    | Sorcerer
    | Spellsword
    | Warrior

type TriCardClasses =
    | HouseRedoran
    | HouseTelvanni
    | HouseHlaalu
    | TribunalTemple
    | HouseDagoth
    | EbonheartPact
    | DaggerfallCovenant
    | AldmeriDominion
    | TheGuildsworn
    | TheEmpireOfCyrodiil

type CardRarity =
    | Common
    | Epic
    | Legendary
    | Rare

type CardUnique =
    | Unique
    | NotUnique


type Animal =
    | Beast
    | Fish
    | Mammoth
    | Mudcrab
    | Netch
    | Reptile
    | Spider
    | Skeever
    | Wolf

type Undead =
    | Mummy
    | Skeleton
    | Spirit
    | Vampire

type Race =
    | Argonian
    | Breton
    | DarkElf
    | HighElf
    | Imperial
    | Khajiit
    | Nord
    | Orc
    | Redguard
    | WoodElf

type OtherTypes =
    | AshCreature
    | Atronach
    | Automaton
    | Ayleid
    | Centaur
    | Chaurus
    | Daedra 
    | Defense
    | Dragon
    | Dreugh
    | Dwemer 
    | Elytra 
    | Falmer
    | Fabricant 
    | Factotum 
    | Gargoyle 
    | Giant 
    | Goblin 
    | God 
    | Grummite 
    | Harpy 
    | Imp 
    | Insect 
    | Kwama 
    | Lurcher 
    | Mantikora 
    | Minotaur 
    | Nereid 
    | Ogre 
    | Pastry 
    | Portal 
    | Reachman 
    | Spriggan 
    | Troll 
    | Wamasu 
    | Werewolf 
    | Wraith

type CreatureType =
    | None
    | Race of Race
    | Undead of Undead
    | Animal of Animal    
    | OtherTypes of OtherTypes
    | Multiple of CreatureType list

type Card = {
    Name: string
    Description: string
    CardType: CardType
    CreatureType: CreatureType
    Effects: Effect list
    Keywords: Keyword list list
}

