module Counter.View

open Fable.React
open Fable.React.Props
open Types

let simpleButton txt action dispatch =
  div
    [ ClassName "column is-narrow" ]
    [ a
        [ ClassName "button"
          OnClick (fun _ -> action |> dispatch) ]
        [ str txt ] ]

let render model dispatch =
  div
    [ ClassName "columns is-vcentered" ]
    [ div [ ClassName "column" ] [ ]
      div
        [ ClassName "column is-narrow"
          Style
            [ Width "170px" ] ]
        [ str $"Counter value: %i{model}" ]
      simpleButton "+1" Increment dispatch
      simpleButton "-1" Decrement dispatch
      div [ ClassName "column" ] [ ] ]