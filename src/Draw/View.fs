module Draw.View

open Browser.Types
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Types

let drawRect r =
    rect
        [
            X r.x :> IProp
            Y r.y :> IProp
            Style [ Width r.width; Height r.height ] :> IProp
            SVGAttr.Fill "red" :> IProp
        ]
        []

let render { elements = elements } dispatch =
  let relativeCoordinates (e : MouseEvent) =
    let rect = e.target?getBoundingClientRect()
    { x = e.clientX - !!rect?left; y = e.clientY - !!rect?top }
  div
    [ OnMouseDown (relativeCoordinates >> Adding >> dispatch)
      Style [ Width "800px"; Height "600px"; Border "solid 1px" ] ]
    [ svg
        [ PreserveAspectRatio "none" :> IProp
          Style
            [ Width "100%"; Height "100%"; ] :> IProp ]
        (elements |> List.map drawRect) ]