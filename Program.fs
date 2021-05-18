// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open My.Proto

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let myMessage = { MyMessage.empty() with MyField = ValueSome 1 }
    let message = from <| sprintf "F# using Protobuf: %i" myMessage.MyField.Value
    printfn "Hello world %s" message
    0 // return an integer exit code
