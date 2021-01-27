module Deck
open Cards
open Lanes

type DeckAttr =
    | Single of CardAttributes
    | Dual of DualCardClasses
    | Triple of TriCardClasses

type Collection = {
    Attribute: DeckAttr
    Cards: Card list
}

type Player = {
    PlayDeck: ResizeArray<Card>
    DiscardDeck: ResizeArray<Card>
    LifePoints: int
    Magicka: int
}

type Lane = {
    Cards: ResizeArray<Card>
    LaneType: LaneType
}

type Board = {
    Player1: Player
    Player2: Player
    LeftLane: Lane
    RightLane: Lane
}

