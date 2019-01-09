namespace Home

module Types =

  type Model = string

  type Msg =
  | ChangeStr of string

module State =

  open Elmish
  open Types

  let init () : Model * Cmd<Msg> =
    "", []

  let update msg model : Model * Cmd<Msg> =
    match msg with
    | ChangeStr str ->
        str, []

module View =

  open Fable.Core
  open Fable.Core.JsInterop
  open Fable.Helpers.React
  open Fable.Helpers.React.Props
  open Types

  let render model dispatch =
    div
      [ ]
      [ p
          [ ClassName "control" ]
          [ input
              [ ClassName "input"
                DefaultValue model
                Id "username"
                Placeholder "Type your name"
                Type "text"
                OnChange (fun ev -> !!ev.target?value |> ChangeStr |> dispatch ) ] ]
        br [ ]
        span
          [ Id "helloMessage" ]
          [ str (sprintf "EHLO %s" model) ] ]