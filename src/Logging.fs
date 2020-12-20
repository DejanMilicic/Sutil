module Sveltish.Logging

    open System.Collections.Generic
    open Browser.Dom

    let enabled = Dictionary<string,bool>()

    let init =
        enabled.["store"] <- true
        enabled.["trans"] <- true
        enabled.["dom"  ] <- false
        enabled.["style"  ] <- false

    let log source (message : string) =
        if not (enabled.ContainsKey(source)) || enabled.[source] then
            console.log(sprintf "%s: %s" source message)
