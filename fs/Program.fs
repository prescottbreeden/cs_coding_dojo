open System

let hello() =
    printf "Enter your name: "
    let name = Console.ReadLine()
    printfn "Hello %s" name

hello()

Console.ReadKey() |> ignore

// [<EntryPoint>]
// let main argv =
//     printfn "Hello World from F#!"
//     0 // return an integer exit code
