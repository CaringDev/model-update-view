module Todo.View

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Types

let render model dispatch =
  div
    []
    [
      ul [ ] (model.items |> List.map (fun i -> li [] [ str i.text ]))
      br []
      p
        [ ClassName "control" ]
        [  input
            [ Id "todo"
              ClassName "input"
              Type "text"
              Placeholder "Yo, wazzup?"
              DefaultValue model.input
              OnChange (fun ev -> !!ev.target?value |> InputChanged |> dispatch)
        ] ] ]