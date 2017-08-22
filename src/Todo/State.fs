module Todo.State

open Elmish
open System
open Types

let init () : Model * Cmd<Msg> =
  { input = ""; items = [ { id = 0; text = "Dummy entry. Remove." } ] }, []

let update message model =
  match message with
  | InputChanged s -> { model with input = s }, []