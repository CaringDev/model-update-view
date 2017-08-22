module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let navButton href faClass txt =
    p
        [ ClassName "control" ]
        [ a
            [ ClassName "button"
              Href href
              Target "_blank" ]
            [ span
                [ ClassName "icon" ]
                [ i
                    [ ClassName (sprintf "fa %s" faClass) ]
                    [ ] ]
              span
                [ ]
                [ str txt ] ] ]

let navButtons =
    span
        [ ClassName "nav-item" ]
        [ div
            [ ClassName "field is-grouped" ]
            [ navButton "https://www.caringdev.ch" "fa-external-link-square" "CaringDev" ] ]

let render =
    nav
        [ ClassName "nav" ]
        [ div
            [ ClassName "nav-left" ]
            [ h1
                [ ClassName "nav-item is-brand title is-4" ]
                [ str "MUV" ] ]
          div
            [ ClassName "nav-right" ]
            [ navButtons ] ]