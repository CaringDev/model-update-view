module Todo.View

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let root model dispatch =
  div [] [
      ul [ Id "list" ] [ yield! model.Items |> Seq.map (fun i -> li [] [ str i.Text ]) ]
      br []
      p
        [ ClassName "control" ]
        [  input
            [ Id "todo"
              ClassName "input"
              Type "text"
              Placeholder "Yo, wazzup?"
              DefaultValue !^model.Input
              OnChange (fun ev -> !!ev.target?value |> InputChanged |> dispatch)
        ] ]
  ]