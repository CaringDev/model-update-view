module Navbar.View

open Fable.React
open Fable.React.Props

let navButton href faClass txt =
    a
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
            [ str txt ] ]

let navButtons =
    div
        [ ClassName "navbar-item" ]
        [ div
            [ ClassName "buttons" ]
            [ navButton "https://www.caring.dev" "fa-external-link-square" "CaringDev" ] ]

let render =
    nav
        [ ClassName "navbar" ]
        [ div
            [ ClassName "navbar-brand" ]
            [ h1
                [ ClassName "navbar-item title" ]
                [ str "MUV" ] ]
          div
            [ ClassName "navbar-menu" ]
            [ div
                [ ClassName "navbar-end" ]
                [ navButtons ] ] ]