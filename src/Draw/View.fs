module Draw.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let drawRect r =
    rect
        [
            !^r.x |> X :> IProp
            !^r.y |> Y :> IProp
            Style [ CSSProp.Width r.width; Height r.height ] :> IProp
            SVGAttr.Fill "red" :> IProp
        ]
        []

let render { elements = elements } dispatch =
  let relativeCoordinates (e : Fable.Import.React.MouseEvent) =
    let rect = e.target?getBoundingClientRect()
    { x = e.clientX - !!rect?left; y = e.clientY - !!rect?top }
  div
    [ OnMouseDown (relativeCoordinates >> Adding >> dispatch)
      Style [ CSSProp.Width "800px"; Height "600px"; Border "solid 1px" ] ]
    [ svg
        [ SVGAttr.PreserveAspectRatio "none" :> IProp
          Style
            [ CSSProp.Width "100%"; Height "100%"; ] :> IProp ]
        (elements |> List.map drawRect) ]