#r "nuget: FSharp.Data"

open FSharp.Data

type CardProvider = HtmlProvider<"https://en.uesp.net/wiki/Legends:Fiery_Imp">

let imp = CardProvider.GetSample()

imp.Tables.Table1

let mySacrificeDeck = "SPALyPxDnRdAblgOqNaMfOxhpPAAAWefqKdKeuoOqfrnoEfAbwcyqefLythUmZawganlhNeyqB"