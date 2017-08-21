module Todo.State

open Elmish
open System
open Types

let init () : Model * Cmd<Msg> =
  { Input = ""; Items = [ { Id = 0; Text = "Dummy entry. Remove." } ] }, []

let update message model =
  match message with
  | InputChanged s -> { model with Input = s }, []