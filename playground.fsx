#r "nuget: FSharp.Data"

open FSharp.Data

type CardList = HtmlProvider<"https://en.uesp.net/wiki/Legends:Core_Set">

let coreSet = CardList.Load("https://en.uesp.net/wiki/Legends:Core_Set")

coreSet.Tables.Agility
coreSet.Tables.``Dual-Attribute``
coreSet.Tables.``Dual-Attribute``






type CardProvider = HtmlProvider<"https://en.uesp.net/wiki/Legends:Fiery_Imp">

let imp = CardProvider.GetSample()

imp.Html.Body().Elements().[0].Elements().[0]

let getCardName (card: CardProvider) = card.Tables

let y = "Patrick"
let x = 31

x * x
string x
x
string x + y

let addNumToString (x: int) (y: string) = string x + " " +  y

addNumToString x y

// karatsuba

let prepareNumber (x: int) = 
    let stringX = string x
    match stringX.Length % 2 = 0 with 
    | true -> stringX.[0..stringX.Length / 2 - 1] |> int, stringX.[stringX.Length / 2..] |> int
    | false -> 
        let zlead = "0" + stringX
        zlead.[0..zlead.Length / 2 - 1] |> int, zlead.[zlead.Length / 2..] |> int

let prepareNumbers x y = prepareNumber x, prepareNumber y

prepareNumbers 45 22

let makeSums ((x, y), (v, z)) = x + y, v + z

let makeMult a b = 
    let (x, y) = prepareNumber a
    let (v, z) = prepareNumber b
    let (s1, s2) = makeSums ((x, y), (v, z))
    let m1 = x * v    
    let m3 = y * z
    let m2 = (s1 * s2) - m1 - m3
    (m1, m2, m3)

let karatsubaInt (m1, m2, m3) = m1 * 100 + m2 * 10 + m3

let karatsuba a b = karatsubaInt (makeMult a b)

karatsuba 51 54
51 * 54


makeSums (prepareNumbers 99 99)