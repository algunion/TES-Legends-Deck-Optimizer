#r "nuget: FSharp.Data"

open FSharp.Data

type CardProvider = HtmlProvider<"https://en.uesp.net/wiki/Legends:Fiery_Imp">

let imp = CardProvider.GetSample()

imp.Html.Body().Elements().[0].Elements().[0]

let getCardName (card: CardProvider) = card.Tables
