module Deck
open Cards

type DeckType = 
    | DiscardDeck
    | PlayDeck

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

